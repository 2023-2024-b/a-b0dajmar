using AllatboltProject.Backend.Context;

namespace AllatboltProject.Backend.Extensions
{
    public static class AllatboltBackendExtension
    {
        public static void AddBackend(this IServiceCollection services) { }
        private static void ConfigureCors(IServiceCollection services)
        {
            services.AddCors(option =>
            option.AddPolicy(name: "AllatCors",
            policy =>
            {
                policy.WithOrigins("https://localhost:7020/")
                        .AllowAnyHeader()
                        .AllowAnyMethod();
            }));
        }
        public static void ConfigureInMemoryContext(this IServiceCollection services)
        {
            string dbNameInMemoryContext = "Allatbolt" + Guid.NewGuid();
            services.AddDbContext<AllatboltInMemoryContext>
            (
                 options => options.UseInMemoryDatabase(databaseName: dbNameInMemoryContext),
                 ServiceLifetime.Scoped,
                 ServiceLifetime.Scoped
            );
        }
    }
}
