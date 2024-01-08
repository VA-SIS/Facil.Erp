using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Facil.Erp.Authorization.Roles;
using Facil.Erp.Authorization.Users;
using Facil.Erp.MultiTenancy;
using System.Threading.Tasks;
using Facil.Erp.Tarefas;
using Facil.Erp.Pessoas;

namespace Facil.Erp.EntityFrameworkCore
{
    public class ErpDbContext : AbpZeroDbContext<Tenant, Role, User, ErpDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }

        public ErpDbContext(DbContextOptions<ErpDbContext> options)
            : base(options)
        {
        }
    }
}
