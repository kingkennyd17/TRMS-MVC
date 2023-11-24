using Fintrak.TRMS.Base;
using Fintrak.TRMS.Models;
using System.Threading.Tasks;

namespace Fintrak.TRMS.Services.Interface
{
    public interface IRejectionRepository : IBaseRepository<GetModel, RejectionResponse>
    {
        Task<RejectionResponse> RejectionReason(string token, string formtype);
    }
}
