using FoodGuard.Business;
using FoodGuard.DAL.Entities;
using FoodGuard.WebApi.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace FoodGuard.WebApi.Controllers
{
    public class OfferController : BaseFoodGuardController
    {
        protected OfferBusiness OfferBusiness { get; } = new OfferBusiness();

        [HttpGet]
        public FoodGuardResponse<List<OfferProduct>> GetOffersByTypeId(int typeId, int day)
        {
            try
            {
                return Response(OfferBusiness.GetOffersByTypeId(typeId, day));
            }
            catch (Exception ex)
            {
                return HandleException<List<OfferProduct>>(ex);
            }
        }
    }
}
