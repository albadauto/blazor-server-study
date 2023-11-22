using Newtonsoft.Json;
using PrimeiroBlazorServer.Config;
using PrimeiroBlazorServer.Models;
using PrimeiroBlazorServer.Services.Interface;

namespace PrimeiroBlazorServer.Services
{
    public class CNPJService : ICNPJService
    {
        public async Task<Enterprise> GetEnterprise(string cnpj)
        {
            using(var client = new HttpClient())
            {
                var response = await client.GetAsync($"{APIConfiguration.APICNPJ}{cnpj}");
                if (response.IsSuccessStatusCode)
                {
                    var readed = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Enterprise>(readed) ?? new Enterprise();

                }
                else
                {
                    return new Enterprise();
                }
            }
        }
    }
}
