using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Fintrak.TRMS
{
    // Inside a service responsible for token storage
    public class TokenStorageService
    {
        private readonly IDataProtectionProvider _dataProtectionProvider;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private const string TokenKey = "ExternalApiBearerToken";

        public TokenStorageService(IDataProtectionProvider dataProtectionProvider, IHttpContextAccessor httpContextAccessor)
        {
            _dataProtectionProvider = dataProtectionProvider;
            _httpContextAccessor = httpContextAccessor;
        }

        public void StoreToken(string token)
        {
            var protector = _dataProtectionProvider.CreateProtector(typeof(TokenStorageService).FullName);

            // Encrypt and store the token
            var encryptedToken = protector.Protect(token);
            // Store encrypted token in a secure manner (e.g., session, cache, database)
            _httpContextAccessor.HttpContext.Session.SetString(TokenKey, encryptedToken);
        }

        public string RetrieveToken()
        {
            var token = "";
            var protector = _dataProtectionProvider.CreateProtector(typeof(TokenStorageService).FullName);

            // Retrieve encrypted token
            var encryptedToken = _httpContextAccessor.HttpContext.Session.GetString(TokenKey);
            // Decrypt token
            if (encryptedToken != null)
                token = protector.Unprotect(encryptedToken);

            return token;
        }
    }

}
