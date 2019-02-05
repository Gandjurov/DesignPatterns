using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionWorkerBefore
{
    public class Manager
    {
        public void Manage()
        {
            var worker = new Worker();
            worker.Work();
        }
    }
}
