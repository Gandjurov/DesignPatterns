using DependencyInversionWorkerAfter.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionWorkerAfter
{
    public class HighPerformer : IWorker
    {
        public void Work()
        {
            // do the work faster
        }
    }
}
