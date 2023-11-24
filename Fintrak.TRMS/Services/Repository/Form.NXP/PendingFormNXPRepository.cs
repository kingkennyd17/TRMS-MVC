using Newtonsoft.Json;
using Fintrak.TRMS.Base;
using Fintrak.TRMS.FormNXPResponseDto;
using Fintrak.TRMS.Models;
using Fintrak.TRMS.Services.Interface;
using System.Threading.Tasks;
using System;

namespace Fintrak.TRMS.Services.Repository
{
    public class PendingFormNXPRepository : BaseRepository<GetModel, PendingNXPResponseDto>, IPendingFormNXPRepository
    {
        private readonly APIService _apiService;

        public PendingFormNXPRepository(APIService apiService) : base(apiService)
        {
            _apiService = apiService;
        }

        public async Task<PendingNXPResponseDto> GetPendingFormNXP(string? gsearch, string token)
        {
            BaseURL url = new BaseURL();
            string apiUrl = url.Url + "api/v1/form-nxp/pending-applications?orderBy=updatedAt&sort=desc&size=50&page=0&gSearch=" + gsearch + "&option=";

            try
            {
                string responseJson = await _apiService.GetModelFromApiAsync(apiUrl, token);
                PendingNXPResponseDto responseModel = JsonConvert.DeserializeObject<PendingNXPResponseDto>(responseJson);
                return responseModel;
            }
            catch (ApiException ex)
            {
                throw new Exception(ex.Code.ToString(), ex.MessageError);
            }
        }
    }
}
