using AquaApi.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AquaApi
{
    public class Startup
    {
        //dodajemy mozliwosc sterowania konfiguracja
        public IConfiguration Configuration;
        public Startup(IConfiguration configuration) => Configuration = configuration;


        public void ConfigureServices(IServiceCollection services)
        {
            //konfiguracja połączenia z bazą
            services.AddDbContext<DypAquaContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:DypAqua"]));

            //wstrzykiwanie zależności
            //services.AddSingleton<IPomiarRepo, EFPomiarRepo>();

            //MVC
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStatusCodePages();
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}
