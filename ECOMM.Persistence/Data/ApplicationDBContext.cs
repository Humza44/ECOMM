using ECOMM.Common.Security;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOMM.Persistence.Data
{
    public class ApplicationDBContext : IdentityDbContext<IdentityUser>
    {
        private readonly IUserService _userService;

        public ApplicationDBContext()
        {
        }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options, IUserService userService) : base(options)
        {
            _userService = userService;
        }

        public virtual DbSet<Product> Products { get; set; }


        //Override save changes method so that we can add system time and loggedin user in tables
        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            var objects = this.ChangeTracker.Entries()
                    .Where(p => p.State == EntityState.Added || p.State == EntityState.Deleted || p.State == EntityState.Modified);

            // Inserted objects
            foreach (var entry in objects.Where(p => p.State == EntityState.Added && p.Entity != null))
            {
                if (entry.Entity is SystemModel entity)
                {
                    // Only update the below fields - only this will get sent to the Db
                    entity.CreatedAt = DateTime.UtcNow;
                    entity.CreatedBy = _userService.GetUserId() ?? string.Empty;

                    entity.ModifiedAt = DateTime.UtcNow;
                    entity.ModifiedBy = _userService.GetUserId() ?? string.Empty; 
                }
            }

            // Updated objects
            foreach (var entry in objects.Where(p => p.State == EntityState.Modified && p.Entity != null))
            {
                if (entry.Entity is SystemModel entity)
                {
                    // Only update the below fields - only this will get sent to the Db
                    entity.ModifiedAt = DateTime.UtcNow;
                    entity.ModifiedBy = _userService.GetUserId() ?? string.Empty;
                }
            }

            // Delete objects
            foreach (var entry in objects.Where(p => p.State == EntityState.Deleted && p.Entity != null))
            {
                if (entry.Entity is SystemModel entity)
                {
                    // Set the entity to unchanged (if we mark the whole entity as Modified, every field gets sent to Db)
                    entry.State = EntityState.Unchanged;

                    // Only update the below fields - only this will get sent to the Db
                    entity.IsDeleted = true;
                    entity.ModifiedAt = DateTime.UtcNow;
                    entity.ModifiedBy = _userService.GetUserId() ?? string.Empty;
                }
            }

            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
