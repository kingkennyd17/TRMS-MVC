using Newtonsoft.Json;
using Fintrak.TRMS.Base;
using Fintrak.TRMS.Models;
using Fintrak.TRMS.Services.Interface;
using System.Threading.Tasks;
using System;

namespace Fintrak.TRMS.Services
{
    public class PendingApplicationNCXRepository : BaseRepository<GetModel, PendingApplicationNCX>, IPendingApplicationNCXRepository
    {
        private readonly APIService _apiService;

        public PendingApplicationNCXRepository(APIService apiService) : base(apiService)
        {
            _apiService = apiService;
        }

        public async Task<PendingApplicationNCX> PendingApplicationNCX(string? searchParam, string token)
        {
            BaseURL url = new BaseURL();
            string apiUrl = url.Url + "api/v1/form-ncx/pending-applications?orderBy=updatedAt&sort=desc&size=50&page=0&gSearch=" + searchParam + "&option=";

            try
            {
                string responseJson = await _apiService.GetModelFromApiAsync(apiUrl, token);
                PendingApplicationNCX responseModel = JsonConvert.DeserializeObject<PendingApplicationNCX>(responseJson);
                return responseModel;
            }
            catch (ApiException ex)
            {
                throw new Exception(ex.Code.ToString(), ex.MessageError);
            }
        }
    }
}
