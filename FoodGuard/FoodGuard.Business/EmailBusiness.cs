using FoodGuard.DAL.Entities;
using SFP.Core.ServiceInjection;
using SFP.Data.Dapper.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodGuard.Business
{
    public class EmailBusiness
    {
        BaseDapperRepository<EmailTemplate> ProductRepository = DependencyServiceInjection.Resolve<BaseDapperRepository<EmailTemplate>>();

        public EmailTemplate GetTemplateByName(string name)
        {
            return ProductRepository.Where(x => x.Name == name).FirstOrDefault();
        }
    }
}
