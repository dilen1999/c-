namespace ConsoleApplication2
{
    public class ElectricCar : Car
    {
        public int BattaryLevel { get; set; }
        public void ShowBattary()
        {
            Console.WriteLine(BattaryLevel + "Battary Level");
        }
    }
}