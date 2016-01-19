using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotTry
{
    class MedicalRobot: RobotBluePrint
    {
        int sensorsmedical = 8;
        int medicalCost = 100;

       public int MedicalSensors()
        {
            int medicalsensors = Sensors(sensorsmedical);
            return medicalsensors;
        }

        public int RobotValue()
        {
            int robotValue = MedicalSensors() * medicalCost;
            return robotValue;
        }

        public int RobotIntelligence()
        {
            int robotIntelligence = Intelligence(8) * MedicalSensors();
            return robotIntelligence;
        }
        public void PrintMedR()
        {
            Console.WriteLine("The Medical Sensors are : " + MedicalSensors());
            Console.WriteLine("The Value of the Medical Robot is : " + RobotValue()+ "units ");
            Console.WriteLine("the Intelligence of this Robot is level :"+ RobotIntelligence());

        }


    }
}
