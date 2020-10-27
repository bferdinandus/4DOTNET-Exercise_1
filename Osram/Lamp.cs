using System;
using System.Threading.Tasks;

namespace Osram
{
    public class Lamp
    {
        public void Aan ()
        {
            Task.Delay(1000).Wait();
            Console.WriteLine("De lamp gaat aan.");
        }

        public void Uit()
        {
            Console.WriteLine("De lamp gaat uit.");
        }

        public void Activeer()
        {
            Aan();
        }
    }
}
