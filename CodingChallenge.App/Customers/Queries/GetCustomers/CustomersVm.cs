using System.Collections.Generic;

namespace CodingChallenge.App.Customers.Queries.GetCustomers
{
    public class CustomersVm
    {
        public IList<CustomerDataContract> Customers { get; set; }
    }
}
