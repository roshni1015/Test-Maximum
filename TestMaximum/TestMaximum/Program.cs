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
            FindingMaxInteger test1 = new FindingMaxInteger();
            int MaxValueInt = test1.MaxValueInt(50, 30, 15);
            Console.WriteLine("Maximum value From three integers is " + MaxValueInt);
            break;
        case 2:
            FindingMaxofFloat test2 = new FindingMaxofFloat();
            double MaxValueFloat = test2.MaxValueFloat(4.55, 2.45, 1.05);
            Console.WriteLine("Maximum value when comparing three integers is " + MaxValueFloat);
            break;
        default:
            Console.WriteLine("please choose a correct option");
            break;
    }
}
