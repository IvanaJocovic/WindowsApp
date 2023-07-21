using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.MessageItems
{
    public partial class Incomming : UserControl
    {
        public Incomming()
        {
            InitializeComponent();
        }

        private string message;

        public string Message
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
                AdjustHeight();
            }
        }


        private void AdjustHeight()
        {
            pictureBoxAvatar.Location = new Point(3, 3);
            label1.Height = Utils.GetTextHeight(label1) + 10;;
        }

        public Image Avatar { get => pictureBoxAvatar.Image; set => pictureBoxAvatar.Image = value; }

        private void Incoming_Resize(object sender, EventArgs e)
        {
            AdjustHeight();
        }
    }
}
