
int programSelected;

loop();
void loop()
{
    do
    {
        Console.Clear();
        Console.WriteLine("This is the program were I coded most of the challanges from C# Players Guide book. \n" +
        "Please select a program from this list: \n" +
        "1 - Triangle Area Calculator \n" +
        "2 - Sister's Chocolate Eggs Distributor \n" +
        "3 - King Point Calculator \n" +
        "4 - The Defense of Consolas \n" +
        "5 - Clocktower \n" +
        "6 - Watchtower \n" +
        "7 - Inventory Shop Price \n" +
        "8 - The Prototype \n" +
        "9 - Magic Cannon \n" +
        "10 - Replicator D'To");
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
    Console.Clear();
    switch (programSelected)
    {
        case 1:
            CalculateTriangleArea();
            break;
        case 2:
            SistersEggsCalculator();
            break;
        case 3:
            KingPointCalculator();
            break;
        case 4:
            DefenseOfConsolas();
            break;
        case 5:
            ClockTower();
            break;
        case 6:
            WatchTower();
            break;
        case 7:
            BuyingInventory();
            break;
        case 8:
            ThePrototype();
            break;
        case 9:
            MagicCannon();
            break;
        case 10:
            ReplicatorDTo();
            break;
        default:
            loop();
            break;

    }
    Console.ReadKey();
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
void BuyingInventory()
{
    string itemSelected;
    int inputItem;
    string name;
    int itemPrice;

    Console.WriteLine("What's your name?");
    name = Console.ReadLine();

    Console.WriteLine("The following items are available: \n" +
        "1 - Rope \n" +
        "2 - Torches \n" +
        "3 - Climbing Equipment \n" +
        "4 - Clean Water \n" +
        "5 - Machete \n" +
        "6 - Canoe \n" +
        "7 - Food Supplies");
    Console.WriteLine("What number do you want to see the price of?");
    inputItem = Convert.ToInt32(Console.ReadLine());

    itemSelected = inputItem switch
    {
        1 => "Rope",
        2 => "Torch",
        3 => "Climbing Equipment",
        4 => "Clean Water",
        5 => "Machete",
        6 => "Canoe",
        7 => "Food Supply",
        _ => ""
    };
    itemPrice = itemSelected switch
    {
        "Rope" => 10,
        "Torch" => 15,
        "Climbing Equipment" => 25,
        "Clean Water" => 1,
        "Machete" => 20,
        "Canoe" => 200,
        "Food Supply" => 1,
        _ => 0,
    };

    if (name == "Lucas" || name == "lucas")
        itemPrice /= 2;

    if (itemSelected != "")
        Console.WriteLine($"{itemSelected} cost {itemPrice} gold.");

    else Console.WriteLine("The selected item is invalid");

}
void ThePrototype()
{
    int guess;
    int number;

    do
    {
        Console.WriteLine("User 1, enter a number between 0 and 100:");
        number = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

    } while (number < 0 || number > 100);
    Console.WriteLine("User 2, guess the number.");
    do
    {
        Console.WriteLine("What is your guess?");
        guess = Convert.ToInt32(Console.ReadLine());

        if (guess < number) Console.WriteLine($"{guess} is too low.");
        else if (guess > number) Console.WriteLine($"{guess} is too high.");
        else Console.WriteLine("You guessed the number!");

    } while (guess != number);
}
void MagicCannon()
{
    for (int i = 0; i <= 100; i++)
    {
        bool isFire = (i % 3 == 0);
        bool isEletric = (i % 5 == 0);

        if (!isFire && !isEletric)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"{i}: Normal");
        }
        else if (isFire && !isEletric)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{i}: Fire");
        }
        else if (!isFire && isEletric)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{i}: Eletric");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{i}: Fire and Eletric");
        }
    }
    Console.ForegroundColor = ConsoleColor.Gray;
}
void ReplicatorDTo()
{
    int[] firstArray = new int[5];
    int[] secondArray = new int[5];

    Console.WriteLine("Type 5 numbers to replicate");
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("Type one number:");
        firstArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.Clear();

    for (int i = 0; i < 5; i++)
    {
        secondArray[i] = firstArray[i];
        Console.WriteLine($"Original: {firstArray[i]} Copied: {secondArray[i]}");
    }
}