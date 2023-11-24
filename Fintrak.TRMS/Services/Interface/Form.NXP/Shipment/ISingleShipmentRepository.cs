using Fintrak.TRMS.Base;
using Fintrak.TRMS.FormNXPResponseDto;
using Fintrak.TRMS.Models;
using System.Threading.Tasks;

namespace Fintrak.TRMS.Services.Interface
{
    public interface ISingleShipmentRepository : IBaseRepository<GetModel, SingleShipmentResponseDto>
    {
        Task<SingleShipmentResponseDto> GetSingleShipment(string shipmentNumber, string token);
    }
}
