using Newtonsoft.Json;
using Fintrak.TRMS.Base;
using Fintrak.TRMS.Models;
using Fintrak.TRMS.Services.Interface;
using System.Threading.Tasks;
using System;

namespace Fintrak.TRMS.Services
{
    public class FormNCXDetailsRepository : BaseRepository<GetModel, FormNCXDetails>, IFormNCXDetailsRepository
    {
        private readonly APIService _apiService;

        public FormNCXDetailsRepository(APIService apiService) : base(apiService)
        {
            _apiService = apiService;
        }

        public async Task<FormNCXDetails> GetFormNCXDetails(string applicationId, string token)
        {
            BaseURL url = new BaseURL();
            string apiUrl = url.Url + "api/v1/form-ncx/" + applicationId;

            try
            {
                string responseJson = await _apiService.GetModelFromApiAsync(apiUrl, token);
                FormNCXDetails responseModel = JsonConvert.DeserializeObject<FormNCXDetails>(responseJson);
                return responseModel;
            }
            catch (ApiException ex)
            {
                throw new Exception(ex.Code.ToString(), ex.MessageError);
            }
        }
    }
}
