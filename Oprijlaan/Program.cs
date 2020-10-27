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

            lus.ActiveerDevices += hek.Open;
            lus.ActiveerDevices += kuil.Open;
            lus.ActiveerDevices += lamp.Aan;

            lus.DeactiveerDevices += lamp.Uit;
            lus.DeactiveerDevices += kuil.Dicht;
            lus.DeactiveerDevices += hek.Sluit;

            lus.Trigger();
        }
    }
}
