using ITP4522_Project.Resources.Login;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4522_Project
{
    public partial class frmLogin : Form
    {
        string connStr = "server=127.0.0.1;port=3306;user id=root;password=;database=user;charset=utf8;";
        MySqlConnection conn = new MySqlConnection();
        int i;

        private readonly 
        user objDbAccess = new user();
        public frmLogin()
        {
            InitializeComponent();
        }
        public void Display() {
            //DBUser.DisplayAndSearch("SELECT id, email, password, CreateAt FROM dbuser ");
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtAccountNumber_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = connStr;
            i = 0;
            conn.Open();
            string sql = "SELECT * FROM dbuser WHERE id='"+txtAccountNumber.Text+"' AND password='"+txtPassword.Text+"'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader ac = cmd.ExecuteReader();

            if (ac.Read())
            {
                String email = (String)ac["email"];
                this.Hide();
                frmBranchA branchA = new frmBranchA();
                branchA.ShowDialog();

            }
            else {
                MessageBox.Show("You have entered invalid username or password");
            }
            /*
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (i == 0)
            {
                MessageBox.Show("You have entered invalid username or password");
            }
            else
            {
                this.Hide();
                frmBranchA branchA = new frmBranchA();
                branchA.ShowDialog();
            }*/

            conn.Close();

            /*string account = txtAccountNumber.Text;
            string password = txtPassword.Text;

            if (account.Equals(""))
            {
                MessageBox.Show("please enter account");
            }
            else if (password.Equals(""))
            {
                MessageBox.Show("please enter password");
            }
            else
            {
                string query = "Select * from Users Where Account = '" + account + "'AND Password = '" + password + "'";
            }*/
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            frmForgotPassword forgotPassword = new frmForgotPassword();
            forgotPassword.ShowDialog();
        }

        private void ckRememberMe_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
