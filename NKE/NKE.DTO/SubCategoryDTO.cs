using System;
using System.Collections.Generic;
using System.Text;

namespace NKE.DTO
{
    class SubCategoryDTO:BaseDTO
    {
        public int SubCategoryId { get; set; }
        public string SubCategoryName { get; set; }
        public string SubCategoryDescription { get; set; }
    }
}
