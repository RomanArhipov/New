using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabricmethod
{
    class RPcDeveloper : Developer
    {
        public RPcDeveloper(string n) : base(n)
        { }

        public override Phone Create()
        {
            return new SAMSUNG();
        }
    }
}
