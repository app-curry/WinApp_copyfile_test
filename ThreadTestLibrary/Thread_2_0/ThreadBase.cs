using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadTestLibrary.Thread_2_0
{

    abstract public class ThreadBase
    {
        protected volatile bool _isBreak = false;
        public bool IsBreak
        {
            get { return _isBreak; }
        }

        public void StopThread()
        {
            _isBreak = true;
        }

        public virtual Thread StartThread()
        {
            Thread thread = new Thread(ThreadMethod);

            thread.Start();

            return thread;
        }


        public abstract void ThreadMethod();
    }



}


