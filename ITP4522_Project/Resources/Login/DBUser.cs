using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4522_Project.Resources.Login
{
    internal class user
    {
        public static MySqlConnection GetConnection() {
            string sql = "datasource=127.0.0.1;port=3306;username=root;password=;database=user";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();
            }catch (MySqlException ex) {
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }
        /*public static void AddUser(User user) {
    string sql = "INSERT INTO ser table VALUES(@...)";
    MySqlConnection con = GetConnection();
    MySqlCommand cmd = new MySqlCommand(sql, con);
    cmd.CommandType = CommandType.Text;
    cmd.Parameters.Add("@User", MySqlDbType.VarChar).Value = user.Name;

}*/
        public static void DisplayAndSearch(String query)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            con.Close();
        }
    }



}
