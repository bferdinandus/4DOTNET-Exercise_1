using Exercise_1.Interfaces;
using System;

namespace Osram
{
    public class Lamp : IDetectieLusDevices
    {
        public void Aan ()
        {
            Console.WriteLine("De lamp gaat aan.");
        }

        public void Activeer()
        {
            Aan();
        }
    }
}
