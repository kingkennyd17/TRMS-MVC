using Fintrak.TRMS.Base;
using Fintrak.TRMS.FormNXPResponseDto;
using Fintrak.TRMS.Models;
using System.Threading.Tasks;

namespace Fintrak.TRMS.Services.Interface
{
    public interface INessLevyByShipmentRepository : IBaseRepository<GetModel, NessLevyByShipmentResponseDto>
    {
        Task<NessLevyByShipmentResponseDto> GetNessLevyByShipment(string shipmentNumber, string token);
    }
}
