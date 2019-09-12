using System;
using System.Collections.Generic;
using System.Text;

namespace EX_7A
{
    class Personnel
    {
        internal void givesInstructions()
        {
            Console.WriteLine("The Senior Marines gives instructions");
        }

        internal void executeInstructions()
        {
            Console.WriteLine("The Junior Marines execute");
        }

        internal void instructionsComplete()
        {
            Console.WriteLine("Instructions are completed.");
        }

        class seniorMarines : Personnel
        {

        }

        class juniorMarines : Personnel
        {

        }

        class Satisfaction : Personnel
        {

        }

    }
}
