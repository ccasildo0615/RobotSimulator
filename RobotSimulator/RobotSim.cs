using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSimulator
{
    class Robot
    {
        // Position (X, Y) on a 2D grid
        public int X { get; set; }
        public int Y { get; set; }

        // Direction the robot is facing
        public enum Direction { NORTH, EAST, SOUTH, WEST }
        public Direction Facing { get; set; }

        // Constructor to initialize the robot's position and direction
        public Robot(int x, int y, Direction direction)
        {
            X = x;
            Y = y;
            Facing = direction;
        }

        // Move the robot one step in the current direction
        public void Move()
        {
            switch (Facing)
            {
                case Direction.NORTH:
                    if (Y < 5)
                    {
                        Y++;
                    }
                    break;
                case Direction.EAST:
                    if (X < 5)
                    {
                        X++;
                    }
                    break;
                case Direction.SOUTH:
                    if (Y > 1)
                    {
                        Y--;
                    }                    
                    break;
                case Direction.WEST:
                    if (X > 1)
                    {
                        X--;
                    }
                    break;
            }
        }

        // Turn the robot left (counter-clockwise)
        public void TurnLeft()
        {
            Facing = (Direction)(((int)Facing + 3) % 4);
        }

        // Turn the robot right (clockwise)
        public void TurnRight()
        {
            Facing = (Direction)(((int)Facing + 1) % 4);
        }

        // Display the robot's current position and facing direction
        public void Report()
        {
            Console.WriteLine($"{X}, {Y}, {Facing}");
        }
    }

}
