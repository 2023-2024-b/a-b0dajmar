﻿namespace AllatboltProject.Backend.Extensions
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
                policy.WithOrigins("https://0.0.0.0:720/")

            });
        }
    }
}
