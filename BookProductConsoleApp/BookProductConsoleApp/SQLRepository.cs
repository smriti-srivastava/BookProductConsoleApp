using FactoryPatternAssignment;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProductConsoleApp
{
    class SQLRepository : IRepository<IProduct>
    {
        public void Save(IProduct product)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = @"Data Source=TAVDESK149;Initial Catalog=ProductDB;User Id=sa;Password=test123!@#";
                connection.Open();
                string query = "Insert into " + product.GetTypeOfProduct() + "(Id, Name, Price, IsBooked) values(@id,@name,@price,@isBooked)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@id", product.Id));
                command.Parameters.Add(new SqlParameter("@name", product.Name));
                command.Parameters.Add(new SqlParameter("@price", product.Price));
                command.Parameters.Add(new SqlParameter("@isBooked", product.IsBooked));
                command.ExecuteNonQuery();
                Logger.getLogger().LogMessage("Product Saved To SQL Database");
            }
        }
    }
}
