namespace Leftovers.Models
{
    public class Cart
    {
        public int CartId { get; set; }
        public string CartName { get; set; }


        public ApplicationUser? Provider { get; set; }
        public string ProviderName { get; set; }


        public ApplicationUser? Claimer { get; set; }
        public string ClaimerName { get; set; }

        
        public Leftover Leftover { get; set; }
        public int LeftoverId { get; set; }


        public DateTime TransactionDate { get; set; }
    }
}
