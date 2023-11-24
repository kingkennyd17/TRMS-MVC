using Fintrak.TRMS.Base;
using Fintrak.TRMS.Models;
using System.Threading.Tasks;

namespace Fintrak.TRMS.Services.Interface
{
    public interface IAccountRepository : IBaseRepository<Login, Token>
    {
        Task<Token> Login(Login user);
    }
}
