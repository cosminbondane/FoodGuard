using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodGuard.DAL.Entities
{
    public class OfferProduct
    {
        public decimal Percentage { get; set; }

        public string Name { get; set; }

        public string Photo { get; set; }

        public decimal Price { get; set; }

        public decimal NewPrice { get; set; }
    }
}
