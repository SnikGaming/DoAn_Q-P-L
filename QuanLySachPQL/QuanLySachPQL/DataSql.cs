using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows;

namespace QuanLySachPQL
{
    public class DataSql
    {
        private string connectionString = @"Data Source=DESKTOP-S4ONEVA\SQLEXPRESS;Initial Catalog=QLS;Integrated Security=True";
        private SqlConnection connection;
        private SqlCommand command;
        private DataTable table;
        private string str = "";
        public DataSql()
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connect fail" + ex.Message);
            }
            finally
            {
                connection.Close();

            }
        }

        public DataTable selectData(string sql, List<CustomParameter> parameters)
        {
            try
            {
                connection.Open();
                //str = "Exec SelectAllNhanVien";
                command = new SqlCommand(str, connection);
                command.CommandType = CommandType.StoredProcedure;
                //command.CommandType = CommandType.Text;
                command.CommandText = "SelectAllNhanVien";
                foreach (var p in parameters) { command.Parameters.AddWithValue(p.Key, p.Value); }
                table = new DataTable();
                table.Load(command.ExecuteReader());
                return table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Load Data :" + ex.Message);
                return null;
            }
            finally
            {
                connection?.Close();
            }
        }
        public DataRow Select(string str)
        {
            try
            {
                connection.Open();

                command = new SqlCommand(str, connection);
                table = new DataTable();
                table.Load(command.ExecuteReader());
                return table.Rows[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
        public int Execute(string str, List<CustomParameter> customParameters)
        {
            try
            {
                connection.Open();
                command = new SqlCommand(str, connection);
                command.CommandType = CommandType.StoredProcedure;
                foreach (var p in customParameters)
                {
                    command.Parameters.AddWithValue(p.Key, p.Value);
                }

                var re = command.ExecuteNonQuery();
                return (int)re;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
                return -100;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}

