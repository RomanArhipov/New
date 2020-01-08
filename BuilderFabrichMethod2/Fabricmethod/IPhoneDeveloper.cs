using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabricmethod
{
    class IpcDeveloper : Developer
    {
        public IpcDeveloper(string n) : base(n)
        { }

        public override Phone Create()
        {
            return new Ipc();
        }
    }
}
