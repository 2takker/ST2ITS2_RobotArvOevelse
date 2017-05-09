using System;
using System.Collections.Generic;
using NXT;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OevelseRobotArv1
{
    class Robot
    {
        protected Brick robotBrick;
        protected Motor leftMotor;
        protected Motor rightMotor;

        public Robot()
        {
            robotBrick = new Brick();
            leftMotor = new Motor(robotBrick, 'A');
            rightMotor = new Motor(robotBrick, 'C');
        }

        public void moveForward(byte speed)
        {
            leftMotor.rotateForward(speed);
            rightMotor.rotateForward(speed);
        }

        public void moveBackwards(byte speed)
        {
            leftMotor.rotateBackward(speed);
            rightMotor.rotateBackward(speed);
        }

        public void turnLeft(byte speed)
        {
            leftMotor.rotateBackward(speed);
            rightMotor.rotateForward(speed);
        }

        public void turnLeftDeg(byte speed, uint deg)
        {
            leftMotor.rotateBackward(speed);
            rightMotor.rotateForwardDegrees(speed, deg);
        }

        public void turnRight(byte speed)
        {
            leftMotor.rotateForward(speed);
            rightMotor.rotateBackward(speed);
        }

        public void turnRightDeg(byte speed, uint deg)
        {
            leftMotor.rotateForwardDegrees(speed, deg);
            rightMotor.rotateBackward(speed);
        }
        
        public void continueTask(ulong millisec)
        {
            robotBrick.wait(millisec);
        }

        public void stop(bool brake)
        {
            leftMotor.stop(brake);
            rightMotor.stop(brake);
        }
    }

}
