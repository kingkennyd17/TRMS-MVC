using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Fintrak.TRMS
{
    public class ExternalApiBearerTokenHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private readonly TokenStorageService _tokenStorageService;

        public ExternalApiBearerTokenHandler(
            IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder,
            ISystemClock clock,
            TokenStorageService tokenStorageService)
            : base(options, logger, encoder, clock)
        {
            _tokenStorageService = tokenStorageService;
        }

        protected override Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            // Retrieve the bearer token from storage
            var token = _tokenStorageService.RetrieveToken();

            // Check if the token is present
            if (string.IsNullOrEmpty(token))
            {
                //SetUnauthorizedResponse("Bearer token is missing.");
                return Task.FromResult(AuthenticateResult.Fail("Bearer token is missing."));
            }

            // Perform additional token validation
            var tokenHandler = new JwtSecurityTokenHandler();
            try
            {
                var tokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = false, // Adjust this based on your external API setup
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = true, // Enable lifetime validation
                    ClockSkew = TimeSpan.Zero, // No clock skew
                    RequireExpirationTime = true, // Ensure expiration time is present
                    SignatureValidator = delegate (string token, TokenValidationParameters parameters)
                    {
                        var jwt = new JwtSecurityToken(token);

                        return jwt;
                    }
                };

                // Validate the token
                ClaimsPrincipal claimsPrincipal = tokenHandler.ValidateToken(token, tokenValidationParameters, out SecurityToken validatedToken);

                // Check if the token has expired
                if (validatedToken is JwtSecurityToken jwtSecurityToken && jwtSecurityToken.ValidTo < DateTime.UtcNow)
                {
                    //SetUnauthorizedResponse("Bearer token has expired.");
                    return Task.FromResult(AuthenticateResult.Fail("Bearer token has expired."));
                }

                // Create a ClaimsIdentity and store the authenticated user
                var identity = new ClaimsIdentity(claimsPrincipal.Identity);
                var principal = new ClaimsPrincipal(identity);
                var ticket = new AuthenticationTicket(principal, Scheme.Name);

                return Task.FromResult(AuthenticateResult.Success(ticket));
            }
            catch (Exception ex)
            {
                //SetUnauthorizedResponse($"Token validation failed: {ex.Message}");
                return Task.FromResult(AuthenticateResult.Fail($"Token validation failed: {ex.Message}"));
            }
        }

        protected override Task HandleChallengeAsync(AuthenticationProperties properties)
        {
            // Redirect to login on authentication failure
            Response.Redirect("/Account/Login");
            return Task.CompletedTask;
        }
    }

}
