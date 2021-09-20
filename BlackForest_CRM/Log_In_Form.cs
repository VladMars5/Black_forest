using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BlackForest_CRM
{
    public partial class Log_In_Form : Form
    {
        public Log_In_Form()
        {
            InitializeComponent();
            Log_Name.Text = "Login";
            Log_Password.Text = "Password";
        }

        
 
        private void Log_logInButton_Click(object sender, EventArgs e)
        {
            string login_user = Log_Name.Text;
            string pass_user = Log_Password.Text;

            Database db = new Database();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @ul AND `password` = @up",db.get_connection());
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = login_user;
            command.Parameters.Add("@up", MySqlDbType.VarChar).Value = pass_user;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Close();
                Main_Form.ActiveForm.Enabled = true;
                Main_Form.ActiveForm.Visible = true;
                //if(login_user == "admin")
                   // Main_Form.menuStrip1.администрированиеToolStripMenuItem.Enabled = true;
                //Main_Form mainform = new Main_Form();
                //mainform.Show();
            }
            else
                MessageBox.Show("вы ввели неверный логин или пароль");
        }

        private void Log_CancelLogButton_Click(object sender, EventArgs e)
        {
             Application.Exit();
            //this.Close();
        }
 
        Point lastPoint;
        private void Log_In_Form_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Log_In_Form_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Log_CancelLogButton_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                /*string login_user = Log_Name.Text;
                string pass_user = Log_Password.Text;

                Database db = new Database();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @ul AND `password` = @up", db.get_connection());
                command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = login_user;
                command.Parameters.Add("@up", MySqlDbType.VarChar).Value = pass_user;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    Close();
                    Main_Form.ActiveForm.Enabled = true;
                }
                else
                    MessageBox.Show("вы ввели неверный логин или пароль");*/
                Log_logInButton_Click(sender, e);
            }
        }

        private void Log_Name_Enter(object sender, EventArgs e)
        {
            if (Log_Name.Text == "Login")
                            Log_Name.Text = "";
        }

        private void Log_Name_Leave(object sender, EventArgs e)
        {
            if (Log_Name.Text == "")
                Log_Name.Text = "Login";
        }

        private void Log_Password_Enter(object sender, EventArgs e)
        {
            if (Log_Password.Text == "Password")
            {
                Log_Password.Text = "";
                Log_Password.UseSystemPasswordChar = true;
                //Log_Password.PasswordChar = '*';
            }
        }

        private void Log_Password_Leave(object sender, EventArgs e)
        {
            if (Log_Password.Text == "")
            {
                Log_Password.UseSystemPasswordChar = false;
                Log_Password.Text = "Password";
            }
        }
    }
}
