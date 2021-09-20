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
    public partial class Estimate_Form : Form
    {
        public Estimate_Form()
        {
            InitializeComponent();
        }

        Point lastpoint;

        private void Estimate_Form_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void Estimate_Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void Cancel_Buttton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void write_down()
        {
            Database db = new Database();
            MySqlCommand command = new MySqlCommand(@"INSERT INTO `quality` (`func_full`, `func_suit`, `performance`, `interface`,
            `suitability`, `conv_use`, `reliability`, `confidential`, `reusability`, `adaptability`) 
            VALUES (@func_full, @func_suit, @performance, @interface, @suitability, @conv_use, @reliability,
            @confidential, @reusability, @adaptability);", db.get_connection());

            command.Parameters.Add("@func_full", MySqlDbType.Int32).Value = answer1.Value;
            command.Parameters.Add("@func_suit", MySqlDbType.Int32).Value = answer2.Value;
            command.Parameters.Add("@performance", MySqlDbType.Int32).Value = answer3.Value;
            command.Parameters.Add("@interface", MySqlDbType.Int32).Value = answer4.Value;
            command.Parameters.Add("@suitability", MySqlDbType.Int32).Value = answer5.Value;
            command.Parameters.Add("@conv_use", MySqlDbType.Int32).Value = answer6.Value;
            command.Parameters.Add("@reliability", MySqlDbType.Int32).Value = answer7.Value;
            command.Parameters.Add("@confidential", MySqlDbType.Int32).Value = answer8.Value;
            command.Parameters.Add("@reusability", MySqlDbType.Int32).Value = answer9.Value;
            command.Parameters.Add("@adaptability", MySqlDbType.Int32).Value = answer10.Value;
            db.open_connection();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Спасибо за оставленный отзыв!");
            else MessageBox.Show("При оставлении отзыва произошла ошибка");
            //command.ExecuteNonQuery();
            db.close_connection();

        }

        private void Send_Button_Click(object sender, EventArgs e)
        {
            write_down();
           /* DialogResult result = MessageBox.Show("Хотите увидеть общие оценки нашей программы?","",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Survey_Form form = new Survey_Form();
                form.Show();

            }*/
            this.Close();
        }
    }
}
