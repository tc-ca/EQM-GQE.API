using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using EQM_GQE.DATA;
using Microsoft.EntityFrameworkCore;
using EQM_GQE.DATA.Repositories;
using EQM_GQE.SHARED_RESOURCES.Interfaces;
using EQM_GQE.LOGICAL;
using EQM_GQE.LOGICAL.Services;

namespace EQM_GQE.API
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
            services.AddDbContext<QuestionnaireContext>(options =>
                    options.UseNpgsql(Configuration.GetConnectionString("EQMConnection")));
            services.AddScoped<IQuestionnaireContext>(provider => provider.GetService<QuestionnaireContext>());
            services.AddScoped<IQuestionnaireRepository, QuestionnaireRepository>();
            services.AddScoped<IQuestionnaireLogic, QuestionnaireLogic>();

            services.AddScoped<IBusinessLineRepository, BusinessLineRepository>();
            services.AddScoped<IBusinessLineLogic, BusinessLineLogic>();

            services.AddScoped<IDocumentStatusRepository, DocumentStatusRepository>();
            services.AddScoped<IDocumentStatusLogic, DocumentStatusLogic>();

            services.AddScoped<IDocumentTypeRepository, DocumentTypeRepository>();
            services.AddScoped<IDocumentTypeLogic, DocumentTypeLogic>();

            services.AddScoped<ISecurityClassificationRepository, SecurityClassificationRepository>();
            services.AddScoped<ISecurityClassificationLogic, SecurityClassificationLogic>();

            services.AddScoped<IBusinessLineAccessControlRepository, BusinessLineAccessControlRepository>();
            services.AddScoped<IBusinessLineAccessControlLogic, BusinessLineAccessControlLogic>();

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "EQM_GQE.API", Version = "v1" });
            });
            services.AddMvc();           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, QuestionnaireContext questionaireContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "EQM_GQE.API v1"));
            }

            questionaireContext.Database.Migrate();
            
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
