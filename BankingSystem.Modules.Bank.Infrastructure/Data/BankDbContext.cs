using BankingSystem.Modules.Bank.Infrastructure.Entity;
using Microsoft.EntityFrameworkCore;

namespace BankingSystem.Modules.Bank.Infrastructure.Data
{
    public class BankDbContext : DbContext
    {
        // Constructor donde se encuentra la configuracion necesaria para la base de datos
        public BankDbContext(DbContextOptions<BankDbContext> options) : base(options)
        {
        }

        /* Crea la etructura de una tabla en una migracion
         * Permite realizar las Operaciones CRUD sobre la entidad
        */
        public DbSet<UserEntity> Users { get; set; }
    }
}
