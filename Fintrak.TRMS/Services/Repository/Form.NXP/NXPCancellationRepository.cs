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
    public class NXPCancellationRepository : BaseRepository<NXPCancellationRequestDto, NXPCancellationResponseDto>, INXPCancellationRepository
    {
        private readonly APIService _apiService;

        public NXPCancellationRepository(APIService apiService) : base(apiService)
        {
            _apiService = apiService;
        }

        public async Task<NXPCancellationResponseDto> PostNXPCancellation(NXPCancellationRequestDto model, string applicantId, string token)
        {
            BaseURL url = new BaseURL();
            string apiUrl = url.Url + "api/v1/form-nxp/cancel/adb-review/" + applicantId;
            string userJsonContent = JsonConvert.SerializeObject(model);

            try
            {
                string responseJson = await _apiService.PostModelToApiAsync(apiUrl, userJsonContent, token);
                NXPCancellationResponseDto responseModel = JsonConvert.DeserializeObject<NXPCancellationResponseDto>(responseJson);
                return responseModel;
            }
            catch (ApiException ex)
            {
                throw new Exception(ex.Code.ToString(), ex.MessageError);
            }
        }
    }
}
