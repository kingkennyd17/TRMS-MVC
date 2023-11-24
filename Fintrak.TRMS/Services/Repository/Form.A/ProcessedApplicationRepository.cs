using Newtonsoft.Json;
using Fintrak.TRMS.Base;
using Fintrak.TRMS.Models;
using Fintrak.TRMS.Services.Interface;
using System.Threading.Tasks;
using System;

namespace Fintrak.TRMS.Services
{
    public class ProcessedApplicationRepository : BaseRepository<GetModel, ProcessedApplication>, IProcessedApplicationRepository
    {
        private readonly APIService _apiService;

        public ProcessedApplicationRepository(APIService apiService) : base(apiService)
        {
            _apiService = apiService;
        }

        public async Task<ProcessedApplication> ProcessedApplication(string? searchParam, string token)
        {
            BaseURL url = new BaseURL();
            string apiUrl = url.Url + "api/v1/form-a/list?orderBy=updatedAt&sort=desc&size=50&page=0&gSearch=" + searchParam + "&option=";

            try
            {
                string responseJson = await _apiService.GetModelFromApiAsync(apiUrl, token);
                ProcessedApplication responseModel = JsonConvert.DeserializeObject<ProcessedApplication>(responseJson);
                return responseModel;
            }
            catch (ApiException ex)
            {
                throw new Exception(ex.Code.ToString(), ex.MessageError);
            }
        }
    }
}
