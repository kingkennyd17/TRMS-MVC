using Newtonsoft.Json;
using Fintrak.TRMS.Base;
using Fintrak.TRMS.Models;
using Fintrak.TRMS.Services.Interface;
using System.Threading.Tasks;
using System;

namespace Fintrak.TRMS.Services
{
    public class RejectionRepository : BaseRepository<GetModel, RejectionResponse>, IRejectionRepository
    {
        private readonly APIService _apiService;

        public RejectionRepository(APIService apiService) : base(apiService)
        {
            _apiService = apiService;
        }

        public async Task<RejectionResponse> RejectionReason(string token, string formtype)
        {
            BaseURL url = new BaseURL();
            string apiUrl = url.Url + "api/v1/base/rejection-reason/list?formType=" + formtype + "&size=500&orderBy=id&sort=DESC&page=0";

            try
            {
                string responseJson = await _apiService.GetModelFromApiAsync(apiUrl, token);
                RejectionResponse responseModel = JsonConvert.DeserializeObject<RejectionResponse>(responseJson);
                return responseModel;
            }
            catch (ApiException ex)
            {
                throw new Exception(ex.Code.ToString(), ex.MessageError);
            }
        }
    }
}
