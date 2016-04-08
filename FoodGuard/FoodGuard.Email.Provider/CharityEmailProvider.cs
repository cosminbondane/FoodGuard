using FoodGuard.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodGuard.Email.Provider
{
    public class CharityEmailProvider
    {
        protected CharityBusiness CharityBusiness = new CharityBusiness();

        public void StartForAll()
        {
            var allCharities = CharityBusiness.GetAll();
            foreach (var charity in allCharities)
            {
                var x = new
                {
                    Name = "AA"
                };

                EmailHelper.SendAsHtml<object>("New Offer", "guard@food.com", charity.Email, "New Offer", x);
            }
        }

        public void StartForOne(string toEmail)
        {
            EmailHelper.SendAsHtml<object>("New Offer", "", toEmail, "Welcome to FoodGuard", new object());
        }
    }
}
