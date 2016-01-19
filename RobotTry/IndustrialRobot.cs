using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotTry
{
    class IndustrialRobot : RobotBluePrint
    {
        int industrialSpeed = 1;
        int industrialArms = 2;
        int industrialSensors = 5;
        int industrailMove = 4;
        public int Arms()
        {
            int arms = Sensors(industrialSensors) * industrialArms;
            return arms;
        }

        public int  BasicMovement()
        {
           int inSpeed =  Movement(industrailMove) + industrialSpeed;
           return inSpeed;
        }
        public int  Production()
        {
            int production = BasicMovement() * Arms();
            return production;
        }
        public void PrintIR()
        {
            Console.WriteLine("The industrial Robot arms : " + Arms());
            Console.WriteLine("The speed of this robot is : " + BasicMovement());
            Console.WriteLine("The Production of this Robot is : "+ Production());

        }


    }
}
