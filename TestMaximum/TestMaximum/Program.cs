﻿// See https://aka.ms/new-console-template for more information
using TestMaximum;

Console.WriteLine("Welcome to Test Maximum");
while (true)
{
    Console.WriteLine("Please Choose the Option :\n1)Maximum of three Integers\n2)Maximum of three Float values\n3) Maximum of three Strings \n4)Maximum of three using Generics");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            FindingMaxIntegers test1 = new FindingMaxIntegers();
            int MaxValueInt = test1.MaxValueInt(40, 20, 10);
            Console.WriteLine("Maximum value From three integers is " + MaxValueInt);
            break;
        case 2:
            FindingMaxofFloat test2 = new FindingMaxofFloat();
            double MaxValueFloat = test2.MaxValueFloat(4.55, 2.45, 1.05);
            Console.WriteLine("Maximum value From three Floats is " + MaxValueFloat);
            break;
        case 3:
            FindingMaxofString test3 = new FindingMaxofString();
            string MaxValueStrings = test3.MaxValueStrings("Elephant","Mango","bat");
            Console.WriteLine("Maximum value From three strings is " + MaxValueStrings);
            break;
        case 4:
            FindingMaxUsingGenerics test4 = new FindingMaxUsingGenerics();
            int MaxValueGenerics = FindingMaxUsingGenerics.MaxValueGenerics<int>(50,35,20);
            Console.WriteLine("Maximum value From three Integer is " + MaxValueGenerics);
            double MaxValueGenerics2 = FindingMaxUsingGenerics.MaxValueGenerics<double>(5.67, 4.65 ,2.75);
            Console.WriteLine("Maximum value From three Floats is " + MaxValueGenerics2);
            string MaxValueGenerics3 = FindingMaxUsingGenerics.MaxValueGenerics<string>("Bananas", "Animal", "Apple");
            Console.WriteLine("Maximum value From three strings is " + MaxValueGenerics3);
            break;

        default:
            Console.WriteLine("Please Choose a Correct Option");
            break;
    }
}
