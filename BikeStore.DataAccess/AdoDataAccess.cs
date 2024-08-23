using BikeStore.Staffs.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeStore.DataAccess;

public class AdoDataAccess : IDataAccess<Staff>
{
    private readonly SqlConnection _dbConnection;
    public AdoDataAccess(IConfiguration configuration)
    {
        _dbConnection = new SqlConnection(configuration.GetConnectionString("Default"));
    }
    public void AddOrModifyData(string query, Staff parameter)
    {
        throw new NotImplementedException();
    }

    public List<Staff> GetAll(string tableName)
    {
        using(var conn = _dbConnection)
        {
            var staffs = new List<Staff>();
            var command = new SqlCommand($"select * from {tableName}",conn);
            conn.Open();
            var rdr = command.ExecuteReader();
            while (rdr.Read())
            {
                var staff = new Staff
                {
                    First_Name = rdr["first_name"].ToString() ?? string.Empty,
                    Last_Name = rdr["last_name"].ToString() ?? string.Empty,
                };
                staffs.Add(staff);
            }
            return staff
        }
    }

    public Staff? Search(string tableName, string whereClause)
    {
        throw new NotImplementedException();
    }
}
