using Fintrak.TRMS.Base;
using Fintrak.TRMS.FormNXPResponseDto;
using Fintrak.TRMS.Models;
using System.Threading.Tasks;

namespace Fintrak.TRMS.Services.Interface
{
    public interface IPendingNXPShipmentRepository : IBaseRepository<GetModel, PendingNXPShipmentResponseDto>
    {
        Task<PendingNXPShipmentResponseDto> GetPendingNXPShipment(string? gsearch, string token);
    }
}
