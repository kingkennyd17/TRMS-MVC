using Fintrak.TRMS.Base;
using Fintrak.TRMS.Models;
using Fintrak.TRMS.Services.Interface;
using System.Threading.Tasks;
using System;

namespace Fintrak.TRMS.Services.Repository
{
    public class ViewFileRepository : BaseRepository<GetModel, byte[]>, IViewFileRepository
    {
        private readonly APIService _apiService;

        public ViewFileRepository(APIService apiService) : base(apiService)
        {
            _apiService = apiService;
        }

        public async Task<byte[]> ViewFile(string token, string fileId)
        {
            BaseURL url = new BaseURL();
            string apiUrl = url.Url + "api/v1/file/viewFile/" + fileId;

            try
            {
                var reponse = await _apiService.DownloadFileAsync(apiUrl, token);
                return reponse;
            }
            catch (ApiException ex)
            {
                throw new Exception(ex.Code.ToString(), ex.MessageError);
            }
        }
    }
}
