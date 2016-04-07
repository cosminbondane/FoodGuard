using LambdaSqlBuilder;
using System;

namespace FoodGuard.DAL.Entities
{
    [SqlLamTable(Name = "Product")]
    public class Product
    {
        [SqlLamColumn(Name = "Id")]
        public int ProductId { get; set; }

        [SqlLamColumn(Name = "Name")]
        public string ProductName { get; set; }

        [SqlLamColumn(Name = "Price")]
        public decimal Price { get; set; }

        [SqlLamColumn(Name = "Expiration")]
        public DateTime ExpirationDate { get; set; }

        [SqlLamColumn(Name = "TypeId")]
        public int TypeId { get; set; }
    }
}
