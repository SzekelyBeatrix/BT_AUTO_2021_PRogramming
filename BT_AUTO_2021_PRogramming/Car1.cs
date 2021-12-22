using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_PRogramming
{
    class Car1
    {
        bool carStatus;
        double speed;
        double direction;
        float fuellevel;
        byte gear;
        float speed;
        ConsoleColor color;
        const byte MAX_Gear = 6;
        string carBrand;

        public string CarBrand { get => carBrand; set => carBrand = value; }

        public Car1(bool carStatus, double speed, double direction)
        {
            this.carStatus = carStatus;
            this.speed = speed;
            this.direction = direction;
          
        }

        public Car1(bool carStatus, double speed, double direction, float fuellevel, byte gear, float speed, ConsoleColor color) : this(carStatus, speed, direction, fuellevel, gear, speed)
        {
            this.color = color;
        }

        public void Accelerate()
        {
            currentAcceleration += 5;
        }
        public void Accelerate(double speedDelta)
            if (speed - speedDelta < 0>)

        public void Decelerate(double speedDelta)
            public void Steer(double angle)
        {
            direction + -angle;
        }
        public void Start()
        {
            carStatus = true;
        }
        public void Stop()
        {
            carStatus = false;
            speed = 0;
            gear = 0;
        }
        public void TurnLeft()
        {
            direction -= 90;
        }

        public void TurnRight()
        {
            // direction += 90;
            Steer(90);
        }
        public void GerUp()
        {
            if(gear == MAX_GEAR)
            {
                Console.WriteLine("Cannot increase gear, we are at maximum gear: {0}", MAX_GEAR);
            }
            else
            {
                gear++;
            }
            public void GearDown()
            {
                if (gear==0)
                {
                    Console.WriteLine("Already on gear 0");
                }
                else
                {
                    gear--;
                }
            }
        }
        public static double ConvertHpToKw(double hp)
        {
            return hp * 0.735499;
        }
        public void PrintCar()
        {
            Console.WriteLine("Current status of the cars is:");
            Console.WriteLine("Gearlevel: {0}", gear);
            Console.WriteLine("Direction angle{0}", direction);
            Console.WriteLine("Car status{0}", carStatus);
            Console.WriteLine("Car speed{0}", speed);
        }
    }
}
