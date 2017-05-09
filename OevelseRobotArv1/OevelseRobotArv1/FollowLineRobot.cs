using System;
using System.Collections.Generic;
using NXT;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OevelseRobotArv1
{
    class FollowLineRobot : Robot
    {
        protected LightSensor lineDetector;
        public byte Boundary_ { get; set; }

        private byte turningSpeed_;

        public FollowLineRobot()
            :base()
        {
            lineDetector = new LightSensor(robotBrick, 1);
            Boundary_ = 50;
            turningSpeed_ = 30;
        }

        public void followLine()
        {
            if(lineDetector.Intensity <= Boundary_) //På sort
            {                
                turnRight(turningSpeed_);                
                continueTask(200);
                stop(false);
                moveForward(40);
                continueTask(350);
                stop(false);
            }
            if(lineDetector.Intensity >= Boundary_) //På hvid
            {                
                turnLeft(turningSpeed_);                
                continueTask(200);
                stop(false);
            }
        }
    }
}
