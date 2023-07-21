using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
    public partial class FormMessage : Form
    {
        public FormMessage()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Send();
        }

        void Send()
        {

            AddOutgoing(textBoxMessage.Text);
            textBoxMessage.Text = string.Empty;

            //get random response
            lblStatus.Text = "Typing...";
            timer1.Start();

        }

        void AddIncomming(string message)
        {
            var bubble = new MessageItems.Incomming();
            pnlContainer.Controls.Add(bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
            bubble.Message = message;
        }

        void AddOutgoing(string message)
        {
            var bubble = new MessageItems.OutGoing();
            pnlContainer.Controls.Add(bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
            bubble.Message = message;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            lblStatus.Text = "Online";
            //sample response
            AddIncomming("Sorry I don't know the answer.");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
