using Npgsql;
namespace SunnySystem.Data;
using SunnySystem.Data.Model;
public class DbContext 
{
    NpgsqlDataSource dataSource;   

    public DbContext() 
    {
        
        var connString = ConnStr.Get();

       dataSource = NpgsqlDataSource.Create(connString);;

    }

}

