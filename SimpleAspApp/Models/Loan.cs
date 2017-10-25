namespace SimpleAspApp.Models
{
    public class Loan
    {
        public Loan(decimal interest = 0, decimal amount = 0, int term = 0)
        {
            this.Interest = interest;
            this.Amount = amount;
            this.Term = term;
        }

        public decimal Interest { get; set; }
        public int Term { get; set; }
        public decimal Amount { get; set; }

        //
        // will calculate the final amount given the class properties.
        public decimal FinalAmount()
        {
            decimal multiplier = 1;
            for( int i = 1; i <= this.Term; ++i )
                multiplier *= (1 + this.Interest);

            return this.Amount * multiplier;
        }
    }
}