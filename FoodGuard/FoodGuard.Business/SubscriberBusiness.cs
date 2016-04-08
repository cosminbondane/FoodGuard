using FoodGuard.DAL.Entities;
using SFP.Core.ServiceInjection;
using SFP.Data.Dapper.Base;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace FoodGuard.Business
{
    public class SubscriberBusiness
    {
        BaseDapperRepository<Charity> CharityRepository = DependencyServiceInjection.Resolve<BaseDapperRepository<Charity>>();

        public int Subscribe(Charity charity)
        {
            return CharityRepository.Insert(charity);
        }
    }
}
