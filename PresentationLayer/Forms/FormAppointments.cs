using BusinessLayer;
using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PresentationLayer.Forms
{
    public partial class FormAppointments : Form
    {
        readonly KlijentBusiness klijentBusiness = new KlijentBusiness();
        readonly FrizerBusiness frizerBusiness = new FrizerBusiness();
        readonly VrstaBusiness vrstaBusiness = new VrstaBusiness();


        public FormAppointments()
        {
            InitializeComponent();

        }
        private void FormAppointments_Load_1(object sender, EventArgs e)
        {
            RefreshList();
        }
        private void RefreshList()
        {
            comboBoxFrizer.Items.Clear();
            foreach (Frizeri frizer in frizerBusiness.GetAllFrizeri())
            {
                comboBoxFrizer.Items.Add($"{frizer.ImeF} {frizer.PrezimeF} ");
            }
            comboBoxTretman.Items.Clear();
            foreach (Vrste vrsta in vrstaBusiness.GetAllVrste())
            {
                comboBoxTretman.Items.Add($"{vrsta.Naziv}");
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {

            Klijenti k = new Klijenti()
            {
                ImeK = textBoxIme.Text,
                PrezimeK = textBoxPrezime.Text,
                BrojTelefonaK = textBoxTelefon.Text,
                Email = textBoxEmail.Text,
                DatumTretmana = dateTimePicker1.Value

            };

            klijentBusiness.InsertKlijent(k);

            MessageBox.Show("Appointment has been successfully scheduled!");
            textBoxIme.Clear();
            textBoxPrezime.Clear();
            textBoxTelefon.Clear();
            textBoxEmail.Clear();
            comboBoxFrizer.SelectedItem = null;
            comboBoxTretman.SelectedItem = null;
            comboBoxTime.SelectedItem = null;
        }

        private void comboBoxFrizer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

