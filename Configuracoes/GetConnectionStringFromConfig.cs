using System.Configuration;

namespace geralAPI.Configuracoes
{
    public static class GetConnectionStringFromConfig
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["EntityDataBase"].ConnectionString;
        }
    }
}