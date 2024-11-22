namespace AllatboltProject.Backend.Extensions
{
    public static class WebApplicationExtension
    {
        public static void ConfigureWebApp(this WebApplication app)
        {
            app.ConfigureWebAppCors();
            app.ConfigureInMemoryTestData();

        }

        private static void ConfigureWebAppCors(this WebApplication app)
        {
            app.UseCors("AllatCors");
        }
        private static void ConfigureInMemoryTestData(this WebApplication app) { 
        }
    }
}
