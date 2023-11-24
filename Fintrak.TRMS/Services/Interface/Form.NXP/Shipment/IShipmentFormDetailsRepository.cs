using Fintrak.TRMS.Base;
using Fintrak.TRMS.Models;
using System.Threading.Tasks;

namespace Fintrak.TRMS.Services.Interface
{
    public interface IShipmentFormDetailsRepository : IBaseRepository<GetModel, ShipmentFormDetails>
    {
        Task<ShipmentFormDetails> GetShipmentFormDetails(string shipmentNumber, string token);
    }
}
