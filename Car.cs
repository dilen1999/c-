namespace ConsoleApplication2
{
    public class Car : Vehicle
    {
        public string Model;
        public void ShowModel()
        {
            Console.WriteLine("Model: " + Model);
        }
    }
}