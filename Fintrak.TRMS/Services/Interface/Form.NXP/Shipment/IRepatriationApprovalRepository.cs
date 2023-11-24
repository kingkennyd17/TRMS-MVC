using Fintrak.TRMS.Base;
using Fintrak.TRMS.FormNXPRequestDto;
using Fintrak.TRMS.FormNXPResponseDto;
using System.Threading.Tasks;

namespace Fintrak.TRMS.Services.Interface
{
    public interface IRepatriationApprovalRepository : IBaseRepository<RepatriationApprovalRequestDto, RepatriationApprovalResponseDto>
    {
        Task<RepatriationApprovalResponseDto> PostRepatriationApproval(RepatriationApprovalRequestDto model, string shipmentNumber, string token);
    }
}
