using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionMovementAfter.Contracts
{
    public interface IRotatable : IMovable
    {
        void Rotate();
    }
}
