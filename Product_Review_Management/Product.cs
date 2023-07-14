using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Review_Management_
{
    internal class Product
    {

        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Rating { get; set; }
        public string Review { get; set; }
        public bool IsLike { get; set; }

    }
}
