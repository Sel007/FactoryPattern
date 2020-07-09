using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternConsoleUI
{
    public class ThreeWheeler : IVehicle
    {
        public ThreeWheeler()
        {
        }

        public void Drive()
        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("Let's go for a ride!");
        }
    }
}
