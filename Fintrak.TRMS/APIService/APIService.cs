using Microsoft.AspNetCore.Http;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using Fintrak.TRMS.Base;
using Fintrak.TRMS.Models;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.IO;

namespace Fintrak.TRMS
{
    public class APIService
    {
        private readonly HttpClient _httpClient;

        public APIService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetModelFromApiAsync(string apiUrl, string token)
        {
            try
            {

                // Add the Authorization header
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);


                _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

                // Make an HTTP GET request to the API
                HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    // Read the response content as a JSON string
                    string jsonContent = await response.Content.ReadAsStringAsync();

                    // Deserialize the JSON to your model
                    //object model = JsonConvert.DeserializeObject<YourModel>(jsonContent);

                    return jsonContent;
                }
                else
                {
                    // Handle API errors here
                    throw new ApiException((int)response.StatusCode, new Exception(response.Content.ReadAsStringAsync().Result), response.StatusCode.ToString());
                }
            }
            catch (ApiException ex)
            {
                // Handle exceptions here
                throw ex;
            }
            finally
            {
                _httpClient.DefaultRequestHeaders.Authorization = null;
            }
        }

        public async Task<string> PostModelToApiAsync(string apiUrl, string jsonContent, string token)
        {
            try
            {
                // Serialize the model to JSON
                //string jsonContent = JsonConvert.SerializeObject(model);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                // Add the Authorization header
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);


                _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

                // Make an HTTP POST request to the API
                HttpResponseMessage response = await _httpClient.PostAsync(apiUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    string responseJson = await response.Content.ReadAsStringAsync();
                    //object responseModel = JsonConvert.DeserializeObject<object>(responseJson);
                    return responseJson;
                }
                else
                {
                    // Handle API errors here
                    throw new ApiException((int)response.StatusCode, new Exception(response.Content.ReadAsStringAsync().Result), response.StatusCode.ToString());
                }
            }
            catch (ApiException ex)
            {
                // Handle exceptions here
                throw ex;
            }
            finally
            {
                _httpClient.DefaultRequestHeaders.Authorization = null;
            }
        }

        public async Task<string> LoginApiAsync(string apiUrl, Login user)
        {
            BaseURL url = new BaseURL();
            // Create a list of URL-encoded values for the request body
            var requestBody = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("username", user.username),
                new KeyValuePair<string, string>("password", user.password),
                new KeyValuePair<string, string>("grant_type", user.grant_type)
            };

            // Create the URL-encoded content
            var content = new FormUrlEncodedContent(requestBody);

            // Create an HttpClient instance
            using (var httpClient = new HttpClient())
            {
                // Set the "Accept" header
                httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

                // Set the Basic Authentication header
                var username = url.Username;  // Replace with your username
                var password = url.Password;  // Replace with your password
                var base64Credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{password}"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", base64Credentials);

                // Make an HTTP POST request to the API
                HttpResponseMessage response = await httpClient.PostAsync(apiUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    string responseJson = await response.Content.ReadAsStringAsync();
                    // object responseModel = JsonConvert.DeserializeObject<object>(responseJson);
                    return responseJson;
                }
                else
                {
                    // Handle API errors here
                    throw new ApiException((int)response.StatusCode, new Exception(response.Content.ReadAsStringAsync().Result), response.StatusCode.ToString());
                }
            }
        }



        public async Task<FileUploadResponse> UploadFileAsync(IFormFile file, string apiUrl, string token)
        {
            try
            {
                using var form = new MultipartFormDataContent();
                var fileContent = new ByteArrayContent(await ReadFileBytesAsync(file));
                fileContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
                {
                    Name = "file",
                    FileName = file.FileName
                };
                form.Add(fileContent);

                // Add the Authorization header
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

                var response = await _httpClient.PostAsync(apiUrl, form);

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<FileUploadResponse>(responseContent);
                }
                else
                {
                    // Handle API errors here
                    throw new ApiException((int)response.StatusCode, new Exception(response.Content.ReadAsStringAsync().Result), response.StatusCode.ToString());
                }
            }
            catch (ApiException ex)
            {
                // Handle exceptions here
                throw ex;
            }
            finally
            {
                _httpClient.DefaultRequestHeaders.Authorization = null;
            }
        }

        private async Task<byte[]> ReadFileBytesAsync(IFormFile file)
        {
            using (var memoryStream = new MemoryStream())
            {
                await file.CopyToAsync(memoryStream);
                return memoryStream.ToArray();
            }
        }

        public async Task<byte[]> DownloadFileAsync(string apiUrl, string token)
        {
            try
            {
                // Add the Authorization header
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                var response = await _httpClient.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    // Read the file content as a byte array
                    byte[] fileBytes = await response.Content.ReadAsByteArrayAsync();
                    return fileBytes;
                }
                else
                {
                    // Handle API errors here
                    throw new ApiException((int)response.StatusCode, new Exception(await response.Content.ReadAsStringAsync()), response.StatusCode.ToString());
                }
            }
            catch (ApiException ex)
            {
                // Handle exceptions here
                throw ex;
            }
            finally
            {
                _httpClient.DefaultRequestHeaders.Authorization = null;
            }
        }

    }
}
