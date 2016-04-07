using LambdaSqlBuilder;

namespace FoodGuard.DAL.Entities
{
    [SqlLamTable(Name = "CharityProdType")]
    public class CharityProdType
    {
        [SqlLamColumn(Name = "CharityID")]
        public int CharityId { get; set; }

        [SqlLamColumn(Name = "TypeID")]
        public int TypeId { get; set; }
    }
}
