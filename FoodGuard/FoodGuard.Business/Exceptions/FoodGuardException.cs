using FoodGuard.Business.Enums;
using System;

namespace FoodGuard.Business.Exceptions
{
    public class FoodGuardException: ApplicationException
    {
        public FoodGuardException(FoodGuardBusinessEnum status)
         : base()
        {
            Status = status;
        }

        public FoodGuardException(string message, FoodGuardBusinessEnum status) :
            base(message)
        {
            Status = status;
        }

        public FoodGuardBusinessEnum Status { get; set; }

    }
}
