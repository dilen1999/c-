namespace ConsoleApplication2
{
    public class Bike : Vehicle
    {
        public string Type { get; set; }
        public void ShowType()
        {
            Console.WriteLine("Bike Type" + Type);
        }
    }
}