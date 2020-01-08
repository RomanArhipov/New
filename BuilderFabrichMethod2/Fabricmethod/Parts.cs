using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabricmethod
{
    class Parts
    {
        public MatPlat MatPlat { get; set; }
        
        public Proc Proc { get; set; }
       
        public GPU GPU { get; set; }

        public Money Money { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (MatPlat != null)
                sb.Append(MatPlat.Type + "\n");
            if (Proc != null)
                sb.Append(Proc.Type + "\n");
            if (GPU != null)
                sb.Append(GPU.Type + "\n");
            if (Money != null)
                sb.Append(Money.Sum + " \n");
            return sb.ToString();
        }
    }
}
