using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrac
{
    public delegate void NotifyDevice();

    public class DetectieLus
    {
        public event NotifyDevice ActiveerDevices;
        public event NotifyDevice DeactiveerDevices;

        public void Trigger()
        {
            Console.WriteLine("Hmmm. We zien iets...");
            // TODO: Actieveer hier alles wat aan de detectielus hangt

            ActiveerDevices();

            Task.Delay(2000).Wait();

            DeactiveerDevices();
        }

        
    }
}
