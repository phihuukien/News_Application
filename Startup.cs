using AspNetCoreHero.ToastNotification;
using AspNetCoreHero.ToastNotification.Extensions;
using BTLASPMONGO.Models.BusinessModels;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTLASPMONGO
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
            services.AddNotyf(config => { config.DurationInSeconds = 10; config.IsDismissable = true; config.Position = NotyfPosition.TopRight; });
            services.AddControllersWithViews();
            services.AddScoped<NewsDbContext>();
            services.AddScoped<IRepositoryCategory, RepositoryCategory>();
            services.AddScoped<IRepositoryNews, RepositoryNews>();
            services.AddScoped<IRepositoryAccount, RepositoryAccount>();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
               .AddCookie(options =>
               {

                   options.ExpireTimeSpan = TimeSpan.FromDays(60);
                   options.LoginPath = new PathString("/admin/login");
                   options.ReturnUrlParameter = "urlRedirect";
                   options.Cookie.Path = "/";
                   options.Cookie.SameSite = SameSiteMode.Lax;
                   options.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;
                   options.Cookie.IsEssential = true;
                   options.SlidingExpiration = true;
                   options.Cookie.HttpOnly = true;
                   options.Cookie.Name = "SSID";
               });
            services.AddSession(option =>
            {
                option.Cookie.Name = "activeBy";
                option.IdleTimeout = TimeSpan.FromDays(1);
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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
            app.UseNotyf();
            app.UseSession();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "area",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}
