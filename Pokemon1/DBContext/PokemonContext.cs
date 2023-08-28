//using Pokemon1.Models;
using Microsoft.EntityFrameworkCore;
using Pokemon1.Models;

namespace Pokemon1.DBContext
{
    public class PokemonContext : DbContext
    {
        protected override void OnConfiguring
       (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "PokemonDb");
        }
        public DbSet<Pokemon> Pokemons { get; set; }
    }
}
