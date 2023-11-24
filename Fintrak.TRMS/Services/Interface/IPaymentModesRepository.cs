using Fintrak.TRMS.Base;
using Fintrak.TRMS.Models;
using System.Threading.Tasks;

namespace Fintrak.TRMS.Services.Interface
{
    public interface IPaymentModesRepository : IBaseRepository<GetModel, PaymentModesResponse>
    {
        Task<PaymentModesResponse> GetPaymentModes(string? searchParam, string token);
    }
}
