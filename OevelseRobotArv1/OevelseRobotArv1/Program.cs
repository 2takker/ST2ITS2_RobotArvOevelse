using System;
using System.Collections.Generic;
using NXT;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OevelseRobotArv1
{
    class Program
    {
        static void Main(string[] args)
        {
            FollowAndAvoidRobot rob1 = new FollowAndAvoidRobot();


            while (!Console.KeyAvailable)
            {
                rob1.followAndAvoid();
            }
            rob1.stop(true);


        }
    }
}
