using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOMM.Common.Security
{
    public interface IUserService
    {
        string? GetUserId();
        string? GetUserName();
    }
}
