using Fintrak.TRMS.Base;
using Fintrak.TRMS.FormNXPResponseDto;
using Fintrak.TRMS.Models;
using System.Threading.Tasks;

namespace Fintrak.TRMS.Services.Interface
{
    public interface IProcessedNXPRepository : IBaseRepository<GetModel, ProcessedNXPResponseDto>
    {
        Task<ProcessedNXPResponseDto> GetProcessedNXP(string? gsearch, string token);
    }
}
