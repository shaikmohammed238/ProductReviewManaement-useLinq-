using System;
using System.Collections.Generic;
using System.Text;

namespace day35ProductReviewManagementWithLinq
{
    public class ProductReviews
    {
        public int ProductID { get; set; }
        public int UserID { get; set; }
        public double Rating { get; set; }
        public string Reviews { get; set; }
        public bool isLike { get; set; }
    }
}
