using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entity;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminUI
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
            services.AddControllersWithViews();
            services.AddScoped<IProductService, ProductMan>();
            services.AddScoped<ICategoryService, CategoryMan>();
            services.AddScoped<IUserService, UserMan>();
            services.AddScoped<IModelService, ModelMan>();
           
            services.AddScoped<IModelDal,ModelDal>();
            services.AddScoped<IProductDal, ProductDal>();
            services.AddScoped<ICategoryDal, CategoryDal>();
            services.AddScoped<IUserDal, UserDal>();
           

            
			services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).
			  AddCookie(x =>
			  {
				  x.LoginPath = "/Login/LoginPanel";
			  }
		   );
			services.AddAuthenticationCore();

			services.AddHttpContextAccessor();

			services.AddAuthorization(options =>
			{
				options.AddPolicy("User",
					 policy => policy.RequireRole("User"));
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
			app.UseAuthentication();
			app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Login}/{action=LoginPanel}/{id?}");
            });
        }
    }
}
