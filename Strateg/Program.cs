using System;
using System.Text;

namespace Strateg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Train locomotive = new Train(1000, "Siemens", new СoalMove());
            locomotive.Move();
            locomotive.Movable = new ElectricMove();
            locomotive.Move();

            Console.ReadLine();
        }
    }
    interface IMovable
    {
        void Move();
    }

    class СoalMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("\nПеремещение на углях");
        }
    }

    class ElectricMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("\nПеремещение на электричестве");
        }
    }
    class Train
    {
        protected int passengers; // кол-во пассажиров
        protected string model; // модель поезда

        public Train(int num, string model, IMovable mov)
        {
            this.passengers = num;
            this.model = model;
            Movable = mov;
        }
        public IMovable Movable { private get; set; }
        public void Move()
        {
            Movable.Move();
        }
    }
}