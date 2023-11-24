using Fintrak.TRMS.Base;
using Fintrak.TRMS.Models;
using System.Threading.Tasks;

namespace Fintrak.TRMS.Services.Interface
{
    public interface IDisbursementReviewerRepository : IBaseRepository<DisbursementReviewerRequest, DisbursementReviewerResponse>
    {
        Task<DisbursementReviewerResponse> DisbursementReviewer(DisbursementReviewerRequest disbursementReviewerRequest, string applicationId, string token);
        Task<DisbursementReviewerResponse> RejectDisbursement(RejectDisbursementRequest rejectdisbursementRequest, string applicationId, string token);
    }
}
