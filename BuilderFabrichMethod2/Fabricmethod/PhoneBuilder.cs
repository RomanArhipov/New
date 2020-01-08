using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabricmethod
{
    abstract class PhoneBuilder
    {
        public Parts Parts { get; private set; }
        public void CreateParts()
        {
            Parts = new Parts();
        }
        public abstract void SetMatPlat();
        public abstract void SetProc();
        public abstract void SetGPU();
        public abstract void SetMoney();

        public int IMpMoney = 6926;
        public int IProcMoney = 15054;
        public int IGPUMoney = 35000;

        public int RMpMoney =  3600;
        public int RProcMoney = 11664;
        public int RGPUMoney = 35000;

    }
}

