using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Task3
{
    internal abstract class TrainingMaterial : Training, ICloneable
    {
        protected TrainingMaterial(string? description) : base(description)
        {
        }

        public abstract object Clone();
    }
}
