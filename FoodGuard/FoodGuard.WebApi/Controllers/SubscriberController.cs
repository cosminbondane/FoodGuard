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
    public class SubscriberController : BaseFoodGuardController
    {
        protected SubscriberBusiness SubscriberBusiness { get; } = new SubscriberBusiness();

        [HttpPost]
        public FoodGuardResponse<int> Subscribe(Charity charity)
        {
            try
            {
                return Response(SubscriberBusiness.Subscribe(charity));
            }
            catch (Exception ex)
            {
                return HandleException<int>(ex);
            }
        }
    }
}
