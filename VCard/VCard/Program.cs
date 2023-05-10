using System.Text.Json;
using VCard.Models;

namespace VCard;

internal class Program
{
    static async Task Main(string[] args)
    {
        HttpClient client= new HttpClient();
        string response = await client.GetStringAsync("https://randomuser.me/api?results=5");
        var rootResults = JsonSerializer.Deserialize<Root>(response);
        foreach (var item in rootResults.results)
        {
            vCard card = new()
            {
                FullName=$"{item.name.title}{item.name.first}{item.name.last}",
                Title=item.name.title,
                FirstName=item.name.first,
                LastName=item.name.last,
                City=item.location.city,
                Country=item.location.country,
                Email=item.email,
                Phone=item.phone
            };
            card.ToVCard();
        }
    }

}