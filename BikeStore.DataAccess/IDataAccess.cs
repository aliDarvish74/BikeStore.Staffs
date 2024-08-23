using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeStore.DataAccess;

public interface IDataAccess<T>
{
    void AddOrModifyData(string query, T parameter);
    T? Search(string tableName, string whereClause);
    List<T> GetAll(string tableName);
}
