using CondominiumsManager.DAL;
using Microsoft.EntityFrameworkCore;

namespace CondominiumsManager
{
    public class Startup
    {
        private object endpoint;

        public Startup(IConfiguration configuration)
        {
            configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            //opiçoes de conecçôes
            services.AddDbContext<Contexto>(opcoes => opcoes.UseSqlServer(Configuration.GetConnectionString("ConexaoDB")));
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseExceptionHandler();
            app.UseHsts();

            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                name: "defalt",
                pattern: "{contrller=Homer}/{action=Index}/{id}");
            });
        }
       

    }
}
