using Newtonsoft.Json;
using Fintrak.TRMS.Base;
using Fintrak.TRMS.Models;
using Fintrak.TRMS.Services.Interface;
using System.Threading.Tasks;
using System;

namespace Fintrak.TRMS.Services
{
    public class ADBReviewerRepository : BaseRepository<ADBReviewerRequest, ADBReviewerResponse>, IADBReviewerRepository
    {
        private readonly APIService _apiService;

        public ADBReviewerRepository(APIService apiService) : base(apiService)
        {
            _apiService = apiService;
        }

        public async Task<ADBReviewerResponse> ADBReviewer(ADBReviewerRequest adbReviewerRequest, string applicationId, string token)
        {
            BaseURL url = new BaseURL();
            string apiUrl = url.Url + "api/v1/form-a/cancel/adb-review-reviewer/" + applicationId;
            string userJsonContent = JsonConvert.SerializeObject(adbReviewerRequest);

            try
            {
                string responseJson = await _apiService.PostModelToApiAsync(apiUrl, userJsonContent, token);
                ADBReviewerResponse responseModel = JsonConvert.DeserializeObject<ADBReviewerResponse>(responseJson);
                return responseModel;
            }
            catch (ApiException ex)
            {
                throw new Exception(ex.Code.ToString(), ex.MessageError);
            }
        }
    }
}
