using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak132021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnUnesi_Click(object sender, EventArgs e)
        {
            try
            {
                Osoba osoba = new Osoba();
                osoba.setIme(txtIme.Text);
                osoba.setPrezime(txtPrezime.Text);
                osoba.setGodRod(Convert.ToInt32(txtGod.Text));
                osoba.setKg(Convert.ToInt32(txtKg.Text));

                txtIme.Clear();
                txtPrezime.Clear();
                txtGod.Clear();
                txtKg.Clear();
            }

            catch (Exception greska)
            {
                MessageBox.Show("Pogresan unos\r\n" + greska.Message,
                                "Greska!", MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
            }
        }
    }
}
