using ECOMM.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ECOMM.BusinessServices.Services
{
    public abstract class BaseService
    {
        public Response Success(string message, object? data = null) 
        {
            return new Response 
            {
                Status = "Success",
                StatusCode = StatusCodes.Status200OK,
                Message = message,
                Data = data
            };
        }

        public Response Success(object? data = null)
        {
            return new Response
            {
                Status = "Success",
                StatusCode = StatusCodes.Status200OK,
                Data = data
            };
        }

        public Response Error(string message, object? data = null)
        {
            return new Response
            {
                Status = "Error",
                StatusCode = StatusCodes.Status200OK,
                Message = message,
                Data = data
            };
        }

        public Response Unauthorized()
        {
            return new Response
            {
                Status = "Error",
                StatusCode = StatusCodes.Status401Unauthorized
            };
        }
    }
}
