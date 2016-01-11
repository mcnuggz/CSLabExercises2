using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstReadonly
{
    class ConstVReadOnly
    {
        public readonly double PI = 3.1;
        public const int InchesToFeet = 12;
        public ConstVReadOnly()
        {
            PI = 3.14;
        }
    }
}
