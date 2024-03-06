using ECOMM.Common.Constants;
using ECOMM.Common.Extensions;
using ECOMM.Common.Security;
using ECOMM.Persistence.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOMM.Persistence.Builder
{
    public class DBContextBuilder : IDBContextBuilder
    {
        private readonly IConfiguration _config;
        private readonly IUserService _userService;

        public DBContextBuilder(IConfiguration config, IUserService userService)
        {
            _config = config;
            _userService = userService;
        }

        public ApplicationDBContext CreateDbContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDBContext>();
            optionsBuilder.UseNpgsql(_config.GetConnectionString(ApplicationConstants.CONNECTION_STRING) ?? string.Empty);

            var oltpContext = new ApplicationDBContext(optionsBuilder.Options, _userService);
            oltpContext.Database.SetCommandTimeout(_config.DefaultConnectionCommandTimeoutConfigSetting());
            return oltpContext;
        }
    }
}
