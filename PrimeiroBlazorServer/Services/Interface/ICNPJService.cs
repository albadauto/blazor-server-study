using PrimeiroBlazorServer.Models;

namespace PrimeiroBlazorServer.Services.Interface
{
    public interface ICNPJService
    {
        Task<Enterprise> GetEnterprise(string cnpj);
    }
}
