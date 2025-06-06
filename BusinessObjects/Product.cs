using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public partial class Product
    {
        public Product(int id, string name, int catId, short unitInStock, decimal price) {
            this.ProductId = id;
            this.ProductName = name;
            this.CategoryId = catId;
            this.UnitsInStock = unitInStock;
            this.Price = price;
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal? Price { get; set; }
        public short? UnitsInStock { get; set; }
        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }

}
