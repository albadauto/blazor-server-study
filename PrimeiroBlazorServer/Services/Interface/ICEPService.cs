using PrimeiroBlazorServer.Models;

namespace PrimeiroBlazorServer.Services.Interface
{
    public interface ICEPService
    {
        Task<Address> GetAddressByCEP(string cep);
    }
}
