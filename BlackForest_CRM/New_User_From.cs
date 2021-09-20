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

namespace BlackForest_CRM
{
    public partial class New_User_From : Form
    {
        public New_User_From()
        {
            InitializeComponent();

            Reg_login.Text = "login";
            Reg_Name.Text = "name";
            Reg_Surname.Text = "surname";
            Reg_Password.Text = "password";
            Reg_RPassword.Text = "password repeat";
        }
        public bool checkUser()
        {
            string login_user = Reg_login.Text;

            Database db = new Database();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @ul ", db.get_connection());
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = login_user;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("такой пользователь уже существует");
                return true;
            }
            else
                return false;
        }

        private void Create_Button_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `name`, `surname`) VALUES (@login, @password, @name, @surname);", db.get_connection());

            if (Reg_login.Text == "login" || Reg_Name.Text == "name" || Reg_Surname.Text == "surname" || Reg_Password.Text == "password" || Reg_RPassword.Text == "password repeat")
            {
                MessageBox.Show("не все поля заполнены");
            }
            else if (Reg_Password.Text == Reg_RPassword.Text)
            {
                if (checkUser())
                return;

                command.Parameters.Add("@login", MySqlDbType.VarChar).Value = Reg_login.Text;
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = Reg_Name.Text;
                command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = Reg_Surname.Text;
                command.Parameters.Add("@password", MySqlDbType.VarChar).Value = Reg_Password.Text;

                db.open_connection();
                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Пользователь добавлен");
                else MessageBox.Show("Произошзла ошибка при добавлении пользователя");
                db.close_connection();
            }
            else MessageBox.Show("Пароли не совпадают");
        }

        private void Reg_login_Enter(object sender, EventArgs e)
        {
            if (Reg_login.Text == "login")
                Reg_login.Text = "";
        }

        private void Reg_login_Leave(object sender, EventArgs e)
        {
            if (Reg_login.Text == "")
                Reg_login.Text = "login";
        }

        private void Reg_Name_Enter(object sender, EventArgs e)
        {
            if (Reg_Name.Text == "name")
                Reg_Name.Text = "";
        }

        private void Reg_Name_Leave(object sender, EventArgs e)
        {
            if (Reg_Name.Text == "")
                Reg_Name.Text = "name";
        }

        private void Log_Name_Enter(object sender, EventArgs e)
        {
            if (Reg_Surname.Text == "surname")
                Reg_Surname.Text = "";
        }

        private void Log_Name_Leave(object sender, EventArgs e)
        {
            if (Reg_Surname.Text == "")
                Reg_Surname.Text = "surname";
        }

        private void Reg_Password_Enter(object sender, EventArgs e)
        {
            if (Reg_Password.Text == "password")
            {
                Reg_Password.Text = "";
                Reg_Password.UseSystemPasswordChar = true;
                //Reg_Password.PasswordChar = '*';
            }
        }

        private void Reg_Password_Leave(object sender, EventArgs e)
        {
            if(Reg_Password.Text == "")
            {
                Reg_Password.UseSystemPasswordChar = false;
                Reg_Password.Text = "password";
            }
        }
        private void Reg_RPassword_Enter(object sender, EventArgs e)
        {
            if (Reg_RPassword.Text == "password repeat")
            {
                Reg_RPassword.Text = "";
                Reg_RPassword.UseSystemPasswordChar = true;
                //Reg_Password.PasswordChar = '*';
            }
        }

        private void Reg_RPassword_Leave(object sender, EventArgs e)
        {
            if (Reg_RPassword.Text == "")
            {
                Reg_RPassword.UseSystemPasswordChar = false;
                Reg_RPassword.Text = "password repeat";
            }
        }

        private void Log_CancelLogButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point lastpoint;

        private void New_User_From_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void New_User_From_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }
    }
}
