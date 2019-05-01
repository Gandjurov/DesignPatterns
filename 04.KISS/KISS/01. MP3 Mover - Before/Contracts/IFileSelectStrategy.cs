using System;
using System.Collections.Generic;
using System.Text;

namespace KISSMp3MoverBefore
{
    public interface IFileSelectStrategy
    {
        bool CanBeSelected(string fileName);
    }
}
