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
    public class RepatriationApprovalRepository : BaseRepository<RepatriationApprovalRequestDto, RepatriationApprovalResponseDto>, IRepatriationApprovalRepository
    {
        private readonly APIService _apiService;

        public RepatriationApprovalRepository(APIService apiService) : base(apiService)
        {
            _apiService = apiService;
        }

        public async Task<RepatriationApprovalResponseDto> PostRepatriationApproval(RepatriationApprovalRequestDto model, string shipmentNumber, string token)
        {
            BaseURL url = new BaseURL();
            string apiUrl = url.Url + "api/v1/form-nxp/shipment/adb-repatriation-review/" + shipmentNumber;
            string userJsonContent = JsonConvert.SerializeObject(model);

            try
            {
                string responseJson = await _apiService.PostModelToApiAsync(apiUrl, userJsonContent, token);
                RepatriationApprovalResponseDto responseModel = JsonConvert.DeserializeObject<RepatriationApprovalResponseDto>(responseJson);
                return responseModel;
            }
            catch (ApiException ex)
            {
                throw new Exception(ex.Code.ToString(), ex.MessageError);
            }
        }
    }
}
