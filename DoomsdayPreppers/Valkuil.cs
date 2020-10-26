using Exercise_1.Interfaces;
using System;

namespace DoomsdayPreppers
{
    public class Valkuil : IDetectieLusDevices
    {
        public void Activeer()
        {
            Open();
        }

        public void Open()
        {
            Console.WriteLine("De valkuil gaat open!");
        }
    }
}
