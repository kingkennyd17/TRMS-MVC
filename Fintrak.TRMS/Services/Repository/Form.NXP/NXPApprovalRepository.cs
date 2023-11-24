using Newtonsoft.Json;
using Fintrak.TRMS.Base;
using Fintrak.TRMS.FormNXPRequestDto;
using Fintrak.TRMS.FormNXPResponseDto;
using Fintrak.TRMS.Models;
using Fintrak.TRMS.Services.Interface;
using System.Threading.Tasks;
using System;

namespace Fintrak.TRMS.Services.Repository
{
    public class NXPApprovalRepository : BaseRepository<NXPApprovalRequestDto, NXPApprovalResponseDto>, INXPApprovalRepository
    {
        private readonly APIService _apiService;

        public NXPApprovalRepository(APIService apiService) : base(apiService)
        {
            _apiService = apiService;
        }

        public async Task<NXPApprovalResponseDto> PostNXPApproval(NXPApprovalRequestDto model, string applicantId, string token)
        {
            BaseURL url = new BaseURL();
            string apiUrl = url.Url + "api/v1/form-nxp/adb-review/" + applicantId;
            string userJsonContent = JsonConvert.SerializeObject(model);

            try
            {
                string responseJson = await _apiService.PostModelToApiAsync(apiUrl, userJsonContent, token);
                NXPApprovalResponseDto responseModel = JsonConvert.DeserializeObject<NXPApprovalResponseDto>(responseJson);
                return responseModel;
            }
            catch (ApiException ex)
            {
                throw new Exception(ex.Code.ToString(), ex.MessageError);
            }
        }
    }
}
