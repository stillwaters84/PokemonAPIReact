using Microsoft.EntityFrameworkCore;
using Pokemon1.Models;

namespace Pokemon1.Repositories
{
    public class PokemonRepository : IPokemonRepository
    {
        public PokemonRepository() 
        { 

        }
        public Pokemon GetPokemon()
        {
            return new Pokemon();
        }
    }
}
