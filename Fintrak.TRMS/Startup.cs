using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Fintrak.TRMS.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Fintrak.TRMS.Services.Interface;
using Fintrak.TRMS.Services.Repository;
using Fintrak.TRMS.Services;
using Microsoft.AspNetCore.Authentication;
using AspNetCoreHero.ToastNotification;

namespace Fintrak.TRMS
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddControllersWithViews();

            services.AddNotyf(config => {
                config.DurationInSeconds = 10;
                config.IsDismissable = true;
                config.Position = NotyfPosition.TopRight;
            });
            services.AddDatabaseDeveloperPageExceptionFilter();
            services.AddAuthentication("ExternalApiBearer")
                .AddScheme<AuthenticationSchemeOptions, ExternalApiBearerTokenHandler>("ExternalApiBearer", options => { });

            services.AddHttpClient<APIService>(client =>
            {
                client.BaseAddress = new Uri("http://ami3.tradesystem.gov.ng/trms/");
            });
            services.AddHttpContextAccessor();
            services.AddTransient<TokenStorageService>();

            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<IADBReviewerRepository, ADBReviewerRepository>();
            services.AddScoped<IApprovalRejectionRepository, ApprovalRejectionRepository>();
            services.AddScoped<IDisbursementReviewerRepository, DisbursementReviewerRepository>();
            services.AddScoped<IPendingApplicationRepository, PendingApplicationRepository>();
            services.AddScoped<IProcessedApplicationRepository, ProcessedApplicationRepository>();
            services.AddScoped<IRejectionRepository, RejectionRepository>();
            services.AddScoped<IADBReviewerNCXRepository, ADBReviewerNCXRepository>();
            services.AddScoped<ICancelADBReviewerNCXRepository, CancelADBReviewerNCXRepository>();
            services.AddScoped<IPendingApplicationNCXRepository, PendingApplicationNCXRepository>();
            services.AddScoped<IProcessedApplicationNCXRepository, ProcessedApplicationNCXRepository>();
            services.AddScoped<IUploadRepository, UploadRepository>();

            services.AddScoped<IFormADetailsRepository, FormADetailsRepository>();
            services.AddScoped<IFormNCXDetailsRepository, FormNCXDetailsRepository>();
            services.AddScoped<INessLevyByShipmentRepository, NessLevyByShipmentRepository>();
            services.AddScoped<INessLevyDetailsRepository, NessLevyDetailsRepository>();
            services.AddScoped<INessLevyPaymentRepository, NessLevyPaymentRepository>();
            services.AddScoped<IPendingNXPShipmentRepository, PendingNXPShipmentRepository>();
            services.AddScoped<IRepatriationApprovalRepository, RepatriationApprovalRepository>();
            services.AddScoped<IShipmentFormDetailsRepository, ShipmentFormDetailsRepository>();
            services.AddScoped<ISingleShipmentRepository, SingleShipmentRepository>();
            services.AddScoped<INXPApprovalRepository, NXPApprovalRepository>();
            services.AddScoped<INXPCancellationRepository, NXPCancellationRepository>();
            services.AddScoped<INXPFormDetailsRepository, NXPFormDetailsRepository>();
            services.AddScoped<IPendingFormNXPRepository, PendingFormNXPRepository>();
            services.AddScoped<IProcessedNXPRepository, ProcessedNXPRepository>();
            services.AddScoped<IDownloadFileRepository, DownloadFileRepository>();
            services.AddScoped<IPaymentModesRepository, PaymentModesRepository>();
            services.AddScoped<IViewFileRepository, ViewFileRepository>();

            services.AddSession(options =>
            {
                // Set appropriate options, if needed
                options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseSession();

            app.UseStatusCodePages(async context => {
                if (context.HttpContext.Response.StatusCode == 401 || context.HttpContext.Response.StatusCode == 302)
                {
                    // your redirect
                    context.HttpContext.Response.Redirect("/Account/Login");
                }
            });

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
