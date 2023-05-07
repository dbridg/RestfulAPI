using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("pokemon")]
    public class PokemonController : Controller
    {
        private static List<Pokemon> pokemon = new List<Pokemon>()
        {
            new Pokemon(){id=0, name="Pikachu"},
            new Pokemon(){id=1, name="NidoranM"}
        };

        [HttpGet]
        public IEnumerable<Pokemon> Get()
        {
            return pokemon;
        }

        [HttpPost]
        public void Post([FromBody]String pokemonName)
        {
            pokemon.Add(new Pokemon() {id=(pokemon.Count + 1), name=pokemonName});
        }
    }
}

