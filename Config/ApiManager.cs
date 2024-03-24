using System.Data.SqlClient;
using static Trendy_BackEnd.Config.EnumCollection;

namespace Trendy_BackEnd.Config
{
    public class ApiManager
    {
        private readonly string Environment = TrendyEnvironment.Development.ToString();
        private readonly string AuthToken = "IOSApplication";

        private ApiManager() { }
        private static ApiManager instance = null;
        internal static ApiManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ApiManager();
                }
                return instance;
            }
        }

        internal SqlConnectionStringBuilder GetConnectionString()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            if (Environment == TrendyEnvironment.Development.ToString())
            {
                builder.DataSource = "SQL5106.site4now.net";
                builder.InitialCatalog = "db_aa650d_harith98";
                builder.UserID = "db_aa650d_harith98_admin";
                builder.Password = "Hph@harith1234";
            }
            else if (Environment == TrendyEnvironment.UAT.ToString())
            {
                builder.DataSource = "";
                builder.InitialCatalog = "";
                builder.UserID = "";
                builder.Password = "";
            }
            else if (Environment == TrendyEnvironment.Live.ToString())
            {
                builder.DataSource = "";
                builder.InitialCatalog = "";
                builder.UserID = "";
                builder.Password = "";
            }
            return builder;
        }

        internal string GetEnvironment()
        { return Environment; }
    }
}
