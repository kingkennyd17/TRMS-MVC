using Newtonsoft.Json;
using Fintrak.TRMS.Base;
using Fintrak.TRMS.FormNXPResponseDto;
using Fintrak.TRMS.Models;
using Fintrak.TRMS.Services.Interface;
using System.Threading.Tasks;
using System;

namespace Fintrak.TRMS.Services.Repository
{
    public class NessLevyByShipmentRepository : BaseRepository<GetModel, NessLevyByShipmentResponseDto>, INessLevyByShipmentRepository
    {
        private readonly APIService _apiService;

        public NessLevyByShipmentRepository(APIService apiService) : base(apiService)
        {
            _apiService = apiService;
        }

        public async Task<NessLevyByShipmentResponseDto> GetNessLevyByShipment(string shipmentNumber, string token)
        {
            BaseURL url = new BaseURL();
            string apiUrl = url.Url + "api/v1/form-nxp/shipment/ness-levy/" + shipmentNumber;

            try
            {
                string responseJson = await _apiService.GetModelFromApiAsync(apiUrl, token);
                NessLevyByShipmentResponseDto responseModel = JsonConvert.DeserializeObject<NessLevyByShipmentResponseDto>(responseJson);
                return responseModel;
            }
            catch (ApiException ex)
            {
                throw new Exception(ex.Code.ToString(), ex.MessageError);
            }
        }
    }
}
