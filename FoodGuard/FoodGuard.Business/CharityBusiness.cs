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
    public class CharityBusiness
    {
        BaseDapperRepository<Charity> CharityRepository = DependencyServiceInjection.Resolve<BaseDapperRepository<Charity>>();

        public IEnumerable<Charity> GetAll()
        {
            return CharityRepository.GetAll();
        }
    }
}
