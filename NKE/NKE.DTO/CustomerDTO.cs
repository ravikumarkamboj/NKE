using System;

namespace NKE.DTO
{
    public class CustomerDTO : BaseDTO
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerMobile { get; set; }
        public string CustomerAddress { get; set; }
    }
}
