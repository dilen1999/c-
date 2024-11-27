namespace ConsoleApplication2
{
    public class Test : Payment
    {
        public Test(double amount, string payerName) : base(amount, payerName)
        {

        }

        public void ProcessPayment()
        {
            Console.WriteLine($"Processing payment for '{PayerName}' of '{Amount}' dollar using");
            Console.WriteLine("------------------------------------------------------------------------------");
        }
    }
}