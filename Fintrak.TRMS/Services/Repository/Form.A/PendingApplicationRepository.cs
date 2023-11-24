using Newtonsoft.Json;
using Fintrak.TRMS.Base;
using Fintrak.TRMS.Models;
using Fintrak.TRMS.Services.Interface;
using System.Threading.Tasks;
using System;

namespace Fintrak.TRMS.Services
{
    public class PendingApplicationRepository : BaseRepository<GetModel, PendingApplication>, IPendingApplicationRepository
    {
        private readonly APIService _apiService;

        public PendingApplicationRepository(APIService apiService) : base(apiService)
        {
            _apiService = apiService;
        }

        public async Task<PendingApplication> PendingApplication(string? searchParam, string token)
        {
            BaseURL url = new BaseURL();
            string apiUrl = url.Url + "api/v1/form-a/pending-applications?orderBy=updatedAt&sort=desc&size=50&page=0&gSearch=" + searchParam + "&option=";

            try
            {
                string responseJson = await _apiService.GetModelFromApiAsync(apiUrl, token);
                PendingApplication responseModel = JsonConvert.DeserializeObject<PendingApplication>(responseJson);
                return responseModel;
            }
            catch (ApiException ex)
            {
                throw new Exception(ex.Code.ToString(), ex.MessageError);
            }
        }
    }
}
