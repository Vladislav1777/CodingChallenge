using System;

namespace CodingChallenge.DomainModel
{
    public class CustomerTransaction
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public decimal Sum { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
