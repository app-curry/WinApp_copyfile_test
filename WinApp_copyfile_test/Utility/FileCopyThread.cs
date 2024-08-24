using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp_copyfile_test.Utility
{
    public class FileCopyThread : GUIThreadBase
    {
        public FileCopyThread(Control c,
            string sourcefile, string todir) : base(c)
        {
            _sourcefile = sourcefile;
            _todir = todir;
        }

        public override void ThreadMethod()
        {
            OnThreadStartEvent(this);

            Copy(_sourcefile, _todir);

            OnThreadCompleteEvent(this, _isBreak);
        }

        public void Cancel()
        {
            _isBreak = true;
        }

        private string _sourcefile = string.Empty;
        private string _todir = string.Empty;

        protected void Copy(string sourcefile, string todir)
        {
            string filename = Path.GetFileName(sourcefile);
            string topath = Path.Combine(todir, filename);

            bool copyret = StreamCopy(sourcefile, topath);

            if (copyret)
            {
                File.SetLastWriteTime(topath, File.GetLastWriteTime(sourcefile));
                File.SetAttributes(topath, File.GetAttributes(sourcefile));
            }
            else
            {
                // コピー開始後キャンセルされたとき、コピー先のキャッシュを削除
                if (File.Exists(topath))
                {
                    File.Delete(topath);
                }
            }
        }


        protected bool StreamCopy(string frompath, string topath)
        {
            bool ret = false;

            using (FileStream fsIn = new FileStream(frompath, FileMode.Open, FileAccess.Read))
            {
                // ソースファイルサイズ
                long sourceLength = fsIn.Length;
                // コピーキャッシュサイズ
                long cacheLength = 0;

                using (FileStream fsOut = new FileStream(topath, FileMode.Create, FileAccess.Write))
                {
                    StreamCopy(sourceLength, fsIn, fsOut);
                    cacheLength = fsOut.Length;

                    fsOut.Close();
                }

                fsIn.Close();

                if (sourceLength == cacheLength)
                {
                    // 完了
                    ret = true;
                }
            }

            return ret;
        }

        // UIへの進捗通知の間隔(UIと同期頻度の調整)
        protected int _stepcount = 10;

        protected long StreamCopy(long sourceLength,
            Stream fsIn, Stream fsOut)
        {
            long r_cachelength = 0;
            int i = 0;

            byte[] readData = new byte[1024];
            int readSize = 0;
            for (; ; )
            {
                // キャンセル
                if (_isBreak)
                {
                    break;
                }

                readSize = fsIn.Read(readData, 0, readData.Length);
                r_cachelength += readSize;
                if (readSize == 0)
                    break;
                fsOut.Write(readData, 0, readSize);

                // UIに進捗通知
                if (i > _stepcount)
                {
                    OnThreadProgressEvent(this, r_cachelength, sourceLength);
                    i = 0;
                }
                i++;

            }

            OnThreadProgressEvent(this, r_cachelength, sourceLength);

            return r_cachelength;
        }


        public delegate void ThreadProgressEventHandler(object sender, long step, long max);
        public event ThreadProgressEventHandler ThreadProgressEvent;
        protected virtual void OnThreadProgressEvent(object sender, long step, long max)
        {
            if (ThreadProgressEvent != null)
            {
                _synchronizingObject.Invoke(ThreadProgressEvent, new object[] { sender, step, max });
            }
        }

        public delegate void ThreadStartEventHandler(object sender);
        public event ThreadStartEventHandler ThreadStartEvent;
        protected virtual void OnThreadStartEvent(object sender)
        {
            if (ThreadStartEvent != null)
            {
                _synchronizingObject.Invoke(ThreadStartEvent, new object[] { sender });
            }
        }

        public delegate void ThreadCompleteEventHandler(object sender, bool cancel);
        public event ThreadCompleteEventHandler ThreadCompleteEvent;
        protected virtual void OnThreadCompleteEvent(object sender, bool cancel)
        {
            if (ThreadCompleteEvent != null)
            {
                _synchronizingObject.Invoke(ThreadCompleteEvent, new object[] { sender, cancel });
            }
        }

    }
}
