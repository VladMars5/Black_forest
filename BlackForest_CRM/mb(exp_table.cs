using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace BlackForest_CRM
{
    class exp_table
    {
        /*Panel table_info;
        void create_exp_table(Panel table)
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
        } */
    }
}
       