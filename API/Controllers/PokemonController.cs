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

        /// <summary>
        /// Returns a list of all pokemon exisiting
        /// </summary>
        /// <returns>the list of pokemon</returns>
        [HttpGet]
        public IEnumerable<Pokemon> Get()
        {
            return pokemon;
        }

        /// <summary>
        /// Adds a pokemon to the list
        /// </summary>
        /// <param name="pokemonName">Name of the pokemon to be added</param>
        [HttpPost]
        public void Post([FromBody]String pokemonName)
        {
            pokemon.Add(new Pokemon() {id=(pokemon.Count - 1), name=pokemonName});
        }

        /// <summary>
        /// Edits a pokemon on the list
        /// </summary>
        /// <param name="id">the id of the desired pokemon to change</param>
        /// <param name="pokemonName">desired name to change to</param>
        [HttpPut("{id}")]
        public void Put(int id,[FromBody]String pokemonName)
        {
            Pokemon p = new Pokemon() { id = id, name = pokemonName };
            pokemon[id] = p;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            pokemon.RemoveAt(id);
        }
    }
}

