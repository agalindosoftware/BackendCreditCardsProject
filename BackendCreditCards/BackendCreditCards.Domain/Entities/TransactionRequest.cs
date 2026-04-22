namespace BackendCreditCards.BackendCreditCards.Domain.Entities
{
    public class TransactionRequest
    {
        public decimal Amount { get; set; }
        public string Country { get; set; }
        public int Attempts { get; set; }
    }
}
