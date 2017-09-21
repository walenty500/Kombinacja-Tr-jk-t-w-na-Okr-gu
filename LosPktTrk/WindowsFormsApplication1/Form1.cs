using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bLos_Click(object sender, EventArgs e)
        {
            Random los = new Random();

            int poczatek, koniec;
            try
            {

                poczatek = 3;
                koniec = 1000;

                int losowe = los.Next(poczatek, koniec);

                labelLos.Text =(losowe.ToString());

                labelTrojk.Text=(((losowe*(losowe-1)*(losowe-2))/6).ToString());
            }
            catch
            {
                MessageBox.Show("Błąd danych");

            }
        }
    }
}
