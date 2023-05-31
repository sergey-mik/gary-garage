using System;

namespace Garage
{
    public class Ram : Vehicle // Gas powered truck
    {
        public double BatteryKWh { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine("The Silver Ram growls by you. Rruuummbbbbllee");
        }

    }
}