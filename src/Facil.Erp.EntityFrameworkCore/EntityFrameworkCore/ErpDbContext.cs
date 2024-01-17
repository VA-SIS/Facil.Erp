using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Facil.Erp.Authorization.Roles;
using Facil.Erp.Authorization.Users;
using Facil.Erp.MultiTenancy;
using Facil.Erp.Tasks;
using Facil.Erp.EntityFrameworkCore.Entities;
using System.Collections.Generic;



namespace Facil.Erp.EntityFrameworkCore
{
    public class ErpDbContext : AbpZeroDbContext<Tenant, Role, User, ErpDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<Pessoa> Pessoas { get; set; }

        public ErpDbContext(DbContextOptions<ErpDbContext> options)
            : base(options)
        {
        }
    }
}
