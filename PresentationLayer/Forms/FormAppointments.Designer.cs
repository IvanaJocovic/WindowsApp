namespace PresentationLayer.Forms
{
    partial class FormAppointments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            panel1 = new Panel();
            label1 = new Label();
            frizeriBindingSource4 = new BindingSource(components);
            frizerRepositoryBindingSource2 = new BindingSource(components);
            frizeriBindingSource3 = new BindingSource(components);
            frizerRepositoryBindingSource1 = new BindingSource(components);
            frizeriBindingSource1 = new BindingSource(components);
            frizerBusinessBindingSource = new BindingSource(components);
            frizerRepositoryBindingSource = new BindingSource(components);
            frizeriBindingSource = new BindingSource(components);
            frizeriBindingSource2 = new BindingSource(components);
            klijentiBindingSource = new BindingSource(components);
            textBoxIme = new TextBox();
            textBoxPrezime = new TextBox();
            button1 = new Button();
            textBoxEmail = new TextBox();
            textBoxTelefon = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            comboBoxFrizer = new ComboBox();
            panel6 = new Panel();
            panel7 = new Panel();
            comboBoxTretman = new ComboBox();
            comboBoxTime = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)frizeriBindingSource4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)frizerRepositoryBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)frizeriBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)frizerRepositoryBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)frizeriBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)frizerBusinessBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)frizerRepositoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)frizeriBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)frizeriBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)klijentiBindingSource).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // iconDropDownButton1
            // 
            iconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconDropDownButton1.IconColor = Color.Black;
            iconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconDropDownButton1.Name = "iconDropDownButton1";
            iconDropDownButton1.Size = new Size(23, 23);
            iconDropDownButton1.Text = "iconDropDownButton1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(219, 160, 185);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1104, 74);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(335, 20);
            label1.Name = "label1";
            label1.Size = new Size(308, 38);
            label1.TabIndex = 0;
            label1.Text = "Make An Appointment";
            // 
            // frizeriBindingSource4
            // 
            frizeriBindingSource4.DataSource = typeof(DataLayer.Models.Frizeri);
            // 
            // frizerRepositoryBindingSource2
            // 
            frizerRepositoryBindingSource2.DataSource = typeof(DataLayer.FrizerRepository);
            // 
            // frizeriBindingSource3
            // 
            frizeriBindingSource3.DataSource = typeof(DataLayer.Models.Frizeri);
            // 
            // frizerRepositoryBindingSource1
            // 
            frizerRepositoryBindingSource1.DataSource = typeof(DataLayer.FrizerRepository);
            // 
            // frizeriBindingSource1
            // 
            frizeriBindingSource1.DataSource = typeof(DataLayer.Models.Frizeri);
            // 
            // frizerBusinessBindingSource
            // 
            frizerBusinessBindingSource.DataSource = typeof(BusinessLayer.FrizerBusiness);
            // 
            // frizerRepositoryBindingSource
            // 
            frizerRepositoryBindingSource.DataSource = typeof(DataLayer.FrizerRepository);
            // 
            // frizeriBindingSource
            // 
            frizeriBindingSource.DataSource = typeof(DataLayer.Models.Frizeri);
            // 
            // frizeriBindingSource2
            // 
            frizeriBindingSource2.DataSource = typeof(DataLayer.Models.Frizeri);
            // 
            // klijentiBindingSource
            // 
            klijentiBindingSource.DataSource = typeof(DataLayer.Models.Klijenti);
            // 
            // textBoxIme
            // 
            textBoxIme.Location = new Point(26, 19);
            textBoxIme.Name = "textBoxIme";
            textBoxIme.PlaceholderText = "First Name";
            textBoxIme.Size = new Size(167, 27);
            textBoxIme.TabIndex = 1;
            // 
            // textBoxPrezime
            // 
            textBoxPrezime.Location = new Point(28, 17);
            textBoxPrezime.Name = "textBoxPrezime";
            textBoxPrezime.PlaceholderText = "Last Name";
            textBoxPrezime.Size = new Size(167, 27);
            textBoxPrezime.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(219, 160, 185);
            button1.FlatAppearance.BorderColor = Color.FromArgb(166, 58, 103);
            button1.FlatAppearance.BorderSize = 4;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(64, 64, 64);
            button1.Location = new Point(429, 563);
            button1.Name = "button1";
            button1.Size = new Size(157, 62);
            button1.TabIndex = 4;
            button1.Text = "Schedule";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(28, 18);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "Email";
            textBoxEmail.Size = new Size(167, 27);
            textBoxEmail.TabIndex = 5;
            // 
            // textBoxTelefon
            // 
            textBoxTelefon.Location = new Point(26, 18);
            textBoxTelefon.Name = "textBoxTelefon";
            textBoxTelefon.PlaceholderText = "Phone Number";
            textBoxTelefon.Size = new Size(167, 27);
            textBoxTelefon.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(379, 508);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(219, 160, 185);
            panel2.Controls.Add(textBoxIme);
            panel2.Location = new Point(241, 97);
            panel2.Name = "panel2";
            panel2.Size = new Size(219, 64);
            panel2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(219, 160, 185);
            panel3.Controls.Add(textBoxPrezime);
            panel3.Location = new Point(518, 97);
            panel3.Name = "panel3";
            panel3.Size = new Size(219, 64);
            panel3.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(219, 160, 185);
            panel4.Controls.Add(textBoxTelefon);
            panel4.Location = new Point(241, 192);
            panel4.Name = "panel4";
            panel4.Size = new Size(219, 62);
            panel4.TabIndex = 10;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(219, 160, 185);
            panel5.Controls.Add(textBoxEmail);
            panel5.Location = new Point(518, 192);
            panel5.Name = "panel5";
            panel5.Size = new Size(219, 62);
            panel5.TabIndex = 11;
            // 
            // comboBoxFrizer
            // 
            comboBoxFrizer.FormattingEnabled = true;
            comboBoxFrizer.Location = new Point(28, 18);
            comboBoxFrizer.Name = "comboBoxFrizer";
            comboBoxFrizer.Size = new Size(165, 28);
            comboBoxFrizer.TabIndex = 12;
            comboBoxFrizer.SelectedIndexChanged += comboBoxFrizer_SelectedIndexChanged;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(219, 160, 185);
            panel6.Controls.Add(comboBoxFrizer);
            panel6.Location = new Point(241, 337);
            panel6.Name = "panel6";
            panel6.Size = new Size(219, 62);
            panel6.TabIndex = 13;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(219, 160, 185);
            panel7.Controls.Add(comboBoxTretman);
            panel7.Location = new Point(518, 337);
            panel7.Name = "panel7";
            panel7.Size = new Size(219, 62);
            panel7.TabIndex = 14;
            // 
            // comboBoxTretman
            // 
            comboBoxTretman.FormattingEnabled = true;
            comboBoxTretman.Location = new Point(28, 18);
            comboBoxTretman.Name = "comboBoxTretman";
            comboBoxTretman.Size = new Size(165, 28);
            comboBoxTretman.TabIndex = 12;
            // 
            // comboBoxTime
            // 
            comboBoxTime.FormattingEnabled = true;
            comboBoxTime.Items.AddRange(new object[] { "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00" });
            comboBoxTime.Location = new Point(379, 452);
            comboBoxTime.Name = "comboBoxTime";
            comboBoxTime.Size = new Size(250, 28);
            comboBoxTime.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(166, 58, 103);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Bradley Hand ITC", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(255, 224, 192);
            textBox1.Location = new Point(335, 642);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(378, 161);
            textBox1.TabIndex = 16;
            textBox1.Text = "      If you are unable to keep\r\nyour appointment, please contact\r\n      us as soon as possible.\r\n              555.555.5555";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(166, 58, 103);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Gainsboro;
            textBox2.Location = new Point(258, 304);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(168, 20);
            textBox2.TabIndex = 17;
            textBox2.Text = "Choose your hairdresser";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(166, 58, 103);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.ForeColor = Color.Gainsboro;
            textBox3.Location = new Point(546, 304);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(159, 20);
            textBox3.TabIndex = 18;
            textBox3.Text = "Choose your hairstyle";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(166, 58, 103);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.ForeColor = Color.Gainsboro;
            textBox4.Location = new Point(389, 426);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(249, 20);
            textBox4.TabIndex = 19;
            textBox4.Text = "Choose time of your appointment";
            // 
            // FormAppointments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(166, 58, 103);
            ClientSize = new Size(1104, 815);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBoxTime);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAppointments";
            Text = "Appointments";
            WindowState = FormWindowState.Maximized;
            Load += FormAppointments_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)frizeriBindingSource4).EndInit();
            ((System.ComponentModel.ISupportInitialize)frizerRepositoryBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)frizeriBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)frizerRepositoryBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)frizeriBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)frizerBusinessBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)frizerRepositoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)frizeriBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)frizeriBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)klijentiBindingSource).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
        private Panel panel1;
        private Label label1;
        private BindingSource frizerBusinessBindingSource;
        private BindingSource frizerRepositoryBindingSource;
        private BindingSource frizeriBindingSource;
        private BindingSource frizeriBindingSource1;
        private BindingSource frizerRepositoryBindingSource1;
        private BindingSource frizeriBindingSource2;
        private BindingSource frizeriBindingSource3;
        private BindingSource frizerRepositoryBindingSource2;
        private BindingSource frizeriBindingSource4;
        private BindingSource klijentiBindingSource;
        private TextBox textBoxIme;
        private TextBox textBoxPrezime;
        private Button button1;
        private TextBox textBoxEmail;
        private TextBox textBoxTelefon;
        private DateTimePicker dateTimePicker1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private ComboBox comboBoxFrizer;
        private Panel panel6;
        private Panel panel7;
        private ComboBox comboBoxTretman;
        private ComboBox comboBoxTime;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}