using Holism.Api;

namespace Holism.Geo.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Startup.AddControllerSearchAssembly(typeof(Controllers.CountryController).Assembly);
            Holism.Api.Config.ConfigureEverything();
            // Holism.Identities.PublicApi.Config.ConfigureEverything();
            // Holism.Identities.AdminApi.Config.ConfigureEverything();
            Application.Run();
        }
    }
}
