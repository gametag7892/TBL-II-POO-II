using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBL_II_P2
{
    class Program
    {
        static async Task Main()
        {
            Console.Write("Digite o nome de um pokemon:");
            string PokeNome = Console.ReadLine();
            await ViewPokemon.BuscarPokemon(PokeNome);
            Console.WriteLine();
            await ViewPokemon.BuscarPokemonAleatorio();
        }

    }
}
