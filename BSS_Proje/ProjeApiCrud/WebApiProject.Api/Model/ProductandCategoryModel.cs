using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Entity;

namespace WebApiProject.Api.Model
{
    public class ProductandCategoryModel
    {
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
    }
}
