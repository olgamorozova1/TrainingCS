using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Task3
{
    internal interface IVersionable
    {
        void SetVersion();

        byte[] ReadVersion();
    }
}
