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
using Excel = Microsoft.Office.Interop.Excel;
using System.Collections;

namespace BlackForest_CRM
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        Log_In_Form frm = new Log_In_Form();
        New_User_From frm1 = new New_User_From();
        Database db = new Database();
        DataTable table = new DataTable();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        Panel table_info = new Panel();
        Button create_timetable_button = new Button();
        bool flag = false, open_flag = false, tableExist = false;
        int cost = 0, p1 = 700;
        string namecreatetable = "";


        System.Windows.Forms.DataGridViewCellStyle style = new DataGridViewCellStyle
        {
            BackColor = Color.FromArgb(192,255,192),
            Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
            ForeColor = System.Drawing.Color.Black,
            
        };
       // style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))),
         //                   style.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
         //                   style.ForeColor = System.Drawing.Color.Black,
        //private object dataGridViewCellStyle;

        private void Main_Form_Load(object sender, EventArgs e)
        {
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cRM_DBDataSet.TimeTable". При необходимости она может быть перемещена или удалена.
            this.timeTableTableAdapter.Fill(this.cRM_DBDataSet.TimeTable);
            this.Visible = false;
            frm.Show();
           
            /*MySqlCommand command_checkadmin = new MySqlCommand("SELECT * FROM `USERS` WHERE `login` = @ul", db.get_connection());
             command_checkadmin.Parameters.Add("@ul", MySqlDbType.VarChar).Value = "admin";
             if(Main_Form.ActiveForm.Enabled)
                 администрированиеToolStripMenuItem.Enabled = true;*/
            // timetable_table1.ClearSelection();


            void create(Panel table)
            {
                table_info = new Panel();
                if (table.Name == "Table_3" || table.Name == "Table_6" || table.Name == "Table_9")
                { table_info.Location = new Point(table.Location.X - (table.Width + 6), table.Location.Y); }
                else if (table.Name == "Table_10" || table.Name == "Table_11")
                { table_info.Location = new Point(table.Location.X, table.Location.Y - (table.Height + 6)); }
                else if (table.Name == "Table_12")
                { table_info.Location = new Point(table.Location.X - (table.Width + 6), table.Location.Y - (table.Height + 6)); }
                else { table_info.Location = table.Location; }
                table_info.Size = new Size(456, 275);
                table_info.BackColor = Color.FromArgb(192, 255, 192);
                Controls.Add(table_info);
                

                Button create_timetable_button = new System.Windows.Forms.Button
                {
                    BackColor = System.Drawing.Color.Green,
                    Cursor = System.Windows.Forms.Cursors.Hand,
                    FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                    Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                    ForeColor = System.Drawing.Color.White,
                    Size = new System.Drawing.Size(220, 40),
                    Location = new Point((table_info.Width - table.Width), (table_info.Height - (table.Height / 3))),
                    Anchor = (AnchorStyles.Bottom | AnchorStyles.Right),
                    Name = "create_timetable_button",
                    Text = "Отрыть стол",
                    UseVisualStyleBackColor = false,

                };

                create_timetable_button.MouseClick += (ss, aa) =>
                {
                    open_flag = !open_flag;
                    table_info.Refresh();
                    if (!open_flag)
                    {
                        create_timetable_button.BackColor = System.Drawing.Color.Green;
                        create_timetable_button.Text = "Открыть стол"; Status_1.Text = @"Сейчас: Пуст";
                    }
                    else
                    {
                        create_timetable_button.BackColor = System.Drawing.Color.Red;
                        create_timetable_button.Text = "Закрыть стол"; Status_1.Text = @"Сейчас: Занято";
                    }
                };

                PictureBox new_time = new PictureBox
                {
                    //Text = "Заказ:",
                    Image = BlackForest_CRM.Properties.Resources.unnamed,
                    Size = new System.Drawing.Size(35, 35),
                    Location = new Point(10, (table_info.Height - (table.Height / 3))),
                    SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom,
                    // Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                };
                int c;
                DataGridView full_timetable = new DataGridView
                {
                    AllowUserToAddRows = false,
                    AllowUserToDeleteRows = false,
                    AllowUserToResizeColumns = false,
                    AllowUserToResizeRows = false,
                    ColumnHeadersVisible = false,
                    RowHeadersVisible = false,
                    BackgroundColor = System.Drawing.Color.FromArgb(192, 255, 192),
                    Size = new System.Drawing.Size(225, 225),
                    Location = new Point(5, 5),
                    BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))),
                    GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))),
                    Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    ForeColor = System.Drawing.Color.Black,
                    DataSource = timeTableBindingSource2,
                    AlternatingRowsDefaultCellStyle = style,
                    DefaultCellStyle = style,
                };

                Label check_order = new Label
                {
                    Text = "Заказ:",
                    AutoSize = true,
                    Location = new Point((table_info.Width - table.Width), 5),
                    Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                };
                Label check = new Label
                {
                    Text = $"позиция 1:                    {p1}",
                    Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    ForeColor = System.Drawing.Color.Black,
                    Location = new Point(table_info.Width - table.Width, 25),
                    AutoSize = true,
                    AutoEllipsis = true,
                };
                Panel dash = new Panel
                {
                    Size = new Size(220, 1),
                    Location = new Point(232, 190),
                    BackColor = Color.Black,
                };
                Label result = new Label
                {
                    Text = $"Итог:                               {p1}",
                    Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    ForeColor = System.Drawing.Color.Black,
                    Location = new Point(table_info.Width - table.Width, 195),
                    AutoSize = true,
                    AutoEllipsis = true,
                };


                table_info.Controls.Add(create_timetable_button);
                table_info.Controls.Add(check_order);
                table_info.Controls.Add(new_time);
                table_info.Controls.Add(full_timetable);
                table_info.Controls.Add(dash);
                table_info.Controls.Add(check);
                table_info.Controls.Add(result);
                table_info.BringToFront();
                create_timetable_button.BringToFront();
                flag = true;
            }

            void ToExcel(DataTable dt1)
            {
                try
                {
                    Excel.Application EoXL;
                    Excel._Workbook EoWB;
                    Excel._Worksheet EoSheet;
                    Excel.Range excelRange;
                    EoXL = new Excel.Application();
                    EoXL.Visible = false;
                    EoWB = EoXL.Workbooks.Add(Type.Missing);

                    int TabRows = 1;

                    EoSheet = (Excel.Worksheet)EoWB.Worksheets.get_Item(1);//ссылка на лист excel
                    EoSheet.Name = "Отчет о кодах возвратных накладных";
                    EoSheet.PageSetup.Orientation = Excel.XlPageOrientation.xlLandscape;

                    int row = dt1.Rows.Count;
                    int col = dt1.Columns.Count;


                    EoSheet.Cells[1, 1] = "Префиксы возвратных накладных и счетов фактур подразделений";
                    EoSheet.Cells[1, 1].VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                    EoSheet.Cells[1, 1].Font.Bold = true;
                    EoSheet.Cells[1, 1].Font.Size = 16;



                    // передаем первую таблицу, заполняем ее в памяти и передаем целиком
                    object[,] dataExport = new object[row, col];

                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 0; j < col; j++)
                        {
                            dataExport[i, j] = dt1.Rows[i][j];
                        }

                    }


                    excelRange = EoSheet.Range[EoSheet.Cells[2 + TabRows, 1], EoSheet.Cells[row + 1 + TabRows, col]];
                    excelRange.set_Value(Excel.XlRangeValueDataType.xlRangeValueDefault, dataExport);
                    excelRange.Borders.ColorIndex = 0;

                    //этот кусок в качестве примера указания типа данных в ячейках
                    // excelRange = EoSheet.Range[EoSheet.Cells[2 + TabRows, 8], EoSheet.Cells[row + 1 + TabRows, 10]];
                    // excelRange.NumberFormat = "#,##0.00";

                    // формируем заголовок
                    ArrayList displayColumnExsel = new ArrayList();


                    foreach (DataColumn c in dt1.Columns)
                    {

                        displayColumnExsel.Add(c.ColumnName);
                    }

                    object[] dataExportH = new object[col];
                    for (int i = 0; i < col; i++)
                        dataExportH[i] = displayColumnExsel[i];

                    excelRange = EoSheet.Range[EoSheet.Cells[1 + TabRows, 1], EoSheet.Cells[1 + TabRows, col]];
                    excelRange.set_Value(Excel.XlRangeValueDataType.xlRangeValueDefault, dataExportH);
                    excelRange.Font.Bold = true;
                    excelRange.WrapText = true;
                    excelRange.Borders.ColorIndex = 0;
                    excelRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                    excelRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;


                    EoXL.Visible = true;
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message, "Ошибка метода переноса таблиц", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

            foreach (Panel table in Controls.OfType<Panel>())
            {
                // bool busy_flag = false;
                
                foreach (DataGridView dgv in table.Controls.OfType<DataGridView>()) { dgv.ClearSelection(); }

                table.MouseClick += (s, a) => 
                {

                    for (int i = 1; i <= Controls.OfType<Panel>().Count() + 1; i++)
                    {
                        if (namecreatetable.Contains(i.ToString())) { tableExist = true; }
                        else { tableExist = false; }
                    }

                    if (!tableExist && !flag)
                    {
                        create(table);
                        namecreatetable += table.Name;
                    }
                    else if (tableExist && !flag) { table_info.Visible = true; flag = true; }
                    else { table_info.Visible = false; flag = false; }
                   
                };
                
            }

            /* MySqlCommand create_timetable = new MySqlCommand(@"insert into `resev` (`date`, `table`, `time`, `card_num`, `name`)
                                                       VALUES (@date, @ttable,@time,@card_num, @name)", db.get_connection());
             create_timetable.Parameters.Add("@date", MySqlDbType.Date).Value = DateTime.UtcNow.Date;*/
            MySqlCommand timetable = new MySqlCommand(@"select * from `reserv` where `date` = @date", db.get_connection());
            timetable.Parameters.Add("@date", MySqlDbType.Date).Value = DateTime.UtcNow.Date;
            adapter.SelectCommand = timetable;
            adapter.Fill(table);
            if(table.Rows.Count > 0)
            {
               //timetable_label1.Text = 
            }


        }

        static void create_report(string[] args)
        {
            // Создаём экземпляр нашего приложения
            Excel.Application excelApp = new Excel.Application();
            // Создаём экземпляр рабочий книги Excel
            Excel.Workbook workBook;
            // Создаём экземпляр листа Excel
            Excel.Worksheet workSheet;

            workBook = excelApp.Workbooks.Add();
            workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);

            // Заполняем первую строку числами от 1 до 10
            for (int j = 1; j <= 10; j++)
            {
                workSheet.Cells[1, j] = j;
            }
            // Вычисляем сумму этих чисел
            Excel.Range rng = workSheet.Range["A2"];
            rng.Formula = "=SUM(A1:L1)";
            rng.FormulaHidden = false;

            // Выделяем границы у этой ячейки
            Excel.Borders border = rng.Borders;
            border.LineStyle = Excel.XlLineStyle.xlContinuous;

            // Строим круговую диаграмму
            Excel.ChartObjects chartObjs = (Excel.ChartObjects)workSheet.ChartObjects();
            Excel.ChartObject chartObj = chartObjs.Add(5, 50, 300, 300);
            Excel.Chart xlChart = chartObj.Chart;
            Excel.Range rng2 = workSheet.Range["A1:L1"];
            // Устанавливаем тип диаграммы
            xlChart.ChartType = Excel.XlChartType.xlPie;
            // Устанавливаем источник данных (значения от 1 до 10)
            xlChart.SetSourceData(rng2);

            // Открываем созданный excel-файл
            excelApp.Visible = true;
            excelApp.UserControl = true;
        }

        private void выйтиИзСистемыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           // create_report(["sdvf","fwef"s]);
            Application.Restart();

            //Log_In_Form frm = new Log_In_Form();
            //this.Visible = false;
            //frm.Show();
        }

        private void создатьОтчетToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void добавитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm1.Show();
        }

       

        private void опросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estimate_Form form = new Estimate_Form();
            form.Show();
        }

    }
}
/*  Button Create_Button = new System.Windows.Forms.Button
           {
               BackColor = System.Drawing.Color.Green,
               Cursor = System.Windows.Forms.Cursors.Hand,
               FlatStyle = System.Windows.Forms.FlatStyle.Flat,
               Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
               ForeColor = System.Drawing.Color.White,
               Location = new System.Drawing.Point(500,200),
               Name = "Create_Button",
               Size = new System.Drawing.Size(200, 35),
               TabIndex = 9,
               TabStop = false,
               Text = "Sign In",
               UseVisualStyleBackColor = false,
               //Click += new System.EventHandler(this.Create_Button_Click);
           };*/
