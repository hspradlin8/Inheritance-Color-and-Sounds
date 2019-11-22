using System;
using System.Collections.Generic;

namespace InheritanceColorSound
{

    class Program
    {
        static void Main(string[] args)
        {
            var zero = new Zero();
            var tesla = new Tesla();
            var cessna = new Cessna();
            var ram = new Ram();

            zero.MainColor = "White";
            tesla.MainColor = "Red";
            cessna.MainColor = "Black";
            ram.MainColor = "Blue";

            tesla.MaximumOccupancy = 5;

            zero.Drive();
            tesla.Drive();
            cessna.Drive();
            ram.Drive();

            zero.Turn();
            tesla.Turn();
            cessna.Turn();
            ram.Turn();

            zero.Stop();
            tesla.Stop();
            cessna.Stop();
            ram.Stop();

        }
    }
}