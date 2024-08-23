using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BikeStore.DataAccess;

public class DapperDataAccess<T> : IDataAccess<T>
{
    private readonly IDbConnection _dbConnection;
    public DapperDataAccess(IConfiguration configuration)
    {
        _dbConnection = new SqlConnection(configuration.GetConnectionString("Default"));
    }

    public void AddOrModifyData(string query, T parameter)
    {
        using(var con = _dbConnection)
        {
            con.Open();
            var result = con.Execute(query, parameter);
        }
    }


    public List<T> GetAll(string tableName)
    {
        using (var con = _dbConnection)
        {
            con.Open();
            var result = con.Query<T>($"Select * from {tableName}");
            return result.ToList();
        }
    }

    public T? Search(string tableName, string whereClaue)
    {
        using (var con = _dbConnection)
        {
            con.Open();
            var result = con.QueryFirst<T>($"Select * from {tableName} where {whereClaue}");
            return result;
        }
    }
}
