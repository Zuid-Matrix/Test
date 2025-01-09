using Matrix.Authentication.Client;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.IO;
using System.Security.Cryptography;
using Microsoft.CodeAnalysis.Elfie.Extensions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Matrix.Prox3.IntelliZone.Data.Authentication;
using DocumentFormat.OpenXml.Math;
using DocumentFormat.OpenXml.CustomXmlSchemaReferences;
using Matrix.Prox3.IntelliZone.Data.VolatileStorage;
namespace Matrix.Prox3.LocalConnection.Server.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        
     
        private readonly IWebHostEnvironment environment;
        private IConfiguration _configuration;
        private ILogger<LoginController> _logger;
        private IntelliZoneAuthenticationService _intelliZoneAuthenticationService;
        public LoginController(IWebHostEnvironment environment, IConfiguration configuration, ILogger<LoginController> logger, IntelliZoneAuthenticationService intelliZoneAuthenticationService)
        {
            this.environment = environment;
            _configuration = configuration;
            _logger = logger;
            _intelliZoneAuthenticationService = intelliZoneAuthenticationService;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> LoginCallback(string token, string? email,int? otp = null)
        {
            var pvkey = _configuration["PrivateKey"];
            bool valid = false;
            string? url = "";
            object? sid = null;
            try
            {
                using (var client = new HttpClient())
                {
                    if (!string.IsNullOrEmpty(token) && otp == null)
                    {
                        var apikey = _configuration["APIKey"];
                        var signonurl = _configuration["SignonURL"];
                        (valid, url, sid) = await Process.ValidateToken(client, apikey, signonurl, token, email, pvkey);
                    }
                }

                if (valid && email != null)
                {


                  (var schem ,var princ, var properties ) = await _intelliZoneAuthenticationService.GetSigningCookieDetails(email, null, sid);


					
					await HttpContext.SignInAsync(
					schem,
					princ,
					properties);
					if (url != null && url != "/")
                    {
                        return Redirect(url);
                    }
                    return Redirect("");
                    var subArray = System.Text.Json.JsonSerializer.Deserialize<object[]>(sid?.ToString() ?? "");

                }
                else
                {
                    return Redirect("");
                   // MyNavigationManager.NavigateTo("/");
                }

            }

            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return Redirect("/");
            }
        }

        /// <summary>
        /// Log in the server application with the user's
        /// </summary>
        /// <param name="JobLevel"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        [HttpGet("[action]")]
        public async Task<IActionResult> LoginApplication(string url)
        {



            try
            {
                if (ReportStorage.licence != null && DateTime.Compare((DateTime)ReportStorage.licenceExpiry, DateTime.Now ) >=0)
                { 
                    (var schem, var princ, var properties) = await _intelliZoneAuthenticationService.GetSigningCookieDetails(null, ReportStorage.licence.Name, null);



                await HttpContext.SignInAsync(
                schem,
                princ,
                properties);
            }
                    return Redirect(url);
                   

    

            }

            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return Redirect("/");
            }
        }
    }
}



