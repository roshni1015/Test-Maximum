// See https://aka.ms/new-console-template for more information
using TestMaximum;

Console.WriteLine("Welcome to Test Maximum");
while (true)
{
    Console.WriteLine("Please choose the option :\n1)Test Maximum of 3 Integers\n2)Test Maximum of 3 Float values\n3)Test Maximum of 3 Strings");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            FindingMax test1 = new FindingMax();
            int maxValueInt = test1.MaxValueInt(40, 20, 10);
            Console.WriteLine("Maximum value when comparing three integers is " + maxValueInt);
            break;
        case 2:
            FindingMaxofFloat test2 = new FindingMaxofFloat();
            double MaxValueFloat = test2.MaxValueFloat(4.55, 2.45, 1.05);
            Console.WriteLine("Maximum value when comparing three Float  is " + MaxValueFloat);
            break;
        case 3:
            FindingMaxofString test3 = new FindingMaxofString();
            string MaxValueStrings = test3.MaxValueStrings("Elephant","Mango","bat");
            Console.WriteLine("Maximum value when comparing three string is " + MaxValueStrings);
            break;
        default:
            Console.WriteLine("Please Choose a Correct Option");
            break;
    }
}
