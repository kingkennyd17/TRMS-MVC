using Newtonsoft.Json;
using Fintrak.TRMS.Base;
using Fintrak.TRMS.Models;
using Fintrak.TRMS.Services.Interface;
using System.Threading.Tasks;
using System;

namespace Fintrak.TRMS.Services
{
    public class DisbursementReviewerRepository : BaseRepository<DisbursementReviewerRequest, DisbursementReviewerResponse>, IDisbursementReviewerRepository
    {
        private readonly APIService _apiService;

        public DisbursementReviewerRepository(APIService apiService) : base(apiService)
        {
            _apiService = apiService;
        }

        public async Task<DisbursementReviewerResponse> DisbursementReviewer(DisbursementReviewerRequest disbursementReviewerRequest, string applicationId, string token)
        {
            BaseURL url = new BaseURL();
            string apiUrl = url.Url + "api/v1/form-a/disbursement-reviewer/" + applicationId;
            string userJsonContent = JsonConvert.SerializeObject(disbursementReviewerRequest);

            try
            {
                string responseJson = await _apiService.PostModelToApiAsync(apiUrl, userJsonContent, token);
                DisbursementReviewerResponse responseModel = JsonConvert.DeserializeObject<DisbursementReviewerResponse>(responseJson);
                return responseModel;
            }
            catch (ApiException ex)
            {
                throw new Exception(ex.Code.ToString(), ex.MessageError);
            }
        }

        public async Task<DisbursementReviewerResponse> RejectDisbursement(RejectDisbursementRequest rejectdisbursementRequest, string applicationId, string token)
        {
            BaseURL url = new BaseURL();
            string apiUrl = url.Url + "api/v1/form-a/disbursement-reviewer/" + applicationId;
            string userJsonContent = JsonConvert.SerializeObject(rejectdisbursementRequest);

            try
            {
                string responseJson = await _apiService.PostModelToApiAsync(apiUrl, userJsonContent, token);
                DisbursementReviewerResponse responseModel = JsonConvert.DeserializeObject<DisbursementReviewerResponse>(responseJson);
                return responseModel;
            }
            catch (ApiException ex)
            {
                throw new Exception(ex.Code.ToString(), ex.MessageError);
            }
        }
    }
}
