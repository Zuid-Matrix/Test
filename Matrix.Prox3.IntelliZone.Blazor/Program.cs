
using Blazored.Modal;
using Matrix.Prox3.IntelliZone.Data.Authentication;
using Matrix.Prox3.IntelliZone.Data.Enums;
using Matrix.Prox3.IntelliZone.Data.VolatileStorage;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;
using Serilog;

namespace Matrix.Prox3.IntelliZone.Blazor
{
	public class Program
	{
		public static void Main(string[] args)
		{

			var builder = WebApplication.CreateBuilder(args);


			IConfiguration config = builder.Configuration;

			var signalrURL = config["ApiURL"];
			var port = config["ApplicationPort"];
			var useHttps = config["UseHttps"] == "Yes" ? true : false;
			//var appsetup = config["AppConfiguration"];
			var loggerconfig = new LoggerConfiguration().ReadFrom.Configuration(config);
			var appsetup = Enum.Parse<AppConfiguration>(config["AppConfiguration"], true);

			if (appsetup != AppConfiguration.CloudReporting && Environment.OSVersion.Platform == PlatformID.Win32NT)
			{
				ReportStorage.appDataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Matrix_Design_Africa\\IntelliZoneReporting";
				if (!Directory.Exists(ReportStorage.appDataDirectory))
				{ Directory.CreateDirectory(ReportStorage.appDataDirectory); }
			}

			builder.Services.AddAntiforgery();
			builder.Services.AddRazorPages();
			builder.Services.AddServerSideBlazor();
            builder.Services.AddBlazorBootstrap();
            builder.Services.AddQuickGridEntityFrameworkAdapter();
            builder.Services.AddMudServices();
            builder.Services.AddBlazoredModal();
			if (useHttps)
			{
				builder.WebHost.UseUrls($"https://*:{port}");
			}
			else
			{
				builder.WebHost.UseUrls($"http://*:{port}");
			}
			builder.Services.AddHostedService(sp => sp.GetRequiredService<IntelliZoneAuthenticationService>());
			builder.Services.AddSingleton<IntelliZoneAuthenticationService>();


			builder.Services.AddScoped<HubConnection>(sp =>
			{
				var navMan = sp.GetRequiredService<NavigationManager>();

				return new HubConnectionBuilder()
					.WithUrl(navMan.ToAbsoluteUri($"{signalrURL}/intellizonesignalr"))
					.Build();

			});
			if (appsetup != AppConfiguration.CloudReporting)
			{

				loggerconfig.WriteTo.File($"{ReportStorage.appDataDirectory}/logs/blazorlog-.json", rollingInterval: RollingInterval.Day, retainedFileCountLimit: 14);

			}
			
			var temp = Log.Logger = loggerconfig.CreateLogger();
			builder.Logging.ClearProviders();
			builder.Logging.AddSerilog();
			builder.Services.AddCors(policy =>
			{
				policy.AddPolicy("myAllow", builder => builder.AllowAnyOrigin()
					 .AllowAnyMethod()
					 .AllowAnyHeader().Build());
			});


			///API
			builder.Services.AddResponseCompression(opts =>
			{
				opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
					  new[] { "application/octet-stream" });
			});
			builder.Services.AddScoped(sp =>
					new HttpClient
					{
						BaseAddress = new Uri(config["ApiURL"]),
						Timeout = TimeSpan.FromSeconds(1000)

					});

			//Authentication
            builder.Services.AddAuthenticationCore();
			builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
				   .AddCookie(options =>
				   {
					   options.ExpireTimeSpan = TimeSpan.FromHours(8); //how long cookie is valid
					   options.SlidingExpiration = true;
					   options.LoginPath = new PathString("/"); //redirect if not authenticated
					   options.LogoutPath = new PathString("/logout");
					   options.ClaimsIssuer = "Matrix";
					   options.ReturnUrlParameter = "ReturnURL"; //parameter name of Login method
					   options.AccessDeniedPath = new PathString("/common/accessdenied"); //View to show when not authenticated
				   });
			var app = builder.Build();

			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
				if (appsetup == AppConfiguration.LampRoommSystem || appsetup == AppConfiguration.LampRoomSystemLite || appsetup == AppConfiguration.CageCounter || appsetup == AppConfiguration.DesktopUtility)
				{
					if (useHttps)
					{
						System.Diagnostics.Process.Start("cmd", $"/C start https://localhost:{port}");
						System.Diagnostics.Process.Start("Matrix.Prox3.IntelliZone.API.exe");
					}
					else
					{
						System.Diagnostics.Process.Start("cmd", $"/C start http://localhost:{port}");
						System.Diagnostics.Process.Start("Matrix.Prox3.IntelliZone.API.exe");
					}
					
				}

			}

			if (useHttps)
			{
				app.UseHttpsRedirection();
			}

			
			app.MapControllers();
			app.UseStaticFiles();

			app.UseRouting();

			app.MapBlazorHub();
			app.MapFallbackToPage("/_Host");

			app.Run();
		}
	}
}
