namespace Fraud_Detection.Application.Models
{
    public class OnlineTransaction
    {
        public string TransactionId { get; set; }
        public string? TransactionStatus { get; set; }
        public string? TransactionType { get; set; }
        public decimal? TransactionAmount { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string? CustomerName { get; set; }

        public OnlineTransaction(string transactionId,string transactionStatus, string transactionType,decimal transactionAmount,
            DateTime transactionDate, string customerName)
        {
            this.TransactionId = transactionId;
            this.TransactionStatus = transactionStatus;
            this.TransactionType = transactionType;
            this.TransactionAmount = transactionAmount;
            this.CustomerName = customerName;
            this.TransactionDate = transactionDate;
        }

    }
}
