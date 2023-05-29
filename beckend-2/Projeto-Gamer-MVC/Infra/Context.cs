
using Microsoft.EntityFrameworkCore;
using Projeto_Gamer_MVC.Models;

namespace Projeto_Gamer_MVC.Infra
{
    public class Context : DbContext
    {
        public Context()
        {
            
        }

        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data Souce = NOTE13-S15; initial catalog = gamerTarde; Integrated Security = true; TrustServerCertificate = true");
            }
        }

        public DbSet<Jogador> Jogador {get;set;}
        public DbSet<Equipes> Equipes {get;set;}
    }
}