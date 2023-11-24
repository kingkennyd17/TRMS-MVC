using Fintrak.TRMS.Base;
using Fintrak.TRMS.FormNXPRequestDto;
using Fintrak.TRMS.FormNXPResponseDto;
using System.Threading.Tasks;

namespace Fintrak.TRMS.Services.Interface
{
    public interface INXPCancellationRepository : IBaseRepository<NXPCancellationRequestDto, NXPCancellationResponseDto>
    {
        Task<NXPCancellationResponseDto> PostNXPCancellation(NXPCancellationRequestDto model, string applicantId, string token);
    }
}
