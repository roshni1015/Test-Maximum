// See https://aka.ms/new-console-template for more information
using TestMaximum;

Console.WriteLine("Welcome to Test Maximum");
while (true)
{
    Console.WriteLine("PLease choose the option :\n1)Maximum of three Integers\n2)Maximum of three Float values\n3) Maximum of three Strings");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            FindingMax obj1 = new FindingMax();
            int maxValueInt = obj1.MaxValueInt(40, 20, 10);
            Console.WriteLine("Maximum value when comparing three integers is " + maxValueInt);
            break;
        default:
            Console.WriteLine("please choose a correct option");
            break;
    }
}
