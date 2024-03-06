using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOMM.Common.Constants
{
    public class ApplicationConstants
    {
        public const string CONNECTION_STRING = "ApplicationConnectionString";
        public const string DEFAULT_COMMAND_TIMEOUT = "DatabaseConnectionSettings:ApplicationConnectionStringCommandTimeout";
        public const string JWT_SECRET = "JWT:Secret";
        public const string JWT_VALID_IS_USER = "JWT:ValidIssuer";
        public const string JWT_VALID_AUDIENCE = "JWT:ValidAudience";
    }
}
