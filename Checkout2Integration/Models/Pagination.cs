using System.Collections.Generic;

namespace Checkout.Integration.Models
{
    public class Pagination
    {
        public int Page { get; set; }
        public int Limit { get; set; }
        public int Count { get; set; }
    }
    public class PaginationWrapper<T> where T : class
    {
        public List<T> Items { get; set; }
        public Pagination Pagination { get; set; }

        public PaginationWrapper()
        {
            Pagination = new Pagination();
        }
    }
}
