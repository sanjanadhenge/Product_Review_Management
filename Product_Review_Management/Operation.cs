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
        public void RetriveRatings(List<Product> list)
        {
            var data = from Product in list
                       where Product.Rating > 3 && (Product.ProductId == 1 || Product.ProductId == 4 || Product.ProductId == 9)
                       select Product;
            foreach (var item in data)
            {
                Console.WriteLine(item.UserId + " " + item.ProductId + " " + item.Rating + " " + item.Review + " " + item.IsLike);
            }
        }
    }
}
