namespace kursgost
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Contact = new System.Windows.Forms.Button();
            this.bontCalendar = new System.Windows.Forms.Button();
            this.botnAnalitycs = new System.Windows.Forms.Button();
            this.botnDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Setings = new System.Windows.Forms.Button();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.Setings);
            this.panel1.Controls.Add(this.Contact);
            this.panel1.Controls.Add(this.bontCalendar);
            this.panel1.Controls.Add(this.botnAnalitycs);
            this.panel1.Controls.Add(this.botnDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 577);
            this.panel1.TabIndex = 0;
            // 
            // Contact
            // 
            this.Contact.FlatAppearance.BorderSize = 0;
            this.Contact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Contact.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact.ForeColor = System.Drawing.Color.White;
            this.Contact.Location = new System.Drawing.Point(0, 316);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(186, 34);
            this.Contact.TabIndex = 4;
            this.Contact.Text = "Contact Us";
            this.Contact.UseVisualStyleBackColor = true;
            this.Contact.Click += new System.EventHandler(this.Contact_Click);
            this.Contact.Leave += new System.EventHandler(this.Contact_Leave);
            // 
            // bontCalendar
            // 
            this.bontCalendar.FlatAppearance.BorderSize = 0;
            this.bontCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bontCalendar.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bontCalendar.ForeColor = System.Drawing.Color.White;
            this.bontCalendar.Location = new System.Drawing.Point(0, 276);
            this.bontCalendar.Name = "bontCalendar";
            this.bontCalendar.Size = new System.Drawing.Size(186, 34);
            this.bontCalendar.TabIndex = 3;
            this.bontCalendar.Text = "Calendar";
            this.bontCalendar.UseVisualStyleBackColor = true;
            this.bontCalendar.Click += new System.EventHandler(this.bontCalendar_Click);
            this.bontCalendar.Leave += new System.EventHandler(this.bontCalendar_Leave);
            // 
            // botnAnalitycs
            // 
            this.botnAnalitycs.FlatAppearance.BorderSize = 0;
            this.botnAnalitycs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botnAnalitycs.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botnAnalitycs.ForeColor = System.Drawing.Color.White;
            this.botnAnalitycs.Location = new System.Drawing.Point(0, 236);
            this.botnAnalitycs.Name = "botnAnalitycs";
            this.botnAnalitycs.Size = new System.Drawing.Size(186, 34);
            this.botnAnalitycs.TabIndex = 2;
            this.botnAnalitycs.Text = "Analytics";
            this.botnAnalitycs.UseVisualStyleBackColor = true;
            this.botnAnalitycs.Click += new System.EventHandler(this.botnAnalitycs_Click);
            this.botnAnalitycs.Leave += new System.EventHandler(this.botnAnalitycs_Leave);
            // 
            // botnDashboard
            // 
            this.botnDashboard.FlatAppearance.BorderSize = 0;
            this.botnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botnDashboard.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botnDashboard.ForeColor = System.Drawing.Color.White;
            this.botnDashboard.Location = new System.Drawing.Point(0, 196);
            this.botnDashboard.Name = "botnDashboard";
            this.botnDashboard.Size = new System.Drawing.Size(186, 34);
            this.botnDashboard.TabIndex = 1;
            this.botnDashboard.Text = "Dashboard";
            this.botnDashboard.UseVisualStyleBackColor = true;
            this.botnDashboard.Click += new System.EventHandler(this.botnDashboard_Click);
            this.botnDashboard.Leave += new System.EventHandler(this.botnDashboard_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 190);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(59, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "online";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::kursgost.Properties.Resources.@__G_O_R____4__removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(45, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Setings
            // 
            this.Setings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Setings.FlatAppearance.BorderSize = 0;
            this.Setings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Setings.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Setings.ForeColor = System.Drawing.Color.White;
            this.Setings.Location = new System.Drawing.Point(0, 539);
            this.Setings.Name = "Setings";
            this.Setings.Size = new System.Drawing.Size(186, 38);
            this.Setings.TabIndex = 5;
            this.Setings.Text = "Setings";
            this.Setings.UseVisualStyleBackColor = true;
            this.Setings.Click += new System.EventHandler(this.Setings_Click);
            this.Setings.Leave += new System.EventHandler(this.Setings_Leave);
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 193);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 100);
            this.pnlNav.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button botnDashboard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Contact;
        private System.Windows.Forms.Button bontCalendar;
        private System.Windows.Forms.Button botnAnalitycs;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button Setings;
    }
}

