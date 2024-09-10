using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    internal class ClassA
    {
        private IClassA iclassA;
        public ClassA(IClassA log)
        {
            this.iclassA = log;
        }

        public void Run()
        {
            iclassA.Method1("Message to be Printed");
        }
    }
}
