using Newtonsoft.Json;
using Fintrak.TRMS.Base;
using Fintrak.TRMS.Models;
using Fintrak.TRMS.Services.Interface;
using System.Threading.Tasks;
using System;

namespace Fintrak.TRMS.Services
{
    public class FormADetailsRepository : BaseRepository<GetModel, FormADetails>, IFormADetailsRepository
    {
        private readonly APIService _apiService;

        public FormADetailsRepository(APIService apiService) : base(apiService)
        {
            _apiService = apiService;
        }

        public async Task<FormADetails> GetFormADetails(string applicationId, string token)
        {
            BaseURL url = new BaseURL();
            string apiUrl = url.Url + "api/v1/form-a/" + applicationId;

            try
            {
                string responseJson = await _apiService.GetModelFromApiAsync(apiUrl, token);
                FormADetails responseModel = JsonConvert.DeserializeObject<FormADetails>(responseJson);
                return responseModel;
            }
            catch (ApiException ex)
            {
                throw new Exception(ex.Code.ToString(), ex.MessageError);
            }
        }
    }
}
