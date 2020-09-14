using System.Threading.Tasks;

namespace Rodan.Business.Interfaces
{
    public interface IAccountService
    {
        public Task RegisterAsync(string email);
    }
}
