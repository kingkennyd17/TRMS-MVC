using Fintrak.TRMS.Base;
using Fintrak.TRMS.FormNXPResponseDto;
using Fintrak.TRMS.Models;
using System.Threading.Tasks;

namespace Fintrak.TRMS.Services.Interface
{
    public interface INXPFormDetailsRepository : IBaseRepository<GetModel, FormNXPDetailsResponse>
    {
        Task<FormNXPDetailsResponse> GetNXPFormDetails(string applicationId, string token);
    }
}
