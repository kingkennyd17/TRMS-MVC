using Newtonsoft.Json;
using Fintrak.TRMS.Base;
using Fintrak.TRMS.Models;
using Fintrak.TRMS.Services.Interface;
using System.Threading.Tasks;
using System;

namespace Fintrak.TRMS.Services
{
    public class PaymentModesRepository : BaseRepository<GetModel, PaymentModesResponse>, IPaymentModesRepository
    {
        private readonly APIService _apiService;

        public PaymentModesRepository(APIService apiService) : base(apiService)
        {
            _apiService = apiService;
        }

        public async Task<PaymentModesResponse> GetPaymentModes(string? searchParam, string token)
        {
            BaseURL url = new BaseURL();
            string apiUrl = url.Url + "api/v1/base/payment-mode/list?sort=&page=0&size=50&orderBy=id&gssearch=" + searchParam;

            try
            {
                string responseJson = await _apiService.GetModelFromApiAsync(apiUrl, token);
                PaymentModesResponse responseModel = JsonConvert.DeserializeObject<PaymentModesResponse>(responseJson);
                return responseModel;
            }
            catch (ApiException ex)
            {
                throw new Exception(ex.Code.ToString(), ex.MessageError);
            }
        }
    }
}
