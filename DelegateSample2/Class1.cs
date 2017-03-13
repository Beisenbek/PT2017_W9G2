using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegateSample2
{
    public delegate void closeappdelegate();
    class Class1
    {
        public closeappdelegate f;
        public void DoIt()
        {
            Thread.Sleep(10000);
            f.Invoke();
        }
    }
}
