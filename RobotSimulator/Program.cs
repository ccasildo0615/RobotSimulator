using RobotSimulator;

class Program
{

    // Position (X, Y) on a 2D grid
    public int X { get; set; }
    public int Y { get; set; }

    // Direction the robot is facing
    public enum Direction { NORTH, EAST, SOUTH, WEST }
    public Direction Facing { get; set; }

    static void Main()
    {
        // Robot default starting at position 0, 0, North
        Robot robot = new Robot(0, 0, Robot.Direction.NORTH);

        // Ask user for a command
        Console.WriteLine("\nRobot Simulation");
        Console.WriteLine("\nEnter a position PLACE (X,Y,F) ");

        while (true)
        {

            List<string> facingPosition = new List<string> { "NORTH", "SOUTH", "EAST", "WEST" };

            string firstCommand = Console.ReadLine().ToUpper();
            string[] firstCommandArr = firstCommand.Split(',');

            string test = firstCommandArr[3].ToString();

            if (firstCommandArr.Length != 4)
            {
                Console.WriteLine("Invalid command. Please try again.");
            }
            else if (firstCommandArr[0].ToString() != "PLACE")
            {
                Console.WriteLine("Invalid command. Please try again.");
            }
            else if (!int.TryParse(firstCommandArr[1], out int result1))
            {
                Console.WriteLine("X must be integer and within 0-4.");
            }
            else if (int.Parse(firstCommandArr[1]) < 0 || int.Parse(firstCommandArr[1]) > 4)
            {
                Console.WriteLine("X must be integer and within 0-4.");
            }
            else if (!int.TryParse(firstCommandArr[2], out int result2))
            {
                Console.WriteLine("Y must be integer and within 0-4.");
            }
            else if (int.Parse(firstCommandArr[2]) < 0 || int.Parse(firstCommandArr[2]) > 4)
            {
                Console.WriteLine("Y must be integer and within 0-4.");
            }
            else if (!facingPosition.Contains(firstCommandArr[3].ToString()))
            {
                Console.WriteLine("F must be in NORTH, SOUTH, EAST or WEST");
            }
            else
            {
                if (firstCommand[3].ToString() == "NORTH")
                {
                    robot = new Robot(int.Parse(firstCommandArr[1]), int.Parse(firstCommandArr[2]), Robot.Direction.NORTH);
                }
                else if (firstCommand[3].ToString() == "SOUTH")
                {
                    robot = new Robot(int.Parse(firstCommandArr[1]), int.Parse(firstCommandArr[2]), Robot.Direction.SOUTH);
                }
                else if (firstCommand[3].ToString() == "EAST")
                {
                    robot = new Robot(int.Parse(firstCommandArr[1]), int.Parse(firstCommandArr[2]), Robot.Direction.EAST);
                }
                else if (firstCommand[3].ToString() == "WEST")
                {
                    robot = new Robot(int.Parse(firstCommandArr[1]), int.Parse(firstCommandArr[2]), Robot.Direction.WEST);
                }
                break;
            }
        }        

        while (true)
        {
            Console.WriteLine("\nEnter command  ( MOVE | LEFT | RIGHT | REPORT )");
            string command = Console.ReadLine().ToUpper();

            if (command == "MOVE")
            {
                robot.Move();
            }
            else if (command == "LEFT")
            {
                robot.TurnLeft();
            }
            else if (command == "RIGHT")
            {
                robot.TurnRight();
            }
            else if (command == "REPORT")
            {
                robot.Report();
                break;
            }
            else
            {
                Console.WriteLine("Invalid command. Please try again.");
            }
        }

        Console.WriteLine("Simulation ended.");
    }



}