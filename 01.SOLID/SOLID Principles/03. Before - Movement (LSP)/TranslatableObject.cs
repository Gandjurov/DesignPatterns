using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionMovementBefore
{
    public class TranslatableObject : MovableObject
    {
        public override void Translate()
        {
            // do translate logic
        }

        public override void Rotate()
        {
            throw new NotImplementedException();
        }

        public override void Move()
        {
            this.Translate();
        }
    }
}
