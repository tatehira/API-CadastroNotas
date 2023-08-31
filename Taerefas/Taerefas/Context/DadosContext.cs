using Microsoft.EntityFrameworkCore;
using Taerefas.Dados;

namespace Taerefas.Context
{
    public class DadoContext : DbContext
    {
        public DadoContext(DbContextOptions<DadoContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", false, true)
            .Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("ServerConnection"));
        }

        // Lista da classe que irá para o banco
        public DbSet<Dado> Dados { get; set; }
    }
}
