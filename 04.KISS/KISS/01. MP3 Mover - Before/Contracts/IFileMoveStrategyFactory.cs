using System;
using System.Collections.Generic;
using System.Text;

namespace KISSMp3MoverBefore.Contracts
{
    public interface IFileMoveStrategyFactory
    {
        IFileMoveStrategy Get(string type);
    }
}
