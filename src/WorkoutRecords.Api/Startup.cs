using GraphQL;
using GraphQL.Server;
using GraphQL.Types;
using WorkoutRecords.Api.GraphQL;

namespace WorkoutRecords.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddGraphQL(options =>
            {
                options.EnableMetrics = false;
            })
            .AddSystemTextJson()
            .AddGraphTypes(ServiceLifetime.Scoped);

            services.AddScoped<ISchema, WorkoutRecordsSchema>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseGraphQL<ISchema>();
            app.UseGraphQLPlayground();
        }
    }
}
