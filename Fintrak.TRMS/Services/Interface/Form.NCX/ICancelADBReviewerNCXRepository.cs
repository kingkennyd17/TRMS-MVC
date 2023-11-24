using Fintrak.TRMS.Base;
using Fintrak.TRMS.Models;
using System.Threading.Tasks;

namespace Fintrak.TRMS.Services.Interface
{
    public interface ICancelADBReviewerNCXRepository : IBaseRepository<ADBReviewerRequestNCX, ADBReviewerResponse>
    {
        Task<ADBReviewerResponse> CancelADBReviewerNCX(ADBReviewerRequestNCX cancelADBReviewerNCXRequest, string applicationId, string token);
    }
}
