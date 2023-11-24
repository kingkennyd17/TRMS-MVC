using Fintrak.TRMS.Base;
using Fintrak.TRMS.Models;
using System.Threading.Tasks;

namespace Fintrak.TRMS.Services.Interface
{
    public interface IADBReviewerRepository : IBaseRepository<ADBReviewerRequest, ADBReviewerResponse>
    {
        Task<ADBReviewerResponse> ADBReviewer(ADBReviewerRequest adbReviewerRequest, string applicationId, string token);
    }
}
