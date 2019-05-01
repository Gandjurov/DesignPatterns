using System;
using System.Collections.Generic;
using System.Text;

namespace KISSMp3MoverBefore.Contracts
{
    public interface IMp3Mover
    {
        string DirectoryPath { set; }

        IFileSelectStrategy SelectStrategy { set; }

        IFileRenameStrategy RenameStrategy { set; }

        IFileMoveStrategy MoveStrategy { set; }

        void Start();
    }
}
