using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;

class Program
{
    static async Task Main()
    {
        await PokeAPI();
    }

    static async Task PokeAPI()
    {
        using (HttpClient client = new HttpClient())
        {

            string url = "https://pokeapi.co/api/v2/pokemon/ditto";
            string json = await client.GetStringAsync(url);
            var views = JsonConvert.DeserializeObject<Status>(json);

            
            Console.WriteLine(views.Name);
            Console.WriteLine(views.Height);
            Console.WriteLine(views.Weight);

            foreach (var t in views.Types)
            {
                Console.WriteLine(t.Type.Name);
            }
            
        }
    }
}

public class Status {
    public string Name { get; set; }
    public double Height { get; set; }
    public double Weight { get; set; }
    public List<TypesArray> Types { get; set; }
}

public class TypesArray
{
    public TypeInfo Type { get; set; }
}

public class TypeInfo
{
    public string Name { get; set; }
}