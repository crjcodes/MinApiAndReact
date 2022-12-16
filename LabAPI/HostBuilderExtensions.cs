//using LabAPI.Models;

//namespace LabAPI
//{
//    public static class HostBuilderExtensions
//    {
//        public static WebApplicationBuilder BuildWebServer(this WebApplicationBuilder builder)
//        {
//            // some scaffolded stuff that's rather lovely

//            builder.Services.BuildServices();
//            return builder;
//        }

//        public static IServiceCollection BuildServices(this IServiceCollection services)
//        {
//            services.AddControllers();
//            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//            services.AddEndpointsApiExplorer();
//            services.AddSwaggerGen();

//            return services;
//        }

//        public static WebApplication SetupApp(this WebApplication app)
//        {
//            // Configure the HTTP request pipeline.
//            if (app.Environment.IsDevelopment())
//            {
//                app.UseSwagger();
//                app.UseSwaggerUI();
//            }

//            app.UseHttpsRedirection();
//            app.UseAuthorization();
//            app.MapControllers();

//            return app;
//        }
//    }
//}
