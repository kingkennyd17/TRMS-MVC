using Fintrak.TRMS.Base;
using Fintrak.TRMS.Models;
using System.Threading.Tasks;

namespace Fintrak.TRMS.Services.Interface
{
    public interface IFormADetailsRepository : IBaseRepository<GetModel, FormADetails>
    {
        Task<FormADetails> GetFormADetails(string applicationId, string token);
    }
}
