using Correios.NET.Models;

namespace PrimeiroBlazorServer.Services.Interface
{
    public interface ICorreiosService
    {

        Task<Package> SearchPackage(string code);
    }
}
