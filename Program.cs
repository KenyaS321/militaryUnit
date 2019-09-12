using System;

namespace EX_7A
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipment ourElectronics = new Equipment();
            ourElectronics = new Scanner();
            ourElectronics.ScanPaper();
            ourElectronics = new Printer();
            ourElectronics.printPaper();
            ourElectronics = new Computer();
            ourElectronics.recievePaper();
            Personnel chainOfCommand = new Personnel();
            chainOfCommand = new seniorMarines();
            chainOfCommand.givesInstructions();
            chainOfCommand = new juniorMarines();
            chainOfCommand.executeInstructions();
            chainOfCommand = new Satisfaction();
            chainOfCommand.instructionsComplete();
            Missions adminWork = new Missions();
            adminWork = new firstTask();
            adminWork.logIntoMOL();
            adminWork = new secondTask();
            adminWork.findOreders();
            adminWork = new thirdTask();
            adminWork.printOrders();

        }

        private class seniorMarines : Personnel
        {
        }
    }

    internal class Satisfaction : Personnel
    {
    }

    internal class firstTask : Missions
    {
    }

    internal class juniorMarines : Personnel
    {
    }

    internal class Computer : Equipment
    {
    }
}
