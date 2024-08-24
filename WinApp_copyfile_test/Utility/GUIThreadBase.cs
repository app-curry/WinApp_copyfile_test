using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreadTestLibrary.Thread_2_0;

namespace WinApp_copyfile_test.Utility
{
    abstract public class GUIThreadBase : SuspendableThreadBase
    {
        public GUIThreadBase(ISynchronizeInvoke syncobj)
        {
            _synchronizingObject = syncobj;
        }

        protected ISynchronizeInvoke _synchronizingObject;
        public ISynchronizeInvoke SynchronizingObject
        {
            get { return _synchronizingObject; }
        }

    }
}
