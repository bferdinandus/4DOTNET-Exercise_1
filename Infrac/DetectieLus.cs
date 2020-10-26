using Exercise_1.Interfaces;
using System;
using System.Collections.Generic;

namespace Infrac
{
    public class DetectieLus
    {
        public List<IDetectieLusDevices> Devices { get; } = new List<IDetectieLusDevices>();

        public void Trigger()
        {
            Console.WriteLine("Hmmm. We zien iets...");
            // TODO: Actieveer hier alles wat aan de detectielus hangt

            foreach (IDetectieLusDevices device in Devices)
            {
                device.Activeer();
            }
        }

        public void AddDevice(IDetectieLusDevices device)
        {
            Devices.Add(device);
        }
    }
}
