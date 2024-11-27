namespace ConsoleApplication2
{
    public class CreditCardPayment : Payment
    {
        public string CardNumber { get; set; }
        public CreditCardPayment(double amount, string payerName, string cardNumber) : base(amount, payerName)
        {
            this.CardNumber = cardNumber;
        }

        public override void ProcessPayment()
        {
            Console.WriteLine($"Processing payment for '{PayerName}' of '{Amount}' dollar using");
            Console.WriteLine("------------------------------------------------------------------------------");
        }
    }
}