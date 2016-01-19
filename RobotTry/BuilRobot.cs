using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotTry
{
    class BuilRobot
    {
        public void DataEntry()
        {
            Console.WriteLine("Choose The Type a Robot: \n" +
                              "1 : Industrail Robot \n" +
                              "2 : Medical Robot \n" +
                              "3 : Military Robot \n");
            string choises = Console.ReadLine();
            int choise = int.Parse(choises);
            try
            {
                switch (choise)
                {
                    case 1:
                        IndustrialRobot gh = new IndustrialRobot();
                        gh.PrintIR();
                        break;
                    case 2:
                        MedicalRobot mr = new MedicalRobot();
                        mr.PrintMedR();
                        break;
                    case 3:
                        MilitaryRobot rm = new MilitaryRobot();
                        rm.PrintMR();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("No a Valid Option ..Try again!!");
                       
                        DataEntry();
                        break;

                }

            }
            catch
            {
                
            }
        }
    }
}
