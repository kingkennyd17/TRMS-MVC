using Newtonsoft.Json;
using Fintrak.TRMS.Base;
using Fintrak.TRMS.FormNXPResponseDto;
using Fintrak.TRMS.Models;
using Fintrak.TRMS.Services.Interface;
using System.Threading.Tasks;
using System;

namespace Fintrak.TRMS.Services.Repository
{
    public class PendingNXPShipmentRepository : BaseRepository<GetModel, PendingNXPShipmentResponseDto>, IPendingNXPShipmentRepository
    {
        private readonly APIService _apiService;

        public PendingNXPShipmentRepository(APIService apiService) : base(apiService)
        {
            _apiService = apiService;
        }

        public async Task<PendingNXPShipmentResponseDto> GetPendingNXPShipment(string? gsearch, string token)
        {
            BaseURL url = new BaseURL();
            string apiUrl = url.Url + "api/v1/form-nxp/shipment/pending-applications?orderBy=updatedAt&sort=desc&size=50&page=0&gSearch=" + gsearch + "&option=";

            try
            {
                string responseJson = await _apiService.GetModelFromApiAsync(apiUrl, token);
                PendingNXPShipmentResponseDto responseModel = JsonConvert.DeserializeObject<PendingNXPShipmentResponseDto>(responseJson);
                return responseModel;
            }
            catch (ApiException ex)
            {
                throw new Exception(ex.Code.ToString(), ex.MessageError);
            }
        }
    }
}
