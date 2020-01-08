using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabricmethod
{
    class Worker
    {
        public Parts Make(PhoneBuilder PcBuilder)
        {
            PcBuilder.CreateParts();
            PcBuilder.SetMatPlat();
            PcBuilder.SetProc();
            PcBuilder.SetGPU();
            PcBuilder.SetMoney();
            return PcBuilder.Parts;
        }
    }
}
