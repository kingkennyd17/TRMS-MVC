using Fintrak.TRMS.Base;
using Fintrak.TRMS.Models;
using System.Threading.Tasks;

namespace Fintrak.TRMS.Services.Interface
{
    public interface IFormNCXDetailsRepository : IBaseRepository<GetModel, FormNCXDetails>
    {
        Task<FormNCXDetails> GetFormNCXDetails(string applicationId, string token);
    }
}
