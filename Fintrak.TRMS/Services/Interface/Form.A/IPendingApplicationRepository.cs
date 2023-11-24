using Fintrak.TRMS.Base;
using Fintrak.TRMS.Models;
using System.Threading.Tasks;

namespace Fintrak.TRMS.Services.Interface
{
    public interface IPendingApplicationRepository : IBaseRepository<GetModel, PendingApplication>
    {
        Task<PendingApplication> PendingApplication(string? searchParam, string token);
    }
}
