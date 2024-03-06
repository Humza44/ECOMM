using ECOMM.Common.Constants;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOMM.Common.Security
{
    public class UserService : IUserService
    {
        private readonly HttpContext _context;

        public UserService(IHttpContextAccessor httpContextAccessor)
        {
            _context = httpContextAccessor.HttpContext;
        }

        /// <summary>
        /// Get user id from claims
        /// </summary>
        /// <returns>user id</returns>
        public string? GetUserId()
        {
            return _context.User.Claims.FirstOrDefault(c => c.Type == ClaimType.USER_ID)?.Value;
        }

        /// <summary>
        /// get user name
        /// </summary>
        /// <returns>user name</returns>
        public string? GetUserName()
        {
            return _context.User?.Identity?.Name;
        }
    }
}
