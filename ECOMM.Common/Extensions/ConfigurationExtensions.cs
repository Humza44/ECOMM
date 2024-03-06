using ECOMM.Common.Constants;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOMM.Common.Extensions
{
    public static class ConfigurationExtensions
    {
        public static int DefaultConnectionCommandTimeoutConfigSetting(this IConfiguration config)
        {
            var commandTimeoutStr = config[ApplicationConstants.DEFAULT_COMMAND_TIMEOUT];
            int commandTimeout;

            if (!int.TryParse(commandTimeoutStr, out commandTimeout))
            {
                // just incase app config setting is missing, this will give it a default value in secs.
                commandTimeout = 60;
            }

            return commandTimeout;
        }
    }
}
