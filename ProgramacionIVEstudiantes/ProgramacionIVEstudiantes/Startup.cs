using Microsoft.AspNetCore.Builder;
using Microsoft.OpenApi.Models;
using ProgramacionIV.BLL.Interfaces;
using ProgramacionIV.DAL;

namespace ProgramacionIVEstudiantes
{
    public class Startup
    {
        public IConfiguration configuration { get; }
        public Startup(IConfiguration configuration) 
        { 
            this.configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services) 
        { 
            services.AddScoped<IAdEstudiante, AdEstudiante>();
            services.AddControllers();
            services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc("v1", new OpenApiInfo { Title = "Api.Estudiante", Version = "v1"});
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) 
        { 
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Api.Estudiante V1"));
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

    }
}
