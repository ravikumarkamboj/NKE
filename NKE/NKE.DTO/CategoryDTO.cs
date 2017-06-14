using System;
using System.Collections.Generic;
using System.Text;

namespace NKE.DTO
{
    class CategoryDTO:BaseDTO
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
    }
}
