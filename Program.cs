// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.Collections;

namespace ConsoleApplication2
{
    class Program // Fixed: Renamed class to follow PascalCase
    {
        static void Main(string[] args) // Fixed: Removed async and used static void
        {
            // Uncomment any section to test the functionality

            // Example 1: Variables
            // string name = "Dilen";
            // char section = 'A';
            // int number = 13;
            // double percentage = 14.67;

            // Console.WriteLine(name);
            // Console.WriteLine(section);
            // Console.WriteLine(number);
            // Console.WriteLine(percentage);

            // Example 2: Input from user
            // Console.Write("Enter your name: ");
            // string firstName = Console.ReadLine();

            // Console.Write("Enter your section: ");
            // char sec = Convert.ToChar(Console.ReadLine());

            // Console.Write("Enter your percentage: ");
            // double per = Convert.ToDouble(Console.ReadLine());

            // Example 3: Switch Case
            // Console.WriteLine("Enter month number (1 for Jan, 2 for Feb):");
            // int month = int.Parse(Console.ReadLine());
            // switch (month)
            // {
            //     case 1: case 3: case 5: case 7: case 8: case 10: case 12:
            //         Console.WriteLine("31 days");
            //         break;
            //     case 4: case 6: case 9: case 11:
            //         Console.WriteLine("30 days");
            //         break;
            //     case 2:
            //         Console.WriteLine("28 or 29 days");
            //         break;
            //     default:
            //         Console.WriteLine("Invalid month number");
            //         break;
            // }

            // Example 4: While Loop
            // Console.WriteLine("Enter a number:");
            // int number = int.Parse(Console.ReadLine());
            // while (number <= 3)
            // {
            //     Console.WriteLine("Number = " + number);
            //     number++;
            // }

            // Example 5: Array
            // int[] marks = { 12, 1, 2, 52, 82 };
            // foreach (int mark in marks)
            // {
            //     Console.WriteLine("Mark is: " + mark);
            // }

            // Example 6: ArrayList
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Sample");
            arrayList.Add("123");
            arrayList.Add('A');
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }

            List<int> EmpId = new List<int>();
            EmpId.Add(101);
            EmpId.Add(102);
            EmpId.Add(103);

            foreach (int emp in EmpId)
            {
                Console.WriteLine(emp);
            }
            Console.WriteLine();
        }
    }
}
