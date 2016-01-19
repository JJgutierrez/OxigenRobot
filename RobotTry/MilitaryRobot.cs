using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotTry
{
    class MilitaryRobot: RobotBluePrint
    {
        int eyeSensors = 2;
        int thermoSensors = 1;
        int weaponSensors = 1;
        int numberOfWheels = 2;
        int numberOfBatteries = 4;
        int militaryIntelligence = 10;

        public int EnemySensors()
        {
            int enemySensors = Sensors(eyeSensors) + Sensors(thermoSensors) + Sensors(weaponSensors);
            return enemySensors;
        }

        public int SpeedRobot ()
        {
            int speedRobot = Movement(numberOfWheels) + Energy(numberOfBatteries);
            return speedRobot;
        }

        public int Smart()
        {
            int smart = EnemySensors() + Intelligence(militaryIntelligence);
            return smart;
        }

        public void PrintMR()
        {
            Console.WriteLine("Your Military robot Has:");
            Console.WriteLine("Total of Sensors : " + EnemySensors());
            Console.WriteLine("The Speed is "+ SpeedRobot() +" units" );
            Console.WriteLine("Smart level is :" + Smart());

        }
    }
}
