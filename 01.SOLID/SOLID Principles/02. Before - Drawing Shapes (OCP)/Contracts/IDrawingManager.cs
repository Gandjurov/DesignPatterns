﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedDrawingShapesBefore.Contracts
{
    public interface IDrawingManager
    {
        void Draw(IShape shape);
    }
}
