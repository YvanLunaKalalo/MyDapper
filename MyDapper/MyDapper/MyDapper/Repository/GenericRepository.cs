using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyDapper.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        IDbConnection connection;
       
        readonly string connectionString = "SERVER=LAPTOP-450223SP\\SQLEXPRESS; Database=MyDapper; Trusted_Connection=True; MultipleActiveResultSets=true";

        //public object tableName => throw new NotImplementedException();

        public GenericRepository()
        {
            connection = new SqlConnection(connectionString);
        }

        public T GetbyId(int id)
        {
            return null;
        }

        public bool Add(T entity)
        {
            string tableName = GetTableName();
            string columns = GetColumnNames();
            string values = GetColumnValues();
            string query = $"INSERT INTO {tableName} ({columns}) VALUES ({values})";

            int affectedRow = 0;
            affectedRow = connection.Execute(query, entity);
            return affectedRow == 1;

            
        }
        public bool Update(T entity)
        {
            throw new NotImplementedException();
        }
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
        public string GetTableName()
        {
            string tableName = "";
            var type = typeof(T);
            var tableAttr = type.GetCustomAttribute<TableAttribute>();
            if (tableAttr != null)
            {
                tableName = $"[{tableAttr.Name}]";
            }
            return tableName;

        }
        public string GetColumnNames(bool excludeKey = true)
        {
            //string columnNames = "";
            var type = typeof(T);
            var columns = string.Join(", ", type.GetProperties()
                .Where(p => !excludeKey || !p.IsDefined(typeof(KeyAttribute)))
                .Select(p =>
                {
                    var columnAttr = p.GetCustomAttribute<ColumnAttribute>();
                    return columnAttr != null ? columnAttr.Name : p.Name;
                }));
            return columns;

        }

        public string GetColumnValues(bool excludeKey = true)
        {
            var columnValues = typeof(T).GetProperties()
            .Where(p => !excludeKey || p.GetCustomAttribute<KeyAttribute>() == null);
            var values = string.Join(",", columnValues.Select(p =>
            {
                return $"@{p.Name}";
            }));
            return values;
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Delete(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
