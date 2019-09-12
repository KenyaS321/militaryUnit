using System;
using System.Collections.Generic;
using System.Text;

namespace EX_7A
{
    class Missions
    {
        internal void logIntoMOL()
        {
            Console.WriteLine("The Marines log into MOL");
        }

        internal void findOreders()
        {
            Console.WriteLine("We find orders for the Marines coming in.");
        }

        internal void printOrders()
        {
            Console.WriteLine("The orders are printed and handed to the Marine.");
        }

        class firstTask : Missions
        {

        }

        class secondTask : Missions
        {

        }

        class thirdTask : Missions
        {

        }

    }
}
