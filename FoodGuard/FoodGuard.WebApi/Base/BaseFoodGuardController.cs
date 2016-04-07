using FoodGuard.Business.Enums;
using FoodGuard.Business.Exceptions;
using SFP.Core.Base.Models.Exceptions;
using SFP.Services.Logging;
using SFP.Web.WebApi.Controllers;
using System;

namespace FoodGuard.WebApi.Base
{
    public class BaseFoodGuardController : BaseApiController
    {
        protected FoodGuardResponse<T> HandleException<T>(Exception ex)
        {
            LogManager.LogMessage("ex ", ex);
            if (ex.GetType() == typeof(SFPException))
            {
                return Response<T>((SFPException)ex);
            }

            if (ex.GetType() == typeof(FoodGuardException))
            {
                return Response<T>((FoodGuardException)ex);
            }

            return Response<T>(ex);
        }

        protected FoodGuardResponse<T> Response<T>(T data)
        {
            FoodGuardResponse<T> response = new FoodGuardResponse<T>()
            {
                Data = data,
                Success = true
            };

            return response;
        }

        private FoodGuardResponse<T> Response<T>(SFPException ex, string format = null, params object[] args)
        {
            FoodGuardResponse<T> response = new FoodGuardResponse<T>()
            {
                Message = ex.Message,
                Success = false,
                Status = (int)ex.Status
            };

            if (response.Message == null)
            {
                response.Message = "Internal Server Error";
                if (!string.IsNullOrEmpty(format))
                {
                    response.Message += "\r\n";
                    response.Message += string.Format(format, args);
                }
            }

            //Logger.LogException(ex);

            return response;
        }

        private FoodGuardResponse<T> Response<T>(FoodGuardException ex, string format = null, params object[] args)
        {
            FoodGuardResponse<T> response = new FoodGuardResponse<T>()
            {
                Message = ex.Message,
                Success = false,
                Status = (int)ex.Status
            };

            if (response.Message == null)
            {
                response.Message = "Internal Server Error";
                if (!string.IsNullOrEmpty(format))
                {
                    response.Message += "\r\n";
                    response.Message += string.Format(format, args);
                }
            }

            LogManager.LogMessage(ex);

            return response;
        }

        private FoodGuardResponse<T> Response<T>(Exception ex, string format = null, params object[] args)
        {
            FoodGuardResponse<T> response = new FoodGuardResponse<T>()
            {
                Message = ex.Message,
                Success = false,
                Status = (int)FoodGuardBusinessEnum.ServerError
            };

            if (response.Message == null)
            {
                response.Message = "Internal Server Error";
                if (!string.IsNullOrEmpty(format))
                {
                    response.Message += "\r\n";
                    response.Message += string.Format(format, args);
                }
            }

            //Logger.LogException(ex);

            return response;
        }
    }
}
