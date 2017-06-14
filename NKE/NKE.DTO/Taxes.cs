using System;
using System.Collections.Generic;
using System.Text;

namespace NKE.DTO
{
    class Taxes:BaseDTO
    {
        public int TaxId { get; set; }
        public string TaxName { get; set; }
        public string TaxDescription { get; set; }
    }
}
