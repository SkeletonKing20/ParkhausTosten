using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ParkVorgang
    {
        Time time;
        Parkplatz parkplatz;
        IVehicle vehicle;

        public ParkVorgang(Time time, Parkplatz parkplatz, IVehicle vehicle)
        {
            this.time = time;
            this.parkplatz = parkplatz;
            this.vehicle = vehicle;
        }
    }
}
