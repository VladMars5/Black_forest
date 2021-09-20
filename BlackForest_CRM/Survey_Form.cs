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
    public partial class Survey_Form : Form
    {
        public Survey_Form()
        {
            InitializeComponent();
        }

        Point lastpoint;

        private void Survey_Form_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void Survey_Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void Cancel_buttton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void write_down()
        {
            Database db = new Database();
            MySqlCommand command = new MySqlCommand(@"SELECT * FROM `quality` ()", db.get_connection());




        }


    }
}
