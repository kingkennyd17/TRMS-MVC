using Fintrak.TRMS.Base;
using Fintrak.TRMS.FormNXPRequestDto;
using Fintrak.TRMS.FormNXPResponseDto;
using Fintrak.TRMS.Models;
using System.Threading.Tasks;

namespace Fintrak.TRMS.Services.Interface
{
    public interface IPendingFormNXPRepository : IBaseRepository<GetModel, PendingNXPResponseDto>
    {
        Task<PendingNXPResponseDto> GetPendingFormNXP(string? gsearch, string token); 
    }
}
