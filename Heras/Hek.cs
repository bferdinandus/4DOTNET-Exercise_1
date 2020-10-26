using Exercise_1.Interfaces;
using System;

namespace Heras
{
    public class Hek : IDetectieLusDevices
    {
        public void Activeer()
        {
            Open();
        }

        public void Open()
        {
            Console.WriteLine("Het Hek gaat open!");
        }
    }
}
