namespace ConsoleApplication2
{
    public class MyClass
    {

        int empId;
        string name;
        //Special member function 
        // public MyClass(int empId, string name)
        // {
        //     this.empId = empId;
        //     this.name = name;
        // }

        //static member function
        public static void M1()
        {

        }
        public static void M2(int a)
        {
            Console.WriteLine(a);
        }
        // MyClass.M1()
        public static int M3()
        {
            int v = 0;
            return v;
        }

        public static int M4(int m, int n)
        {
            int sum = m + n;
            return sum;
        }
        public int M5(int m, int n)
        {
            int sum = m + n;
            return sum;
        }
    }
}