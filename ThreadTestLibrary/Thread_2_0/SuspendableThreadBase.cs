using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadTestLibrary.Thread_2_0
{
    abstract public class SuspendableThreadBase : ThreadBase
    {
        public SuspendableThreadBase()
        {
            _autoResetEvent = new AutoResetEvent(false);
        }

        protected AutoResetEvent _autoResetEvent;

        protected volatile bool _isSuspend = false;
        public bool IsSuspend
        {
            get { return _isSuspend; }
        }

        /// <summary>
        /// スレッドを一時中断する
        /// </summary>
        protected void Suspend()
        {
            _autoResetEvent.WaitOne();
        }

        public void SuspendThread()
        {
            _isSuspend = true;
        }

        /// <summary>
        /// 一時中断スレッドを再開する
        /// </summary>
        protected void Resume()
        {
            _autoResetEvent.Set();
        }

        public void ResumeThread()
        {
            Resume();

            _isSuspend = false;
        }

    }
}
