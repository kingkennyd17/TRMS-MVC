using Newtonsoft.Json;
using Fintrak.TRMS.Base;
using Fintrak.TRMS.FormNXPResponseDto;
using Fintrak.TRMS.Models;
using Fintrak.TRMS.Services.Interface;
using System.Threading.Tasks;
using System;

namespace Fintrak.TRMS.Services.Repository
{
    public class NXPFormDetailsRepository : BaseRepository<GetModel, FormNXPDetailsResponse>, INXPFormDetailsRepository
    {
        private readonly APIService _apiService;

        public NXPFormDetailsRepository(APIService apiService) : base(apiService)
        {
            _apiService = apiService;
        }

        public async Task<FormNXPDetailsResponse> GetNXPFormDetails(string applicationId, string token)
        {
            BaseURL url = new BaseURL();
            string apiUrl = url.Url + "api/v1/form-nxp/" + applicationId;

            try
            {
                string responseJson = await _apiService.GetModelFromApiAsync(apiUrl, token);
                FormNXPDetailsResponse responseModel = JsonConvert.DeserializeObject<FormNXPDetailsResponse>(responseJson);
                return responseModel;
            }
            catch (ApiException ex)
            {
                throw new Exception(ex.Code.ToString(), ex.MessageError);
            }
        }
    }
}
