namespace ConsoleApplication2
{
    public class DebitCardPaymrnt : Payment
    {
        public string CardNumber { get; set; }
        public DebitCardPaymrnt(double amount, string payerName, string cardNumber) : base(amount, payerName)
        {
            this.CardNumber = cardNumber;
        }

        public override void ProcessPayment()
        {
            Console.WriteLine($"Processing debiy card payment for '{PayerName}' of '{Amount}' dollar using");
            Console.WriteLine("------------------------------------------------------------------------------");
        }
    }
}