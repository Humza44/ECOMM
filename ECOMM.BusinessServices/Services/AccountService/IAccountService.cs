using ECOMM.Common.Models;
using ECOMM.Common.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOMM.BusinessServices.Services.AccountService
{
    public interface IAccountService
    {
        Task<Response> Login(LoginModel model);
        Task<Response> Register(RegisterModel model);
        Task<Response> RegisterAdmin(RegisterModel model);
    }
}
