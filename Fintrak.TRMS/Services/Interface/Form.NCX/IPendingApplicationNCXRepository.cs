using Fintrak.TRMS.Base;
using Fintrak.TRMS.Models;
using System.Threading.Tasks;

namespace Fintrak.TRMS.Services.Interface
{
    public interface IPendingApplicationNCXRepository : IBaseRepository<GetModel, PendingApplicationNCX>
    {
        Task<PendingApplicationNCX> PendingApplicationNCX(string? searchParam, string token);
    }
}
