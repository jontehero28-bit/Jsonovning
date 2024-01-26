using System.Text.Json;
using RestSharp;
using System.IO;

RestClient client = new RestClient("https://swapi.py4e.com/api/");
Console.WriteLine("Which Star Wars Character do you want to see? Write Only Number.");

String starWarsName = Console.ReadLine();
RestRequest request = new($"people/{starWarsName}/");

RestResponse responce = client.GetAsync(request).Result;

Starwars p = JsonSerializer.Deserialize<Starwars>(responce.Content);

Console.WriteLine(p.name);


//Console.WriteLine(responce.Content);
//File.WriteAllText("starwars.json", responce.Content);

Console.ReadLine();
