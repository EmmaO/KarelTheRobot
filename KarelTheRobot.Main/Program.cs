using KarelTheRobot.Library;
using KarelTheRobot.Library.Config;
using KarelTheRobot.Main.implementations.archrepair;
using KarelTheRobot.Main.implementations.checkerboard;
using KarelTheRobot.Main.implementations.newspaper;
using KarelTheRobot.Main.Implementations.CentrePoint;
using KarelTheRobot.Main.Implementations.EgyptianKarel;
using KarelTheRobot.Main.Implementations.GenericImplementation;
using KarelTheRobot.Main.Implementations.HurdleImplementation;
using KarelTheRobot.Main.Implementations.MorseCode;
using KarelTheRobot.Main.Implementations.Mountain;
using KarelTheRobot.Main.Implementations.SprintImplementation;
using System;

namespace KarelTheRobot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which problem are you trying to solve?");
            Console.WriteLine();
            Console.WriteLine("0 - Mountain Climber");
            Console.WriteLine("1 - Newspaper Karel");
            Console.WriteLine("2 - Arch repair");
            Console.WriteLine("3 - Checkerboard");
            Console.WriteLine("4 - Centre point finder");
            Console.WriteLine("5 - Egyptian Karel");
            Console.WriteLine("6 - Morse code Karel");
            Console.WriteLine("7 - Sprint Karel");
            Console.WriteLine("8 - Hurdle Karel");
            Console.WriteLine("9 - Shotput Karel");
            Console.WriteLine("10 - Shotput cleaner Karel");
            Console.WriteLine("11 - Playground");
            Console.WriteLine();
            Console.WriteLine("Enter selection: ");
            var selection = Console.ReadLine();

            try
            {
                switch (selection)
                {
                    case "0":
                        new MountainImplementation().Run(GetMountainWorld());
                        break;
                    case "1":
                        new NewspaperImplementation().Run(GetNewspaperWorld());
                        break;
                    case "2":
                        new ArchRepairImplementation().Run(GetArchRepairWorld());
                        break;
                    case "3":
                        new CheckerboardImplementation().Run(GetCheckerboardWorld());
                        break;                    
                    case "4":
                        new CentrePointImplementation().Run(GetCentrePointWorld());
                        break;                    
                    case "5":
                        new EgyptianKarelImplementation().Run(GetPyramidWorld());
                        break;
                    case "6":
                        new MorseCodeImplementation().Run(GetMorseCodeWorld());
                        break;
                    case "7":
                        new SprintImplementation().Run(GetWorldByManualEntry());
                        break;
                    case "8":
                        new HurdleImplementation().Run(GetWorldByManualEntry());
                        break;
                    case "9":
                        new ShotputImplementation().Run(GetWorld("shotput", 0));
                        break;
                    case "10":
                        new ShotputCleanerImplementation().Run(GetWorld("shotputcleaner", 0));
                        break;
                    case "11":
                        new GenericImplementation().Run(GetWorld("playground", 0));
                        break;
                    default:
                        throw new ArgumentException("Invalid selection! Application shutting down..");
                }
            } catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        private static World GetMorseCodeWorld()
        {
            return new World(WorldConfig.FromJson($"worlds/homework/morsecode.json"));

        }

        private static World GetPyramidWorld()
        {
            return new World(WorldConfig.FromJson($"worlds/homework/pyramid.json"));

        }

        private static World GetMountainWorld()
        {
            return new World(WorldConfig.FromJson($"worlds/lesson/mountain.json"));
        }

        private static World GetWorldByManualEntry()
        {
            Console.WriteLine("Enter world name: ");
            var selection = Console.ReadLine();
            Console.Clear();

            return GetWorld(selection, 0);

        }

        private static World GetWorld(string selection, int lessonHomeworkSwitch)
        {
            return new World(WorldConfig.FromJson($"worlds/{(lessonHomeworkSwitch == 0 ? ("lesson") : ("homework"))}/{selection}.json"));
        }

        private static World GetCentrePointWorld()
        {
            Console.WriteLine("Select checkerboard variation: ");
            Console.WriteLine();
            Console.WriteLine("1 - 5x5");
            Console.WriteLine("2 - 20x20");
            Console.WriteLine("3 - 17x18");
            Console.WriteLine("4 - 11x12");
            Console.WriteLine("5 - 1x1");
            Console.WriteLine();
            Console.WriteLine("Enter selection: ");
            var selection = Console.ReadLine();

            Console.Clear();

            switch (selection)
            {
                case ("1"):
                    return new World(WorldConfig.FromJson("worlds/homework/centrepoint5x5.json"));
                case ("2"):
                    return new World(WorldConfig.FromJson("worlds/homework/centrepoint20x20.json"));
                case ("3"):
                    return new World(WorldConfig.FromJson("worlds/homework/centrepoint17x18.json"));
                case ("4"):
                    return new World(WorldConfig.FromJson("worlds/homework/centrepoint11x12.json"));
                case ("5"):
                    return new World(WorldConfig.FromJson("worlds/homework/centrepoint1x1.json"));
                default:
                    throw new ArgumentException("Invalid selection! Application shutting down..");
            }
        }

        private static World GetNewspaperWorld()
        {
            Console.Clear();

            return new World(WorldConfig.FromJson("worlds/homework/newspaperKarel.json"));
        }

        private static World GetArchRepairWorld()
        {
            Console.WriteLine("Select arch repair variation: ");
            Console.WriteLine();
            Console.WriteLine("1 - Variation 1");
            Console.WriteLine("2 - Variation 2");
            Console.WriteLine("3 - Variation 3");
            Console.WriteLine();
            Console.WriteLine("Enter selection: ");
            var selection = Console.ReadLine();

            Console.Clear();


            switch (selection)
            {
                case ("1"):
                    return new World(WorldConfig.FromJson("worlds/homework/archRepair1.json"));
                case ("2"):
                    return new World(WorldConfig.FromJson("worlds/homework/archRepair2.json"));                
                case ("3"):
                    return new World(WorldConfig.FromJson("worlds/homework/archRepair3.json"));
                default:
                    throw new ArgumentException("Invalid selection! Application shutting down..");
            }
        }

        private static World GetCheckerboardWorld()
        {
            Console.WriteLine("Select checkerboard variation: ");
            Console.WriteLine();
            Console.WriteLine("1 - 8x8");
            Console.WriteLine("2 - 5x3");
            Console.WriteLine("3 - 2x8");
            Console.WriteLine("4 - 7x1");
            Console.WriteLine("5 - 1x6");
            Console.WriteLine();
            Console.WriteLine("Enter selection: ");
            var selection = Console.ReadLine();

            Console.Clear();

            switch(selection)
            {
                case ("1"):
                    return new World(WorldConfig.FromJson("worlds/homework/checkerboard8x8.json"));
                case ("2"):
                    return new World(WorldConfig.FromJson("worlds/homework/checkerboard5x3.json"));
                case ("3"):
                    return new World(WorldConfig.FromJson("worlds/homework/checkerboard2x8.json"));
                case ("4"):
                    return new World(WorldConfig.FromJson("worlds/homework/checkerboard7x1.json"));
                case ("5"):
                    return new World(WorldConfig.FromJson("worlds/homework/checkerboard1x6.json"));
                default:
                    throw new ArgumentException("Invalid selection! Application shutting down..");
            }

        }
    }
}
