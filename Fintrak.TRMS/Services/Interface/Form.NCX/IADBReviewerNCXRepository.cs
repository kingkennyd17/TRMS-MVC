using Fintrak.TRMS.Base;
using Fintrak.TRMS.Models;
using System.Threading.Tasks;

namespace Fintrak.TRMS.Services.Interface
{
    public interface IADBReviewerNCXRepository : IBaseRepository<ADBReviewerRequestNCX, ADBReviewerResponse>
    {
        Task<ADBReviewerResponse> ADBReviewerNCX(ADBReviewerRequestNCX adbReviewerNCXRequest, string applicationId, string token);
    }
}
