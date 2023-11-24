using Newtonsoft.Json;
using Fintrak.TRMS;
using System.Threading.Tasks;
using System;

namespace Fintrak.TRMS.Base
{
    public class BaseRepository<T, R> : IBaseRepository<T, R>
    {
        private readonly APIService _apiService;

        public BaseRepository(APIService apiService)
        {
            _apiService = apiService;
        }

        public async Task<R> CreateAsync(T model, string apiUrl, string token)
        {
            try
            {
                string modelJson = JsonConvert.SerializeObject(model);
                string responseJson = await _apiService.PostModelToApiAsync(apiUrl, modelJson, token);
                R responseModel = JsonConvert.DeserializeObject<R>(responseJson);
                return responseModel;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<R> GetAsync(string apiUrl, string token)
        {
            try
            {
                string responseJson = await _apiService.GetModelFromApiAsync(apiUrl, token);
                R model = JsonConvert.DeserializeObject<R>(responseJson);
                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<R> UpdateAsync(T model, string apiUrl, string token)
        {
            try
            {
                string modelJson = JsonConvert.SerializeObject(model);
                string responseJson = await _apiService.PostModelToApiAsync(apiUrl, modelJson, token);
                R responseModel = JsonConvert.DeserializeObject<R>(responseJson);
                return responseModel;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> DeleteAsync(T model, string apiUrl, string token)
        {
            try
            {
                string modelJson = JsonConvert.SerializeObject(model);
                await _apiService.PostModelToApiAsync(apiUrl, modelJson, token);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
