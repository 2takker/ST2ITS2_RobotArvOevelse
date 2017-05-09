using System;
using System.Collections.Generic;
using NXT;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OevelseRobotArv1
{
    class FollowAndAvoidRobot : FollowLineRobot
    {
        protected UltrasonicSensor distanceDetector;
        private byte dangerZone_;
        private ulong waitTime_;


        public FollowAndAvoidRobot()
            : base()
        {
            distanceDetector = new UltrasonicSensor(robotBrick, 4);
            dangerZone_ = 20;
            waitTime_ = 1000;
        }

        public void followAndAvoid()
        {
            if (distanceDetector.Distance <= dangerZone_)
            {
                stop(true);

                //Drej 90 grader til højre
                turnRight(20);
                continueTask(waitTime_);
                stop(true);

                //Kør et stykke ligeud
                moveForward(50);
                continueTask(waitTime_);
                stop(true);


                //Drej 90 grader til venstre
                turnLeft(20) ;
                continueTask(waitTime_);
                stop(true);

                //Kør et stykke ligeud
                moveForward(50);
                continueTask(waitTime_);
                stop(true);

                //Drej 90 grader til venstre
                turnLeft(20);
                continueTask(waitTime_);
                stop(true);


                //Kør indtil sort streg fundet
                while(lineDetector.Intensity >= Boundary_)
                {
                    moveForward(50);
                    continueTask(50);
                }
                stop(true);

                //Drej 90 grader til højre
                turnRight(20);
                continueTask(waitTime_);
                stop(true);

                followLine();
            }
            else
            {
                followLine();
            }

        }


    }
}
