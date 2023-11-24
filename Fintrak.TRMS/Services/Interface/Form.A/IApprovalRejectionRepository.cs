using Fintrak.TRMS.Base;
using Fintrak.TRMS.Models;
using System.Threading.Tasks;

namespace Fintrak.TRMS.Services.Interface
{
    public interface IApprovalRejectionRepository : IBaseRepository<ApprovalRejectionRequest, ApprovalRejectionResponse>
    {
        Task<ApprovalRejectionResponse> ApprovalRejection(ApprovalRejectionRequest approvalRejectionRequest, string applicationId, string token);
    }
}
