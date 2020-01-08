using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabricmethod
{
    class SAMSUNGBuilder : PhoneBuilder
    {
        
        public override void SetMatPlat()
        {
           this.Parts.MatPlat = new MatPlat { Type = "Материнская плата:<Samsung> " + RMpMoney + " рублей" };
        }

        public override void SetProc()
        {
            this.Parts.Proc = new Proc { Type = "Процессор:<Qualcomm Snapdragon 855> " + RProcMoney + " рублей" };
        }

        public override void SetGPU()
        {
            this.Parts.GPU = new GPU { Type = "ВидеоПроцессор:<Mali-G76> " + RGPUMoney  + " рублей" };
        }

        public override void SetMoney()
        {
            this.Parts.Money = new Money { Sum = "Итоговая цена сборки: " + (RMpMoney + RProcMoney + RGPUMoney) + " рублей" };
        }
    }
}

