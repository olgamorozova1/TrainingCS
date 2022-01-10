using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Task3
{
    internal static class GuidExtention
    {
        public static Guid GenerateGuid (this Guid guid)
        {
            return Guid.NewGuid();
        }
    }
}
