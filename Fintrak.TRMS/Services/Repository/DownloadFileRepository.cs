using Newtonsoft.Json;
using Fintrak.TRMS.Base;
using Fintrak.TRMS.FormNXPResponseDto;
using Fintrak.TRMS.Models;
using Fintrak.TRMS.Services.Interface;
using System.Threading.Tasks;
using System;

namespace Fintrak.TRMS.Services.Repository
{
    public class DownloadFileRepository : BaseRepository<GetModel, DownloadFileResponse>, IDownloadFileRepository
    {
        private readonly APIService _apiService;

        public DownloadFileRepository(APIService apiService) : base(apiService)
        {
            _apiService = apiService;
        }

        public async Task<DownloadFileResponse> DownloadFile(string token, string fileId)
        {
            BaseURL url = new BaseURL();
            string apiUrl = url.Url + "api/v1/file/download/" + fileId;

            try
            {
                var responseJson = await _apiService.GetModelFromApiAsync(apiUrl, token);
                DownloadFileResponse responseModel = JsonConvert.DeserializeObject<DownloadFileResponse>(responseJson);
                return responseModel;
            }
            catch (ApiException ex)
            {
                throw new Exception(ex.Code.ToString(), ex.MessageError);
            }
        }
    }
}
