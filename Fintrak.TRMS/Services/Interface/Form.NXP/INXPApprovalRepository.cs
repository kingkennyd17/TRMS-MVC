using Fintrak.TRMS.Base;
using Fintrak.TRMS.FormNXPRequestDto;
using Fintrak.TRMS.FormNXPResponseDto;
using System.Threading.Tasks;

namespace Fintrak.TRMS.Services.Interface
{
    public interface INXPApprovalRepository : IBaseRepository<NXPApprovalRequestDto, NXPApprovalResponseDto>
    {
        Task<NXPApprovalResponseDto> PostNXPApproval(NXPApprovalRequestDto model, string applicantId, string token);
    }
}
