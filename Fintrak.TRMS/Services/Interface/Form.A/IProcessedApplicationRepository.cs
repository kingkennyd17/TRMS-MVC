using Fintrak.TRMS.Base;
using Fintrak.TRMS.Models;
using System.Threading.Tasks;

namespace Fintrak.TRMS.Services.Interface
{
    public interface IProcessedApplicationRepository : IBaseRepository<GetModel, ProcessedApplication>
    {
        Task<ProcessedApplication> ProcessedApplication(string? searchParam, string token);
    }
}
