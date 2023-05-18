using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;


namespace ConexaoComBDSQL_Teste
{
    public class Connection
    {
        string connectionString = "Data Source=.;Initial Catalog=TesteCRUD;User ID=FER-PC/ferna;Integrated Security=True; TrustServerCertificate=True"; 
        private SqlConnection connectionDB;

        public Connection()
        {
            this.connectionString = connectionString;
        }


        public void Open()
        {
            connectionDB = new SqlConnection(connectionString);
            connectionDB.Open();
        }

        public void Close()
        {
            if (connectionDB != null && connectionDB.State == System.Data.ConnectionState.Open)
            {
                connectionDB.Close();
            }
        }

        public DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();

            using (SqlCommand command = new SqlCommand(query, connectionDB))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        public void ExecuteNonQuery(string query)
        {
            using (SqlCommand command = new SqlCommand(query, connectionDB))
            {
                command.ExecuteNonQuery();
            }
        }
    }
}
