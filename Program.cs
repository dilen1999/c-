// // See https://aka.ms/new-console-template for more information
// // Console.WriteLine("Hello, World!");

// using System;
// using System.Collections;

// namespace ConsoleApplication2
// {
//     class Program // Fixed: Renamed class to follow PascalCase
//     {
//         static void Main(string[] args) // Fixed: Removed async and used static void
//         {
//             // Uncomment any section to test the functionality

//             // Example 1: Variables
//             // string name = "Dilen";
//             // char section = 'A';
//             // int number = 13;
//             // double percentage = 14.67;

//             // Console.WriteLine(name);
//             // Console.WriteLine(section);
//             // Console.WriteLine(number);
//             // Console.WriteLine(percentage);

//             // Example 2: Input from user
//             // Console.Write("Enter your name: ");
//             // string firstName = Console.ReadLine();

//             // Console.Write("Enter your section: ");
//             // char sec = Convert.ToChar(Console.ReadLine());

//             // Console.Write("Enter your percentage: ");
//             // double per = Convert.ToDouble(Console.ReadLine());

//             // Example 3: Switch Case
//             // Console.WriteLine("Enter month number (1 for Jan, 2 for Feb):");
//             // int month = int.Parse(Console.ReadLine());
//             // switch (month)
//             // {
//             //     case 1: case 3: case 5: case 7: case 8: case 10: case 12:
//             //         Console.WriteLine("31 days");
//             //         break;
//             //     case 4: case 6: case 9: case 11:
//             //         Console.WriteLine("30 days");
//             //         break;
//             //     case 2:
//             //         Console.WriteLine("28 or 29 days");
//             //         break;
//             //     default:
//             //         Console.WriteLine("Invalid month number");
//             //         break;
//             // }

//             // Example 4: While Loop
//             // Console.WriteLine("Enter a number:");
//             // int number = int.Parse(Console.ReadLine());
//             // while (number <= 3)
//             // {
//             //     Console.WriteLine("Number = " + number);
//             //     number++;
//             // }

//             // Example 5: Array
//             // int[] marks = { 12, 1, 2, 52, 82 };
//             // foreach (int mark in marks)
//             // {
//             //     Console.WriteLine("Mark is: " + mark);
//             // }

//             // // Example 6: ArrayList
//             // ArrayList arrayList = new ArrayList();
//             // arrayList.Add("Sample");
//             // arrayList.Add("123");
//             // arrayList.Add('A');
//             // for (int i = 0; i < arrayList.Count; i++)
//             // {
//             //     Console.WriteLine(arrayList[i]);
//             // }

//             // List<int> EmpId = new List<int>();
//             // EmpId.Add(101);
//             // EmpId.Add(102);
//             // EmpId.Add(103);

//             // foreach (int emp in EmpId)
//             // {
//             //     Console.WriteLine(emp);
//             // }
//             // Console.WriteLine();

//             // // hash table
//             // Hashtable hashtable = new Hashtable();
//             // hashtable.Add("101", "BTree1");
//             // hashtable.Add("102", "BTree2");
//             // hashtable.Add("103", "BTree3");
//             // hashtable.Add("104", "BTree4");
//             // hashtable.Add("105", "BTree5");
//             // foreach (var item in hashtable.Keys)
//             // {
//             //     Console.WriteLine(hashtable[item]);
//             // }

//             // // Sorted List
//             // SortedList sortedList = new SortedList();
//             // sortedList.Add("1", "A");
//             // sortedList.Add("2", "B");
//             // sortedList.Add("3", "C");
//             // foreach (var value in sortedList.Keys)
//             // {
//             //     Console.WriteLine(sortedList[value]);
//             // }

//             // // priority  based collection
//             // //Stack
//             // Stack stack = new Stack();
//             // stack.Push("Kala");
//             // stack.Push("Mala");
//             // stack.Push("Bala");

//             // while (stack.Count > 0)
//             // {
//             //     Console.WriteLine(stack.Pop());
//             // }
//             // Console.WriteLine("................Queue...................");
//             // //Queue
//             // Queue queue = new Queue();
//             // queue.Enqueue("Jana");
//             // queue.Enqueue("kamala");
//             // queue.Enqueue("vimal");
//             // while (queue.Count > 0)
//             // {
//             //     Console.WriteLine(queue.Dequeue());
//             // }

//             // Console.WriteLine("..............Generic collection...................");
//             // //Stack<T>
//             // Stack<string> stack1 = new Stack<string>();
//             // stack1.Push("siva");
//             // stack1.Push("sive qq");
//             // stack1.Push("siva ofr");
//             // while (stack1.Count > 0)
//             // {
//             //     Console.WriteLine(stack1.Pop());
//             // }

//             Console.WriteLine("..............Exception Handling...................");
//             //ArgumentOutOfRange Exeception
//             List<String> fruits = new List<string> { "Apple", "Banana", "Cherry" };
//             try
//             {
//                 string fruit;
//                 fruit = fruits[5];
//                 Console.WriteLine("Fruit:" + fruit);
//             }
//             catch (ArgumentOutOfRangeException exception)
//             {
//                 Console.WriteLine(exception.Message);
//             }

//         }
//     }
// }

using ConsoleApplication2;

// MyClass myClass = new MyClass();

// MyClass.M1();

// // int a;
// // Console.WriteLine("Enter the number");
// // a = int.Parse(Console.ReadLine());
// // MyClass.M2(a);

// int v = MyClass.M3();
// Console.WriteLine(v);

// int m, n;
// Console.WriteLine("Enter teh number: ");
// n = int.Parse(Console.ReadLine());

// Console.WriteLine("Enter teh number: ");
// m = int.Parse(Console.ReadLine());

// // int sum = MyClass.M4(m, n);
// MyClass myclass = new MyClass();

// int sum = myclass.M5(m, n);

// Console.WriteLine("Sum is " + sum);
// Console.ReadLine();

// MyClass myClass = new MyClass();
// myClass.Name = "B tree";
// myClass.Age = 24;

// Console.WriteLine(" display information");
// myClass.DisplayInfo();

// int empId;
// string empName, department;
// decimal salary;

// Console.WriteLine("Enter Employee id: ");
// empId = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter Employee Name: ");
// empName = Console.ReadLine();
// Console.WriteLine("Enter Employee Department: ");
// department = Console.ReadLine();
// Console.WriteLine("Enter Employee salary: ");
// salary = decimal.Parse(Console.ReadLine());

// IEmployee employee = new EmployeeDetails(empId, empName, department, salary);
// employee.DisplayEmployeeDetails();
// Console.WriteLine("Anual salary: " + employee.CalculateSalary());

// EmployeeDetails employeeDetails = (EmployeeDetails)employee;
// Console.WriteLine($"Monthly salary: {employeeDetails.MonthlySalary}");

// Car car = new Car();
// car.Speed = 120;
// car.Model = "Tata";

// car.ShowModel();
// car.ShowSpeed();

// Console.ReadLine();

// ElectricCar electricCar = new ElectricCar();
// electricCar.Speed = 100;
// electricCar.Model = "Testla";
// electricCar.BattaryLevel = 20;

// electricCar.ShowBattary();
// electricCar.ShowModel();
// electricCar.ShowSpeed();

// Console.ReadLine();

// Car car = new Car();
// car.Speed = 100;
// car.Model = "testla";


// Bike bike = new Bike();
// bike.Type = "mountain";
// bike.Speed = 299;

// car.ShowModel();
// car.ShowSpeed();

// bike.ShowType();
// bike.ShowSpeed();

// Console.ReadLine();

PaymentDetails paymentDetails = new PaymentDetails();
paymentDetails.MakePayment("1234-423434-544", "Ramu");

paymentDetails.MakePayment("9878-8979798-09897", "Ramu", "1542");

paymentDetails.MakePayment(150.00);
Console.ReadLine();