using LambdaSqlBuilder;

namespace FoodGuard.DAL.Entities
{
    [SqlLamTable(Name = "Charity")]
    public class Charity
    {
        [SqlLamColumn(Name = "Id")]
        public int CharityId { get; set; }

        [SqlLamColumn(Name = "Email")]
        public string Email { get; set; }

        [SqlLamColumn(Name = "Name")]
        public string Name { get; set; }
    }
}
