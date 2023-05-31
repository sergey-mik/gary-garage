using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();
            Ram ram = new Ram();

            fxs.Drive();
            fxs.Turn("right");
            fxs.Stop();
            Console.WriteLine();

            modelS.Drive();
            modelS.Turn("left");
            modelS.Stop();
            Console.WriteLine();

            mx410.Drive();
            mx410.Turn("right");
            mx410.Stop();
            Console.WriteLine();

            ram.Drive();
            ram.Turn("left");
            ram.Stop();
        }
    }
}