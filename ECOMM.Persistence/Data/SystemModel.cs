using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOMM.Persistence.Data
{
    public class SystemModel
    {
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public string ModifiedBy { get; set; } = null!;
        public DateTime ModifiedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
