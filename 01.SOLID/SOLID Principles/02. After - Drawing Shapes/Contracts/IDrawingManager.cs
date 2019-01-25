using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedDrawingShapesAfter.Contracts
{
    public interface IDrawingManager
    {
        void Draw(IShape shape);
    }
}
