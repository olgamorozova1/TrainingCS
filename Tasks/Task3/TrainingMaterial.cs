using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Task3
{
    internal abstract class TrainingMaterial : Training
    {
        protected TrainingMaterial(string? description) : base(description)
        {
        }
    }
}
