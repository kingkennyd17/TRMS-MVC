using Fintrak.TRMS.Base;
using Fintrak.TRMS.Models;
using System.Threading.Tasks;

namespace Fintrak.TRMS.Services.Interface
{
    public interface INessLevyDetailsRepository : IBaseRepository<GetModel, NessLevyDetails>
    {
        Task<NessLevyDetails> GetNessLevyDetails(string shipmentNumber, string token);
    }
}
