using ECOMM.Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOMM.Persistence.Builder
{
    public interface IDBContextBuilder
    {
        ApplicationDBContext CreateDbContext();
    }
}
