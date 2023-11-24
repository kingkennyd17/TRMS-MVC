using Newtonsoft.Json;
using Fintrak.TRMS.Base;
using Fintrak.TRMS.FormNXPRequestDto;
using Fintrak.TRMS.FormNXPResponseDto;
using Fintrak.TRMS.Models;
using Fintrak.TRMS.Services.Interface;
using System.Threading.Tasks;
using System;

namespace Fintrak.TRMS.Services.Repository
{
    public class NessLevyPaymentRepository : BaseRepository<NessLevyPaymentRequestDto, NessLevyPaymentResponseDto>, INessLevyPaymentRepository
    {
        private readonly APIService _apiService;

        public NessLevyPaymentRepository(APIService apiService) : base(apiService)
        {
            _apiService = apiService;
        }

        public async Task<NessLevyPaymentResponseDto> PostNessLevyPayment(NessLevyPaymentRequestDto model, string shipmentNumber, string token)
        {
            BaseURL url = new BaseURL();
            string apiUrl = url.Url + "api/v1/form-nxp/shipment/designated-bank-ness-levy-review/" + shipmentNumber;
            string userJsonContent = JsonConvert.SerializeObject(model);

            try
            {
                string responseJson = await _apiService.PostModelToApiAsync(apiUrl, userJsonContent, token);
                NessLevyPaymentResponseDto responseModel = JsonConvert.DeserializeObject<NessLevyPaymentResponseDto>(responseJson);
                return responseModel;
            }
            catch (ApiException ex)
            {
                throw new Exception(ex.Code.ToString(), ex.MessageError);
            }
        }
    }
}
