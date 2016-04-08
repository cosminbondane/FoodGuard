using FoodGuard.Business;
using FoodGuard.DAL.Entities;
using FoodGuard.Email.Provider;
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

        protected CharityEmailProvider CharityEmailProvider {get;} = new CharityEmailProvider();

        [HttpPost]
        public FoodGuardResponse<int> Subscribe(Charity charity)
        {
            try
            {
                CharityEmailProvider.StartForOne(charity.Email);
                return Response(SubscriberBusiness.Subscribe(charity));
            }
            catch (Exception ex)
            {
                return HandleException<int>(ex);
            }
        }
    }
}
