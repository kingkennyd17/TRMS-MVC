using Newtonsoft.Json;
using Fintrak.TRMS.Base;
using Fintrak.TRMS.FormNXPResponseDto;
using Fintrak.TRMS.Models;
using Fintrak.TRMS.Services.Interface;
using System.Threading.Tasks;
using System;

namespace Fintrak.TRMS.Services.Repository
{
    public class NessLevyDetailsRepository : BaseRepository<GetModel, NessLevyDetails>, INessLevyDetailsRepository
    {
        private readonly APIService _apiService;

        public NessLevyDetailsRepository(APIService apiService) : base(apiService)
        {
            _apiService = apiService;
        }

        public async Task<NessLevyDetails> GetNessLevyDetails(string shipmentNumber, string token)
        {
            BaseURL url = new BaseURL();
            string apiUrl = url.Url + "api/v1/form-nxp/shipment/get-ness-levy-payable-details/" + shipmentNumber;

            try
            {
                string responseJson = await _apiService.GetModelFromApiAsync(apiUrl, token);
                NessLevyDetails responseModel = JsonConvert.DeserializeObject<NessLevyDetails>(responseJson);
                return responseModel;
            }
            catch (ApiException ex)
            {
                throw new Exception(ex.Code.ToString(), ex.MessageError);
            }
        }
    }
}
