using LambdaSqlBuilder;

namespace FoodGuard.DAL.Entities
{
    [SqlLamTable(Name = "Offer")]
    public class ProductType
    {
        [SqlLamColumn(Name = "Id")]
        public int ProductTypeId { get; set; }

        [SqlLamColumn(Name = "Name")]
        public string Name { get; set; }

        [SqlLamColumn(Name = "Code")]
        public int Code { get; set; }
    }
}
