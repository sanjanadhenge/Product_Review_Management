using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Review_Management_
{
    internal class Operation
    {
        public DataTable table = new DataTable();
        public void TopRecords(List<Product> list)
        {
            var data = list.Where(x => x.Rating == 5).Take(3);
            foreach (var item in data)
            {
                Console.WriteLine(item.UserId + " " + item.ProductId + " " + item.Rating + " " + item.Review + " " + item.IsLike);
            }
        }
    }
}
