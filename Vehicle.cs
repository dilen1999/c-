namespace ConsoleApplication2
{
    public class Vehicle
    {
        public int Speed { get; set; }
        public void ShowSpeed()
        {
            Console.WriteLine("Speed: " + Speed);
        }
    }
}