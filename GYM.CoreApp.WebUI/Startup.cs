using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GYM.CoreApp.WebUI.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace GYM.CoreApp.WebUI
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

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddControllersWithViews()
                    .AddRazorRuntimeCompilation(); // To enable runtime compilation in your ASP.NET Core 3.0 project:


            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("GymDbConnection")));


            services.AddDefaultIdentity<IdentityUser>().AddEntityFrameworkStores<ApplicationDbContext>();


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();  //If the app calls UseStaticFiles, place UseStaticFiles before UseRouting.
            app.UseRouting();  // 
            app.UseCookiePolicy();
            app.UseAuthentication(); // If the app uses authentication / authorization features such as AuthorizePage or[Authorize], place the call to UseAuthentication and UseAuthorization: after, UseRouting and UseCors, but before UseEndpoints:
            //app.UseAuthorization();


            app.UseEndpoints(endpoints =>           // https://developpaper.com/asp-net-core-3-0-area-and-routing-configuration-method/
            {

                endpoints.MapAreaControllerRoute(
                 name: "areas", "Employees",
                 pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            });


            //app.UseMvc(routes =>  // Replace UseMvc or UseSignalR with UseEndpoints.
            //{
            //    routes.MapAreaRoute(
            //    name: "Employees",
            //    areaName: "Employees",
            //    template: "Employees/{controller=Employees}/{action=Index}/{id?}"); // if the name of the area is written before the controller, we need to add the name of the area in the URL itself too in order for the routing to work 


            //    routes.MapRoute(
            //        name: "default",
            //        template: "{controller=Home}/{action=Index}/{id?}");
            //});
        }
    }
}
