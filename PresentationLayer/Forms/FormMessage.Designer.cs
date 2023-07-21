namespace PresentationLayer.Forms
{
    partial class FormMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMessage));
            frizerBusinessBindingSource = new BindingSource(components);
            klijentBusinessBindingSource = new BindingSource(components);
            frizeriBindingSource = new BindingSource(components);
            klijentiBindingSource = new BindingSource(components);
            bindingSource1 = new BindingSource(components);
            pnlContainer = new Panel();
            outGoing1 = new MessageItems.OutGoing();
            incomming1 = new MessageItems.Incomming();
            panel3 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            textBoxMessage = new TextBox();
            panel2 = new Panel();
            lblStatus = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            panel1 = new Panel();
            label7 = new Label();
            panel8 = new Panel();
            pictureBox5 = new PictureBox();
            label6 = new Label();
            panel7 = new Panel();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            panel6 = new Panel();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            panel5 = new Panel();
            label3 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)frizerBusinessBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)klijentBusinessBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)frizeriBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)klijentiBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            pnlContainer.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // frizerBusinessBindingSource
            // 
            frizerBusinessBindingSource.DataSource = typeof(BusinessLayer.FrizerBusiness);
            // 
            // klijentBusinessBindingSource
            // 
            klijentBusinessBindingSource.DataSource = typeof(BusinessLayer.KlijentBusiness);
            // 
            // frizeriBindingSource
            // 
            frizeriBindingSource.DataSource = typeof(DataLayer.Models.Frizeri);
            // 
            // klijentiBindingSource
            // 
            klijentiBindingSource.DataSource = typeof(DataLayer.Models.Klijenti);
            // 
            // pnlContainer
            // 
            pnlContainer.Controls.Add(outGoing1);
            pnlContainer.Controls.Add(incomming1);
            pnlContainer.Controls.Add(panel3);
            pnlContainer.Controls.Add(panel2);
            pnlContainer.Dock = DockStyle.Left;
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(424, 900);
            pnlContainer.TabIndex = 0;
            // 
            // outGoing1
            // 
            outGoing1.BackColor = Color.FromArgb(114, 113, 149);
            outGoing1.Dock = DockStyle.Top;
            outGoing1.Location = new Point(0, 134);
            outGoing1.Message = "Hi!";
            outGoing1.Name = "outGoing1";
            outGoing1.Size = new Size(424, 48);
            outGoing1.TabIndex = 3;
            // 
            // incomming1
            // 
            incomming1.AutoScroll = true;
            incomming1.Avatar = (Image)resources.GetObject("incomming1.Avatar");
            incomming1.BackColor = Color.FromArgb(114, 113, 149);
            incomming1.Dock = DockStyle.Top;
            incomming1.Location = new Point(0, 80);
            incomming1.Message = "Hello. Do you need help?";
            incomming1.Name = "incomming1";
            incomming1.Size = new Size(424, 54);
            incomming1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(161, 160, 184);
            panel3.Controls.Add(iconButton1);
            panel3.Controls.Add(textBoxMessage);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 813);
            panel3.Name = "panel3";
            panel3.Size = new Size(424, 87);
            panel3.TabIndex = 1;
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            iconButton1.BackColor = Color.White;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            iconButton1.IconColor = Color.DimGray;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(381, 22);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(37, 42);
            iconButton1.TabIndex = 2;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // textBoxMessage
            // 
            textBoxMessage.Dock = DockStyle.Fill;
            textBoxMessage.Location = new Point(0, 0);
            textBoxMessage.Multiline = true;
            textBoxMessage.Name = "textBoxMessage";
            textBoxMessage.PlaceholderText = "Enter message";
            textBoxMessage.Size = new Size(424, 87);
            textBoxMessage.TabIndex = 0;
            textBoxMessage.TextChanged += textBox1_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(161, 160, 184);
            panel2.Controls.Add(lblStatus);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(424, 80);
            panel2.TabIndex = 0;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatus.ForeColor = Color.Black;
            lblStatus.Location = new Point(78, 42);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(60, 23);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Online";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(78, 18);
            label1.Name = "label1";
            label1.Size = new Size(132, 23);
            label1.TabIndex = 1;
            label1.Text = "Your hairdresser";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(192, 191, 207);
            panel4.Controls.Add(panel1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(424, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(767, 900);
            panel4.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(label7);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(-9, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 900);
            panel1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.LightSlateGray;
            label7.Location = new Point(363, 577);
            label7.Name = "label7";
            label7.Size = new Size(322, 112);
            label7.TabIndex = 4;
            label7.Text = "A world without communication is\r\n   meaninglass. So, you have to\r\n      message everyone now!\r\n ";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(114, 113, 149);
            panel8.Controls.Add(pictureBox5);
            panel8.Controls.Add(label6);
            panel8.Location = new Point(318, 447);
            panel8.Name = "panel8";
            panel8.Size = new Size(373, 72);
            panel8.TabIndex = 3;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(13, 13);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(60, 46);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(91, 22);
            label6.Name = "label6";
            label6.Size = new Size(138, 23);
            label6.TabIndex = 3;
            label6.Text = "ketrinstudio.com";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(114, 113, 149);
            panel7.Controls.Add(pictureBox4);
            panel7.Controls.Add(label5);
            panel7.Location = new Point(318, 358);
            panel7.Name = "panel7";
            panel7.Size = new Size(373, 72);
            panel7.TabIndex = 2;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(13, 13);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(60, 46);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(91, 22);
            label5.Name = "label5";
            label5.Size = new Size(101, 23);
            label5.TabIndex = 3;
            label5.Text = "0645896325";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(114, 113, 149);
            panel6.Controls.Add(pictureBox3);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(318, 270);
            panel6.Name = "panel6";
            panel6.Size = new Size(373, 72);
            panel6.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(13, 13);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(60, 47);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(91, 22);
            label4.Name = "label4";
            label4.Size = new Size(223, 23);
            label4.TabIndex = 3;
            label4.Text = "yourhairdresser@gmail.com";
            // 
            // panel5
            // 
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(pictureBox2);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(776, 248);
            panel5.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Unicode MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(447, 217);
            label3.Name = "label3";
            label3.Size = new Size(104, 18);
            label3.TabIndex = 3;
            label3.Text = "Belgrade, Serbia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(436, 194);
            label2.Name = "label2";
            label2.Size = new Size(132, 23);
            label2.TabIndex = 2;
            label2.Text = "Your hairdresser";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(409, 30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(184, 161);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // FormMessage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(114, 113, 149);
            ClientSize = new Size(1200, 900);
            Controls.Add(panel4);
            Controls.Add(pnlContainer);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1200, 900);
            Name = "FormMessage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Message";
            ((System.ComponentModel.ISupportInitialize)frizerBusinessBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)klijentBusinessBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)frizeriBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)klijentiBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            pnlContainer.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource frizerBusinessBindingSource;
        private BindingSource klijentBusinessBindingSource;
        private BindingSource frizeriBindingSource;
        private BindingSource klijentiBindingSource;
        private BindingSource bindingSource1;
        private Panel pnlContainer;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private TextBox textBoxMessage;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label lblStatus;
        private Label label1;
        private PictureBox pictureBox1;
        private MessageItems.Incomming incomming1;
        private MessageItems.OutGoing outGoing1;
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private Panel panel5;
        private PictureBox pictureBox2;
        private Panel panel6;
        private Label label3;
        private Label label2;
        private Label label4;
        private PictureBox pictureBox3;
        private Panel panel7;
        private PictureBox pictureBox4;
        private Label label5;
        private Panel panel8;
        private PictureBox pictureBox5;
        private Label label6;
        private Label label7;
    }
}