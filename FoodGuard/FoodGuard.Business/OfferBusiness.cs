using FoodGuard.DAL.Entities;
using SFP.Core.ServiceInjection;
using SFP.Data.Dapper.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodGuard.Business
{
    public class OfferBusiness
    {
        BaseDapperRepository<OfferProduct> OfferRepository = DependencyServiceInjection.Resolve<BaseDapperRepository<OfferProduct>>();


        public List<OfferProduct> GetOffersByTypeId(int typeId, int day)
        {
            List<OfferProduct> offers = OfferRepository.ExecuteQuery<OfferProduct>(Constants.GetOfferByType,
                           new
                           {
                               typeId = typeId,
                               day = day
                           },
                           CommandType.StoredProcedure).ToList();

            return offers;
        }
    }
}
