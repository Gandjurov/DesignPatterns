using System;
using System.Collections.Generic;
using System.Text;

namespace KISSMp3MoverBefore.Contracts
{
    public interface IFileMoveStrategy
    {
        void Move(string oldPath, string newPath);
    }
}
