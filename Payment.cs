namespace ConsoleApplication2
{
    public class Payment
    {
        public double Amount { get; set; }
        public string PayerName { get; set; }
        public Payment(double amount, string payerName)
        {
            this.Amount = amount;
            this.PayerName = payerName;
        }

        public virtual void ProcessPayment()
        {
            Console.WriteLine($"Processing payment for '{PayerName}' in the general way");
            Console.WriteLine("------------------------------------------------------------------------------");

        }
    }
}