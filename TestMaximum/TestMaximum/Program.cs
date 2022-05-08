// See https://aka.ms/new-console-template for more information
using TestMaximum;

Console.WriteLine("Welcome to Test Maximum");
while (true)
{
    Console.WriteLine("Please Choose the Option :\n1)Maximum of three Integers\n2)Maximum of three Float values \n3) Maximum of three Strings \n4)Maximum of three using Generics \n5)Maximum of three using Generics Class \n6)Maximum of More Than Three \n7)Maximum of Using Generic Method");
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
        case 5:
            int MaxValueGeneric = CreateGenericClass<int>.MaxValueGeneric<int>(50, 35, 20);
            Console.WriteLine("Maximum value From three Integer is " + MaxValueGeneric);
            double MaxValueGeneric2 = CreateGenericClass<double>.MaxValueGeneric<double>(6.87, 4.60, 2.33);
            Console.WriteLine("Maximum value From three Floats is " + MaxValueGeneric2);
            string MaxValueGeneric3 = CreateGenericClass<string>.MaxValueGeneric<string>("Mango", "Doll", "Dog");
            Console.WriteLine("Maximum value From three strings is " + MaxValueGeneric3);
            break;
        case 6:
            FindingMax_ForMoreThanThree test5 = new FindingMax_ForMoreThanThree();
            int ArrayOfIntegers = FindingMax_ForMoreThanThree.ArrayOfIntegers(95, 75, 35, 50, 45);
            Console.WriteLine("Maximum value From three Integer is " + ArrayOfIntegers);
            double ArrayOfDouble = FindingMax_ForMoreThanThree.ArrayOfDouble(7.5, 4.3, 1.4, 6.5, 3.4);
            Console.WriteLine("Maximum value From three Floats is " + ArrayOfDouble);
            string ArrayOfStrings = FindingMax_ForMoreThanThree.ArrayOfStrings("Flowers", "Doll", "Bat", "Apple" );
            Console.WriteLine("Maximum value From three strings is " + ArrayOfStrings);
            break;
        case 7:
            int[] inputArray = {25, 35, 45, 55, 65, 75, 85, 95, 15};
            int Generic = UsingGenericMethods<int>.MaxOfMultiplevalueGenerics(inputArray);
            Console.WriteLine("Max Value of Integers using Generics Method is :" + Generic);
            double[] doubleInputArray = {4.5, 3.5 ,7.5, 8.5, 2.5, 9.5, 11.5, 10.5, 12.5};
            double Generic2 = UsingGenericMethods<double>.MaxOfMultiplevalueGenerics(doubleInputArray);
            Console.WriteLine("Max Value of Float using Generics Method :" + Generic2);
            string[] stringInputArray = { "Mango", "Tea", "Watermelon", "Orange", "Pineapple", "Pear" };
            string Generic3 = UsingGenericMethods<string>.MaxOfMultiplevalueGenerics(stringInputArray);
            Console.WriteLine("Maximum of String using Generics Method is :" + Generic3);
            break;
        default:
            Console.WriteLine("Please Choose a Correct Option");
            break;
    }
}



