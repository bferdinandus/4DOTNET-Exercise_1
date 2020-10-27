using System;

namespace DoomsdayPreppers
{
    public class Valkuil
    {
        public void Activeer()
        {
            Open();
        }

        public void Open()
        {
            Console.WriteLine("De valkuil gaat open!");
        }
        public void Dicht()
        {
            Console.WriteLine("De valkuil gaat dicht!");
        }
    }
}
