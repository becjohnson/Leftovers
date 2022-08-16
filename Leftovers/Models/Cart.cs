namespace Leftovers.Models
{
    public class Cart
    {
        public int CartId { get; set; }
        public ApplicationUser? Provider { get; set; }

        public string ProviderName { get; set; }


        public ApplicationUser? Claimer { get; set; }

        public string ClaimerName { get; set; }
        

        public DateTime TransactionDate { get; set; }
    }
}
