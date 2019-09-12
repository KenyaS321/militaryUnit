using System;
using System.Collections.Generic;
using System.Text;

namespace EX_7A
{
    class Equipment
    {
        internal void ScanPaper()
        {
            Console.WriteLine("The Marines scan the documents.");
        }


        internal void recievePaper()
        {
            Console.WriteLine("Documents are printed.");
        }


        internal void printPaper()
        {
            Console.WriteLine("Then, Documents are sent to the printer.");
        }

        class Printer : Equipment
        {

        }

        class Computer : Equipment
        {

        }

        class Scanner : Equipment
        {

        }

    }
}

