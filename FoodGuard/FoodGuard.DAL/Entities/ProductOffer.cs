using LambdaSqlBuilder;

namespace FoodGuard.DAL.Entities
{
    [SqlLamTable(Name = "Offer")]
    public class ProductOffer
    {
        [SqlLamColumn(Name = "ProductID")]
        public int ProductId { get; set; }

        [SqlLamColumn(Name = "OfferID")]
        public int OfferId { get; set; }
    }
}
