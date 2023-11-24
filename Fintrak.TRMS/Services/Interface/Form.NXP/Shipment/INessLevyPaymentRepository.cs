using Fintrak.TRMS.Base;
using Fintrak.TRMS.FormNXPRequestDto;
using Fintrak.TRMS.FormNXPResponseDto;
using System.Threading.Tasks;

namespace Fintrak.TRMS.Services.Interface
{
    public interface INessLevyPaymentRepository : IBaseRepository<NessLevyPaymentRequestDto, NessLevyPaymentResponseDto>
    {
        Task<NessLevyPaymentResponseDto> PostNessLevyPayment(NessLevyPaymentRequestDto model, string shipmentNumber, string token);

    }
}
