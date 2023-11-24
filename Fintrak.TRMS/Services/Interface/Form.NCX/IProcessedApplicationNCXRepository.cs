using Fintrak.TRMS.Base;
using Fintrak.TRMS.Models;
using System.Threading.Tasks;

namespace Fintrak.TRMS.Services.Interface
{
    public interface IProcessedApplicationNCXRepository : IBaseRepository<GetModel, ProcessedApplicationNCX>
    {
        Task<ProcessedApplicationNCX> ProcessedApplicationNCX(string? searchParam, string token);
    }
}
