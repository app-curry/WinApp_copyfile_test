using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp_copyfile_test.Utility
{
    public class DirectoryCopyThread : FileCopyThread
    {
        public DirectoryCopyThread(Control c, 
            string sourcedir, string todir) : 
            base(c, sourcedir, todir)
        {
            _sourcedir = sourcedir;
            _todir = todir;

        }

        private string _sourcedir = string.Empty;
        private string _todir = string.Empty;

        public override void ThreadMethod()
        {
            OnThreadStartEvent(this);

            CopyDirectory(_sourcedir, _todir);

            OnThreadCompleteEvent(this, _isBreak);
        }

        protected bool IsNestedPath(string sourcepath, string copytopath)
        {
            bool ret = false;

            ret = copytopath.StartsWith(sourcepath);

            return ret;
        }


        public void CopyDirectory(string sourcedir, string copytodir)
        {
            DirectoryInfo sourcedirinfo = new DirectoryInfo(sourcedir);
            string nestcopytodir = Path.Combine(copytodir, sourcedirinfo.Name);

            RecursionCopyDirectory(sourcedir, nestcopytodir);

        }


        private void RecursionCopyDirectory(string sourcedir, string copytodir)
        {

            if (!Directory.Exists(copytodir))
            {
                Directory.CreateDirectory(copytodir);
            }

            DirectoryInfo sourcedirinfo = new DirectoryInfo(sourcedir);
            FileInfo[] fileinfos = sourcedirinfo.GetFiles();

            foreach (FileInfo fileinfo in fileinfos)
            {
                if (_isBreak)
                    return;

                try
                {
                    string sourcepath = fileinfo.FullName;

                    OnCopyFileStartEvent(this, fileinfo.Name);

                    CopyFile(sourcepath, copytodir);
                }
                catch (Exception ex)
                {
                    OnThreadExceptionEvent(this, ex);
                }
            }

            foreach (DirectoryInfo dirinfo in sourcedirinfo.GetDirectories())
            {
                if (_isBreak)
                    return;

                try
                {
                    string nestsourcedir = dirinfo.FullName;
                    string nestcopytodir = Path.Combine(copytodir, dirinfo.Name);

                    RecursionCopyDirectory(nestsourcedir, nestcopytodir);
                }
                catch (Exception ex)
                {
                    OnThreadExceptionEvent(this, ex);
                }
            }

        }

        public delegate void ThreadExceptionEventHandler(object sender, Exception ex);
        public event ThreadExceptionEventHandler ThreadExceptionEvent;
        protected virtual void OnThreadExceptionEvent(object sender, Exception ex)
        {
            if (ThreadExceptionEvent != null)
            {
                _synchronizingObject.Invoke(ThreadExceptionEvent, new object[] { sender, ex });
            }
        }

        public delegate void CopyFileStartEventHandler(object sender, string filename);
        public event CopyFileStartEventHandler CopyFileStartEvent;
        protected virtual void OnCopyFileStartEvent(object sender, string filename)
        {
            if (CopyFileStartEvent != null)
            {
                _synchronizingObject.Invoke(CopyFileStartEvent, new object[] { sender, filename });
            }
        }

    }
}
