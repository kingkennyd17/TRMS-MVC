using Newtonsoft.Json;
using Fintrak.TRMS.Base;
using Fintrak.TRMS.Models;
using Fintrak.TRMS.Services.Interface;
using System.Threading.Tasks;
using System;

namespace Fintrak.TRMS.Services
{
    public class ApprovalRejectionRepository : BaseRepository<ApprovalRejectionRequest, ApprovalRejectionResponse>, IApprovalRejectionRepository
    {
        private readonly APIService _apiService;

        public ApprovalRejectionRepository(APIService apiService) : base(apiService)
        {
            _apiService = apiService;
        }

        public async Task<ApprovalRejectionResponse> ApprovalRejection(ApprovalRejectionRequest approvalRejectionRequest, string applicationId, string token)
        {
            BaseURL url = new BaseURL();
            string apiUrl = url.Url + "api/v1/form-a/approval-reviewer/" + applicationId;
            string userJsonContent = JsonConvert.SerializeObject(approvalRejectionRequest);

            try
            {
                string responseJson = await _apiService.PostModelToApiAsync(apiUrl, userJsonContent, token);
                ApprovalRejectionResponse responseModel = JsonConvert.DeserializeObject<ApprovalRejectionResponse>(responseJson);
                return responseModel;
            }
            catch (ApiException ex)
            {
                throw new Exception(ex.Code.ToString(), ex.MessageError);
            }
        }
    }
}
