namespace ConsoleApplication2
{
    public class CashPayment : Payment
    {
        public CashPayment(double amount, string payerName) : base(amount, payerName)
        {

        }

        public override void ProcessPayment()
        {
            Console.WriteLine($"Processing cash payment for '{PayerName}' of '{Amount}' dollar using");
            Console.WriteLine("------------------------------------------------------------------------------");
        }
    }
}