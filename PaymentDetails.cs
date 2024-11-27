namespace ConsoleApplication2
{
    public class PaymentDetails
    {
        public void MakePayment(string cardNumber, string cardHolderName)
        {
            Console.WriteLine($"Processing credit payment for '{cardHolderName}' using card no '{cardNumber}'.");
            Console.WriteLine("------------------------------------------------------------------------------");
        }
        public void MakePayment(string cardNumber, string cardHolderName, string pin)
        {
            Console.WriteLine($"Processing debit payment for '{cardHolderName}' using card no '{cardNumber}'.");
            Console.WriteLine("------------------------------------------------------------------------------");
        }
        public void MakePayment(double cashAmount)
        {
            Console.WriteLine($"Processing cash payent of '{cashAmount}' dollars.");
            Console.WriteLine("------------------------------------------------------------------------------");
        }
    }
}