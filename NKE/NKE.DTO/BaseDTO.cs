using System;

namespace NKE.DTO
{
    public class BaseDTO
    {
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public  string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}