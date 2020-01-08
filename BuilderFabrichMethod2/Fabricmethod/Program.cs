using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabricmethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer dev = new IpcDeveloper("Samsung");
            Console.WriteLine("Сборка смартфона: " + dev.Name);
            Phone pc1 = dev.Create();
            Worker worker = new Worker();
            PhoneBuilder builder = new SAMSUNGBuilder();
            Parts RParts = worker.Make(builder);
            Console.WriteLine(RParts.ToString());

            dev = new RPcDeveloper("iPhone");
            Console.WriteLine("Сборка смартфона: " + dev.Name);
            Phone pc2 = dev.Create();
            builder = new IPhoneBuilder();
            Parts IParts = worker.Make(builder);
            Console.WriteLine(IParts.ToString());

            Console.ReadLine();
        }
    }
}
