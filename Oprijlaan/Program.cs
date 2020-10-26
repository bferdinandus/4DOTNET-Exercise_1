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
            Valkuil kuil = new Valkuil();

            DetectieLus lus = new DetectieLus();
            lus.AddDevice(hek);
            lus.AddDevice(kuil);
            lus.AddDevice(lamp);

            lus.Trigger();
        }
    }
}
