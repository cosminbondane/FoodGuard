using LambdaSqlBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodGuard.DAL.Entities
{
    [SqlLamTable(Name = "EmailTemplate")]
    public class EmailTemplate
    {
        [SqlLamColumn(Name = "Id")]
        public int EmailTemplateId { get; set; }

        [SqlLamColumn(Name = "Name")]
        public string Name { get; set; }

        [SqlLamColumn(Name = "Html")]
        public string Html { get; set; }
    }
}
