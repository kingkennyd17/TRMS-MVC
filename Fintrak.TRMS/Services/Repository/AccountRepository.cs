using Newtonsoft.Json;
using System;
using Fintrak.TRMS.Base;
using Fintrak.TRMS.Models;
using Fintrak.TRMS.Services.Interface;
using System.Threading.Tasks;

namespace Fintrak.TRMS.Services
{
    public class AccountRepository : BaseRepository<Login, Token>, IAccountRepository
    {
        private readonly APIService _apiService;

        public AccountRepository(APIService apiService) : base(apiService)
        {
            _apiService = apiService;
        }

        public async Task<Token> Login (Login user)
        {
            BaseURL url = new BaseURL();
            string apiUrl = url.Url + "oauth/token";

            try
            {
                string responseJson = await _apiService.LoginApiAsync(apiUrl, user);
                Token responseModel = JsonConvert.DeserializeObject<Token>(responseJson);
                return responseModel;
            }
            catch (ApiException ex)
            {
                throw new Exception(ex.Code.ToString(), ex.MessageError);
            }
        }
    }
}
