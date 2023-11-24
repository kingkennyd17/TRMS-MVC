using Newtonsoft.Json;
using Fintrak.TRMS.Base;
using Fintrak.TRMS.Models;
using Fintrak.TRMS.Services.Interface;
using System.Threading.Tasks;
using System;

namespace Fintrak.TRMS.Services.Repository
{
    public class ShipmentFormDetailsRepository : BaseRepository<GetModel, ShipmentFormDetails>, IShipmentFormDetailsRepository
    {
        private readonly APIService _apiService;

        public ShipmentFormDetailsRepository(APIService apiService) : base(apiService)
        {
            _apiService = apiService;
        }

        public async Task<ShipmentFormDetails> GetShipmentFormDetails(string shipmentNumber, string token)
        {
            BaseURL url = new BaseURL();
            string apiUrl = url.Url + "api/v1/form-nxp/shipment/" + shipmentNumber;

            try
            {
                string responseJson = await _apiService.GetModelFromApiAsync(apiUrl, token);
                ShipmentFormDetails responseModel = JsonConvert.DeserializeObject<ShipmentFormDetails>(responseJson);
                return responseModel;
            }
            catch (ApiException ex)
            {
                throw new Exception(ex.Code.ToString(), ex.MessageError);
            }
        }
    }
}
