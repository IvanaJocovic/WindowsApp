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
    public partial class OutGoing : UserControl
    {
        public OutGoing()
        {
            InitializeComponent();
        }

        

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

            label1.Height = Utils.GetTextHeight(label1) + 10;


        }


        private void Incoming_Resize(object sender, EventArgs e)
        {
            AdjustHeight();
        }
    }
}
