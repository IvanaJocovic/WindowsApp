namespace PresentationLayer
{
    partial class FormMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            panelMenu = new Panel();
            btnMessage = new FontAwesome.Sharp.IconButton();
            btnImpressions = new FontAwesome.Sharp.IconButton();
            btnAppointments = new FontAwesome.Sharp.IconButton();
            btnLookBook = new FontAwesome.Sharp.IconButton();
            btnDashboard = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            btnHome = new PictureBox();
            panelTitleBar = new Panel();
            btnMinimize = new FontAwesome.Sharp.IconButton();
            btnMaximize = new FontAwesome.Sharp.IconButton();
            btnExit = new FontAwesome.Sharp.IconButton();
            lblTitleChildForm = new Label();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            panelShadow = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panelDesktop = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(31, 30, 68);
            panelMenu.Controls.Add(btnMessage);
            panelMenu.Controls.Add(btnImpressions);
            panelMenu.Controls.Add(btnAppointments);
            panelMenu.Controls.Add(btnLookBook);
            panelMenu.Controls.Add(btnDashboard);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 900);
            panelMenu.TabIndex = 0;
            // 
            // btnMessage
            // 
            btnMessage.Dock = DockStyle.Top;
            btnMessage.FlatAppearance.BorderSize = 0;
            btnMessage.FlatStyle = FlatStyle.Flat;
            btnMessage.ForeColor = Color.Gainsboro;
            btnMessage.IconChar = FontAwesome.Sharp.IconChar.Message;
            btnMessage.IconColor = Color.Gainsboro;
            btnMessage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMessage.IconSize = 32;
            btnMessage.ImageAlign = ContentAlignment.MiddleLeft;
            btnMessage.Location = new Point(0, 380);
            btnMessage.Name = "btnMessage";
            btnMessage.Padding = new Padding(10, 0, 20, 0);
            btnMessage.Size = new Size(220, 60);
            btnMessage.TabIndex = 5;
            btnMessage.Text = "Message";
            btnMessage.TextAlign = ContentAlignment.MiddleLeft;
            btnMessage.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMessage.UseVisualStyleBackColor = true;
            btnMessage.Click += btnMessage_Click;
            // 
            // btnImpressions
            // 
            btnImpressions.Dock = DockStyle.Top;
            btnImpressions.FlatAppearance.BorderSize = 0;
            btnImpressions.FlatStyle = FlatStyle.Flat;
            btnImpressions.ForeColor = Color.Gainsboro;
            btnImpressions.IconChar = FontAwesome.Sharp.IconChar.Smile;
            btnImpressions.IconColor = Color.Gainsboro;
            btnImpressions.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnImpressions.IconSize = 32;
            btnImpressions.ImageAlign = ContentAlignment.MiddleLeft;
            btnImpressions.Location = new Point(0, 320);
            btnImpressions.Name = "btnImpressions";
            btnImpressions.Padding = new Padding(10, 0, 20, 0);
            btnImpressions.Size = new Size(220, 60);
            btnImpressions.TabIndex = 4;
            btnImpressions.Text = "Impressions";
            btnImpressions.TextAlign = ContentAlignment.MiddleLeft;
            btnImpressions.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnImpressions.UseVisualStyleBackColor = true;
            btnImpressions.Click += btnImpressions_Click_1;
            // 
            // btnAppointments
            // 
            btnAppointments.Dock = DockStyle.Top;
            btnAppointments.FlatAppearance.BorderSize = 0;
            btnAppointments.FlatStyle = FlatStyle.Flat;
            btnAppointments.ForeColor = Color.Gainsboro;
            btnAppointments.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            btnAppointments.IconColor = Color.Gainsboro;
            btnAppointments.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAppointments.IconSize = 32;
            btnAppointments.ImageAlign = ContentAlignment.MiddleLeft;
            btnAppointments.Location = new Point(0, 260);
            btnAppointments.Name = "btnAppointments";
            btnAppointments.Padding = new Padding(10, 0, 20, 0);
            btnAppointments.Size = new Size(220, 60);
            btnAppointments.TabIndex = 3;
            btnAppointments.Text = "Appointments";
            btnAppointments.TextAlign = ContentAlignment.MiddleLeft;
            btnAppointments.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAppointments.UseVisualStyleBackColor = true;
            btnAppointments.Click += btnAppointments_Click;
            // 
            // btnLookBook
            // 
            btnLookBook.Dock = DockStyle.Top;
            btnLookBook.FlatAppearance.BorderSize = 0;
            btnLookBook.FlatStyle = FlatStyle.Flat;
            btnLookBook.ForeColor = Color.Gainsboro;
            btnLookBook.IconChar = FontAwesome.Sharp.IconChar.Image;
            btnLookBook.IconColor = Color.Gainsboro;
            btnLookBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLookBook.IconSize = 32;
            btnLookBook.ImageAlign = ContentAlignment.MiddleLeft;
            btnLookBook.Location = new Point(0, 200);
            btnLookBook.Name = "btnLookBook";
            btnLookBook.Padding = new Padding(10, 0, 20, 0);
            btnLookBook.Size = new Size(220, 60);
            btnLookBook.TabIndex = 2;
            btnLookBook.Text = "LookBook";
            btnLookBook.TextAlign = ContentAlignment.MiddleLeft;
            btnLookBook.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLookBook.UseVisualStyleBackColor = true;
            btnLookBook.Click += btnLookBook_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.Gainsboro;
            btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            btnDashboard.IconColor = Color.Gainsboro;
            btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDashboard.IconSize = 32;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 140);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(10, 0, 20, 0);
            btnDashboard.Size = new Size(220, 60);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += Dashboard_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(btnHome);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 140);
            panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.Location = new Point(12, 12);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(194, 115);
            btnHome.SizeMode = PictureBoxSizeMode.Zoom;
            btnHome.TabIndex = 0;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(26, 25, 62);
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Controls.Add(btnMaximize);
            panelTitleBar.Controls.Add(btnExit);
            panelTitleBar.Controls.Add(lblTitleChildForm);
            panelTitleBar.Controls.Add(iconCurrentChildForm);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(980, 75);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.FromArgb(26, 25, 62);
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.ForeColor = Color.Gainsboro;
            btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimize.IconColor = Color.Gainsboro;
            btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimize.IconSize = 25;
            btnMinimize.Location = new Point(878, 3);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(29, 29);
            btnMinimize.TabIndex = 4;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.BackColor = Color.FromArgb(26, 25, 62);
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.ForeColor = Color.Transparent;
            btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            btnMaximize.IconColor = Color.Gainsboro;
            btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximize.IconSize = 25;
            btnMaximize.Location = new Point(913, 3);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(29, 29);
            btnMaximize.TabIndex = 3;
            btnMaximize.UseVisualStyleBackColor = false;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.FromArgb(26, 25, 62);
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.Transparent;
            btnExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            btnExit.IconColor = Color.Gainsboro;
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExit.IconSize = 25;
            btnExit.Location = new Point(948, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(29, 29);
            btnExit.TabIndex = 2;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblTitleChildForm
            // 
            lblTitleChildForm.AutoSize = true;
            lblTitleChildForm.ForeColor = Color.Gainsboro;
            lblTitleChildForm.Location = new Point(50, 30);
            lblTitleChildForm.Name = "lblTitleChildForm";
            lblTitleChildForm.Size = new Size(50, 20);
            lblTitleChildForm.TabIndex = 1;
            lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.BackColor = Color.FromArgb(26, 25, 62);
            iconCurrentChildForm.ForeColor = Color.MediumPurple;
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildForm.Location = new Point(18, 26);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(32, 32);
            iconCurrentChildForm.TabIndex = 0;
            iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            panelShadow.BackColor = Color.FromArgb(26, 24, 58);
            panelShadow.Dock = DockStyle.Top;
            panelShadow.Location = new Point(220, 75);
            panelShadow.Name = "panelShadow";
            panelShadow.Size = new Size(980, 9);
            panelShadow.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(26, 24, 58);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(220, 84);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(980, 9);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.FromArgb(34, 33, 74);
            panelDesktop.Controls.Add(pictureBox1);
            panelDesktop.Controls.Add(pictureBox5);
            panelDesktop.Controls.Add(pictureBox4);
            panelDesktop.Controls.Add(pictureBox3);
            panelDesktop.Controls.Add(pictureBox2);
            panelDesktop.Controls.Add(panel1);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.ForeColor = Color.FromArgb(34, 33, 74);
            panelDesktop.Location = new Point(220, 93);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(980, 807);
            panelDesktop.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(461, 550);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 245);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(461, 267);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(194, 280);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(673, 410);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(295, 385);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(673, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(295, 382);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(461, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(194, 263);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(440, 807);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(35, 307);
            label2.Name = "label2";
            label2.Size = new Size(371, 240);
            label2.TabIndex = 3;
            label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Imprint MT Shadow", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(35, 94);
            label1.Name = "label1";
            label1.Size = new Size(367, 120);
            label1.TabIndex = 2;
            label1.Text = "WELCOME TO THE \r\n    HAIR STUDIO \r\n         KETRIN\r\n";
            label1.Click += label1_Click;
            // 
            // FormMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 900);
            Controls.Add(panelDesktop);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panelShadow);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1200, 900);
            MinimumSize = new Size(1200, 900);
            Name = "FormMainMenu";
            Text = "FormMainMenu";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnMessage;
        private FontAwesome.Sharp.IconButton btnImpressions;
        private FontAwesome.Sharp.IconButton btnAppointments;
        private FontAwesome.Sharp.IconButton btnLookBook;
        private PictureBox btnHome;
        private Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Label lblTitleChildForm;
        private Panel panelShadow;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panelDesktop;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
    }
}