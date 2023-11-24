using Fintrak.TRMS.Base;
using Fintrak.TRMS.Models;
using Fintrak.TRMS.Services.Interface;
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Http;

namespace Fintrak.TRMS.Services.Repository
{
    public class UploadRepository : BaseRepository<IFormFile, FileUploadResponse>, IUploadRepository
    {
        private readonly APIService _apiService;

        public UploadRepository(APIService apiService) : base(apiService)
        {
            _apiService = apiService;
        }

        public async Task<FileUploadResponse> UploadFile(IFormFile file, string token)
        {
            BaseURL url = new BaseURL();
            string apiUrl = url.Url + "api/v1/file/upload";

            try
            {
                var reponse = await _apiService.UploadFileAsync(file, apiUrl, token);
                return reponse;
            }
            catch (ApiException ex)
            {
                throw new Exception(ex.Code.ToString(), ex.MessageError);
            }
        }
    }
}
