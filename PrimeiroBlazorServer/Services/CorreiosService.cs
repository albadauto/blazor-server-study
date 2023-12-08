using Correios.NET.Models;
using PrimeiroBlazorServer.Services.Interface;

namespace PrimeiroBlazorServer.Services
{
    public class CorreiosService : ICorreiosService
    {
        public async Task<Package> SearchPackage(string code)
        {
            try
            {
                var result = await new Correios.NET.CorreiosService().GetPackageTrackingAsync(code);
                return result;
            }
            catch
            {

                return null;
            }
           
        }
    }
}
