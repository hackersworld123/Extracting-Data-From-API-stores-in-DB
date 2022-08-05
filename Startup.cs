//using Microsoft.AspNetCore.Builder;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Hosting;
//using Microsoft.OpenApi.Models;
//using product_catalog_managements.Api.Data;
//using product_catalog_managements.Api.Services;
//using product_catalog_managements.Api.Services.Interfaces;
//namespace product_catalog_managements.Api
//{
//    public class Startup
//    {
//        public Startup(IConfiguration configuration)
//        {
//            Configuration = configuration;
//        }
//        public IConfiguration Configuration { get; }
//        // This method gets called by the runtime. Use this method to add services to the container.
   
//    public void ConfigureServices(IServiceCollection services)
//        {
//            services.AddControllers();
//            services.AddEntityFrameworkMySql();
//            services.AddDbContextPool<ProductDbContext>(options =>
//            {

//                options.UseMySql(Configuration["ConnectionStrings:productcatalogmanagement"]);
//            });
//            services.AddSwaggerGen(options =>
//            {
//                options.SwaggerDoc("v1", new OpenApiInfo
//                {
//                    Title =
//               "productcatalogmanagement.Api",
//                    Version = "v1"
//                });
//            });
//            services.AddTransient<IProductCategoryServices,
//           ProductCategoryServices>();
//            services.AddTransient<IProductServices, ProductServices>();
//            services.AddTransient<IInvoiceServices, InvoiceServices>();
//        }
//        // This method gets called by the runtime. Use this method to configure th HTTP request pipeline.
   
//    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
//        {
//            if (env.IsDevelopment())
//            {
//                app.UseDeveloperExceptionPage();
//            }
//            app.UseHttpsRedirection();
//            app.UseSwagger();
//            app.UseSwaggerUI(c =>
//            {
//                c.SwaggerEndpoint("/swagger/v1/swagger.json",
//               "productcatalogmanagement API v1");
//            });
//            app.UseRouting();
//            app.UseAuthorization();
//            app.UseEndpoints(endpoints =>
//            {
//                endpoints.MapControllers();
//            });
//        }
//    }
//}