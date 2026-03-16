using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ViewPokemon
{
    public static async Task BuscarPokemon(string nome)
    {
        using (HttpClient client = new HttpClient())
        {

            string url = $"https://pokeapi.co/api/v2/pokemon/{nome}";
            string json = await client.GetStringAsync(url);
            var views = JsonConvert.DeserializeObject<PokeInfo>(json);

            Console.WriteLine("Pokemon Encontrado!");
            Console.WriteLine($"Id: {views.Id}");
            Console.WriteLine($"Nome: {views.Name}");
            Console.WriteLine($"Altura: {views.Height}");
            Console.WriteLine($"Peso: {views.Weight}");
            Console.WriteLine($"Base Experience: {views.Base_Experience}");

        }
    }

    public static async Task BuscarPokemonAleatorio()
    {
        Random random = new Random();
        int numero = random.Next(1, 1025);

        using (HttpClient client = new HttpClient())
        {

            string url = $"https://pokeapi.co/api/v2/pokemon/{numero}";
            string json = await client.GetStringAsync(url);
            var views = JsonConvert.DeserializeObject<PokeInfo>(json);

            Console.WriteLine("Pokemon Encontrado!");
            Console.WriteLine($"Id: {views.Id}");
            Console.WriteLine($"Nome: {views.Name}");
            Console.WriteLine($"Altura: {views.Height}");
            Console.WriteLine($"Peso: {views.Weight}");
            Console.WriteLine($"Base Experience: {views.Base_Experience}");

        }
    }
}
