using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Entity
{
    public class Product
    {
        //product tablosundaki sütunlar

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public DateTime ProductDateCreate { get; set; }
        public int CategoryId { get; set; }

        // foreign Key
        public Category Category { get; set; }

    }
}
