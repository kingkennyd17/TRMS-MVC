using Newtonsoft.Json;
using Fintrak.TRMS.Base;
using Fintrak.TRMS.FormNXPResponseDto;
using Fintrak.TRMS.Models;
using Fintrak.TRMS.Services.Interface;
using System.Threading.Tasks;
using System;

namespace Fintrak.TRMS.Services.Repository
{
    public class SingleShipmentRepository : BaseRepository<GetModel, SingleShipmentResponseDto>, ISingleShipmentRepository
    {
        private readonly APIService _apiService;

        public SingleShipmentRepository(APIService apiService) : base(apiService)
        {
            _apiService = apiService;
        }

        public async Task<SingleShipmentResponseDto> GetSingleShipment(string shipmentNumber, string token)
        {
            BaseURL url = new BaseURL();
            string apiUrl = url.Url + "api/v1/form-nxp/shipment/with-fields/" + shipmentNumber;

            try
            {
                string responseJson = await _apiService.GetModelFromApiAsync(apiUrl, token);
                SingleShipmentResponseDto responseModel = JsonConvert.DeserializeObject<SingleShipmentResponseDto>(responseJson);
                return responseModel;
            }
            catch (ApiException ex)
            {
                throw new Exception(ex.Code.ToString(), ex.MessageError);
            }
        }
    }
}
