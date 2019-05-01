using System;
using System.Collections.Generic;
using System.Text;

namespace KISSMp3MoverBefore.Contracts
{
    public interface IFileRenameStrategyFactory
    {
        IFileRenameStrategy Get(string type);
    }
}
