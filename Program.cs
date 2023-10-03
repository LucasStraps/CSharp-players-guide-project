
int programSelected;

loop();
void loop()
{
    do
    {
        Console.Clear();
        Console.WriteLine("This is the program were I coded most of the challanges from C# Players Guide book. \n" +
        "Please select a program from this list: \n" +
        "1- Triangle Area Calculator \n" +
        "2- Sister's Chocolate Eggs Distributor \n" +
        "3- King Point Calculator \n" +
        "4- The Defense of Consolas \n" +
        "5- Clocktower \n" +
        "6- Watchtower");
        String input = Console.ReadLine();
        if (input.Length == 0)
        {
            loop();
        }
        programSelected = Convert.ToInt32(input);

        menu(programSelected);
    } while (programSelected != 0);
}


void menu(Int32 programSelected)
{
    switch (programSelected)
    {
        case 1:
            Console.Clear();
            CalculateTriangleArea();
            Console.ReadKey();
            break;
        case 2:
            Console.Clear();
            SistersEggsCalculator();
            Console.ReadKey();
            break;
        case 3:
            Console.Clear();
            KingPointCalculator();
            Console.ReadKey();
            break;
        case 4:
            Console.Clear();
            DefenseOfConsolas();
            Console.ReadKey();
            break;
        case 5:
            Console.Clear();
            ClockTower();
            Console.ReadKey();
            break;
        case 6:
            Console.Clear();
            WatchTower();
            Console.ReadKey();
            break;
        default:
            loop();
            break;

    }
}
void CalculateTriangleArea()
{
    float triangleBase;
    float triangleHeight;
    float triangleArea;

    Console.WriteLine("What is the triangle base?");
    triangleBase = Convert.ToSingle(Console.ReadLine());

    Console.WriteLine("What is the triangle height?");
    triangleHeight = Convert.ToSingle(Console.ReadLine());

    triangleArea = triangleBase * triangleHeight / 2f;

    Console.WriteLine("The triangle area is: " + triangleArea);

}
void SistersEggsCalculator()
{
    int eggsProduced;
    int sistersEggs;
    int duckbearEggs;

    Console.WriteLine("How many eggs was produced today?");
    eggsProduced = Convert.ToInt32(Console.ReadLine());

    sistersEggs = eggsProduced / 4; //There are 4 sisters
    duckbearEggs = eggsProduced % 4;

    Console.WriteLine($"Each sister gets {sistersEggs} eggs");
    Console.WriteLine($"And the Duckbear gets {duckbearEggs} eggs");
}
void KingPointCalculator()
{
    int provincePoints = 6;
    int duchyPoints = 3;
    int estatePoints = 1;
    int kingProvinces;
    int kingDuchys;
    int kingEstate;
    int kingPoints;

    Console.WriteLine("How many provinces does the King have? ");
    kingProvinces = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("How many duchys does the King have? ");
    kingDuchys = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("How many estates does the King have? ");
    kingEstate = Convert.ToInt32(Console.ReadLine());

    kingPoints = kingProvinces * provincePoints + kingDuchys * duchyPoints + kingEstate * estatePoints;

    Console.WriteLine($"The King holds {kingPoints} points");
}
void DefenseOfConsolas()
{
    int targetRow;
    int targetCol;

    Console.Title = "Defense of Consolas";

    Console.WriteLine("What is the target row of the airship?");
    targetRow = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("What is the target column of the airship?");
    targetCol = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Deploy to the blocks:");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"({targetRow},{targetCol - 1})");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"({targetRow - 1},{targetCol})");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"({targetRow}, {targetCol + 1})");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"({targetRow + 1}, {targetCol})");
    Console.ForegroundColor = ConsoleColor.Gray;

    Console.Beep(440, 1000);
}
void ClockTower()
{
    Console.Title = "ClockTower";
    int input;

    Console.WriteLine("Feed a number to the clock;");
    input = Convert.ToInt32(Console.ReadLine());

    bool isOdd = (input % 2 == 0);

    if (isOdd)
    {
        Console.Clear();
        Console.WriteLine("Tock");
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Tick");
    }
}
void WatchTower()
{
    int x;
    int y;
    string xCardinalDirection;
    string yCardinalDirection;

    Console.WriteLine("The coordinates are relative to the watchtower. So it's possible for numbers to be negative.");
    Console.WriteLine("What is the X coordinate of the enemy?");
    x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("What is the Y coordinate of the enemy?");
    y = Convert.ToInt32(Console.ReadLine());

    if (x > 0) xCardinalDirection = "east";
    else if (x < 0) xCardinalDirection = "west";
    else xCardinalDirection = "here";

    if (y > 0) yCardinalDirection = "North";
    else if (y < 0) yCardinalDirection = "South";
    else yCardinalDirection = "here";

    if (xCardinalDirection == "here" && yCardinalDirection == "here") Console.WriteLine("The enemy is here!");
    else Console.WriteLine($"The enemy is to the {yCardinalDirection}{xCardinalDirection}!");
            
}