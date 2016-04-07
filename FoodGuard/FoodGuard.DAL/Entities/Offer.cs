using LambdaSqlBuilder;
using System;

namespace FoodGuard.DAL.Entities
{
    [SqlLamTable(Name = "Offer")]
    public class Offer
    {
        [SqlLamColumn(Name = "Id")]
        public int OfferId { get; set; }
        
        [SqlLamColumn(Name = "ExpirationDateOffer")]
        public DateTime ExpirationDate { get; set; }

        [SqlLamColumn(Name = "Percentage")]
        public decimal Percentage { get; set; }

        [SqlLamColumn(Name = "TypeId")]
        public int TypeId { get; set; }
    }
}
