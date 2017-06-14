using System;

namespace NKE.DTO
{
    public class CompanyDTO : BaseDTO
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyMobile { get; set; }
        public string CompanyAddress { get; set; }
    }
}
