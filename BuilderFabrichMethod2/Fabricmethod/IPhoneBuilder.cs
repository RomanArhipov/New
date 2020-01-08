using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabricmethod
{
    class IPhoneBuilder : PhoneBuilder
    {
        
        public override void SetMatPlat()
        {
            this.Parts.MatPlat = new MatPlat { Type = "Материнская плата:<Apple>  " + IMpMoney + " рублей" };
        }

        public override void SetProc()
        {
            this.Parts.Proc = new Proc { Type = "Процессор:<A13 Bionic > " + IProcMoney + " рублей" };
        }

        public override void SetGPU()
        {
            this.Parts.GPU = new GPU { Type = "ВидеоПроцессор:<A13 Bionic> " + IGPUMoney + " рублей" };
        }

        public override void SetMoney()
        {
            this.Parts.Money = new Money { Sum = "Итоговая цена сборки: " + (IMpMoney + IProcMoney + IGPUMoney) + " рублей" };
        }
    }
}
