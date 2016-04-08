using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodGuard.DAL.Entities
{
    public class ProductProdType
    {
        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public DateTime ExpirationDate { get; set; }

        public int TypeId { get; set; }

        public string Photo { get; set; }

        public int Code { get; set; }

        public string Name { get; set; }
    }
}
