using System;
using Heras;
using Infrac;
using Osram;
using DoomsdayPreppers;

namespace Oprijlaan
{
    class Program
    {
        static void Main(string[] args)
        {
            Hek hek = new Hek();
            Lamp lamp = new Lamp();
            DetectieLus lus = new DetectieLus();
            Valkuil kuil = new Valkuil();

            lus.Trigger();

        }
    }
}
