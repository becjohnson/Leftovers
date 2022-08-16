namespace Leftovers.Models
{
    public class Leftover
    {
        public int LeftoverId { get; set; }

        public string Title { get; set; }

        public string? Description { get; set; }

        public int Quantity { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Address { get; set; }

        public string ZipCode { get; set; }

        public DateTime ExpirationDate { get; set; }

        public DateTime CreatedDate { get; set; }

        public ApplicationUser Provider { get; set; }
    }
}
