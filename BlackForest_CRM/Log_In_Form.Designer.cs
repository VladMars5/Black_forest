namespace BlackForest_CRM
{
    partial class Log_In_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log_In_Form));
            this.Log_Name = new System.Windows.Forms.TextBox();
            this.Log_Password = new System.Windows.Forms.TextBox();
            this.Log_logInButton = new System.Windows.Forms.Button();
            this.Log_CancelLogButton = new System.Windows.Forms.Button();
            this.Log_logoBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Log_logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Log_Name
            // 
            this.Log_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(41)))), ((int)(((byte)(15)))));
            this.Log_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Log_Name.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_Name.ForeColor = System.Drawing.Color.White;
            this.Log_Name.HideSelection = false;
            this.Log_Name.Location = new System.Drawing.Point(76, 178);
            this.Log_Name.Margin = new System.Windows.Forms.Padding(0);
            this.Log_Name.Name = "Log_Name";
            this.Log_Name.Size = new System.Drawing.Size(203, 15);
            this.Log_Name.TabIndex = 1;
            this.Log_Name.TabStop = false;
            this.Log_Name.Enter += new System.EventHandler(this.Log_Name_Enter);
            this.Log_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Log_CancelLogButton_KeyDown);
            this.Log_Name.Leave += new System.EventHandler(this.Log_Name_Leave);
            // 
            // Log_Password
            // 
            this.Log_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(41)))), ((int)(((byte)(15)))));
            this.Log_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Log_Password.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Log_Password.ForeColor = System.Drawing.Color.White;
            this.Log_Password.HideSelection = false;
            this.Log_Password.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Log_Password.Location = new System.Drawing.Point(76, 223);
            this.Log_Password.Name = "Log_Password";
            this.Log_Password.Size = new System.Drawing.Size(203, 15);
            this.Log_Password.TabIndex = 2;
            this.Log_Password.TabStop = false;
            this.Log_Password.Enter += new System.EventHandler(this.Log_Password_Enter);
            this.Log_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Log_CancelLogButton_KeyDown);
            this.Log_Password.Leave += new System.EventHandler(this.Log_Password_Leave);
            // 
            // Log_logInButton
            // 
            this.Log_logInButton.BackColor = System.Drawing.Color.Green;
            this.Log_logInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Log_logInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Log_logInButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Log_logInButton.ForeColor = System.Drawing.Color.White;
            this.Log_logInButton.Location = new System.Drawing.Point(76, 267);
            this.Log_logInButton.Name = "Log_logInButton";
            this.Log_logInButton.Size = new System.Drawing.Size(200, 35);
            this.Log_logInButton.TabIndex = 2;
            this.Log_logInButton.TabStop = false;
            this.Log_logInButton.Text = "Log In";
            this.Log_logInButton.UseVisualStyleBackColor = false;
            this.Log_logInButton.Click += new System.EventHandler(this.Log_logInButton_Click);
            // 
            // Log_CancelLogButton
            // 
            this.Log_CancelLogButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Log_CancelLogButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Log_CancelLogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Log_CancelLogButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Log_CancelLogButton.ForeColor = System.Drawing.Color.White;
            this.Log_CancelLogButton.Location = new System.Drawing.Point(76, 317);
            this.Log_CancelLogButton.Name = "Log_CancelLogButton";
            this.Log_CancelLogButton.Size = new System.Drawing.Size(200, 35);
            this.Log_CancelLogButton.TabIndex = 3;
            this.Log_CancelLogButton.TabStop = false;
            this.Log_CancelLogButton.Text = "Cancel";
            this.Log_CancelLogButton.UseVisualStyleBackColor = false;
            this.Log_CancelLogButton.Click += new System.EventHandler(this.Log_CancelLogButton_Click);
            // 
            // Log_logoBox
            // 
            this.Log_logoBox.BackgroundImage = global::BlackForest_CRM.Properties.Resources.logo;
            this.Log_logoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Log_logoBox.Location = new System.Drawing.Point(12, 48);
            this.Log_logoBox.Name = "Log_logoBox";
            this.Log_logoBox.Size = new System.Drawing.Size(330, 45);
            this.Log_logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Log_logoBox.TabIndex = 4;
            this.Log_logoBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(76, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(76, 240);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 6;
            // 
            // Log_In_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(41)))), ((int)(((byte)(15)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(350, 400);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Log_logoBox);
            this.Controls.Add(this.Log_CancelLogButton);
            this.Controls.Add(this.Log_logInButton);
            this.Controls.Add(this.Log_Password);
            this.Controls.Add(this.Log_Name);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Log_In_Form";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRM BlackForest";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Log_CancelLogButton_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Log_In_Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Log_In_Form_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.Log_logoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Log_Password;
        private System.Windows.Forms.Button Log_logInButton;
        private System.Windows.Forms.Button Log_CancelLogButton;
        private System.Windows.Forms.TextBox Log_Name;
        private System.Windows.Forms.PictureBox Log_logoBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

