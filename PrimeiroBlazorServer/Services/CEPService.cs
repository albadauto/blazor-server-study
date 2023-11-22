using Newtonsoft.Json;
using PrimeiroBlazorServer.Config;
using PrimeiroBlazorServer.Models;
using PrimeiroBlazorServer.Services.Interface;

namespace PrimeiroBlazorServer.Services
{
    public class CEPService : ICEPService
    {
        public async Task<Address> GetAddressByCEP(string cep)
        {
            using (var client = new HttpClient())
            {
                var result = await client.GetAsync($"{APIConfiguration.APICEP}/{cep}/json");
                if (result.IsSuccessStatusCode)
                {
                    var readed = await result.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Address>(readed) ?? new Address();
                }
                else
                {
                    return new Address();
                }
            }
        }
    }
}

