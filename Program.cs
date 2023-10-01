﻿using System.Reflection;

int programSelected = 0;

Console.WriteLine("This is the program were I coded most of the challanges from C# Players Guide book.");
Console.WriteLine("Please select a program from this list:");
Console.WriteLine("1- Triangle Area Calculator");
Console.WriteLine("2- Sister's Chocolate Eggs Distributor");
Console.WriteLine("3- King Point Calculator");

programSelected = Convert.ToInt32(Console.ReadLine());

switch (Convert.ToInt32(programSelected))
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
     default:
        break;

}

void CalculateTriangleArea() {
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
void SistersEggsCalculator ()
{
    int eggsProduced;
    int sistersEggs;
    int duckbearEggs;

    Console.WriteLine("How many eggs was produced today?");
    eggsProduced = Convert.ToInt32(Console.ReadLine());

    sistersEggs = eggsProduced / 4; //There is 4 sisters
    duckbearEggs = eggsProduced % 4;

    Console.WriteLine("Each sister gets " + sistersEggs + " eggs");
    Console.WriteLine("And the Duckbear gets " + duckbearEggs + " eggs");
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

    kingPoints = kingProvinces*provincePoints + kingDuchys*duchyPoints + kingEstate*estatePoints;

    Console.WriteLine("The King holds " + kingPoints + " points");
}