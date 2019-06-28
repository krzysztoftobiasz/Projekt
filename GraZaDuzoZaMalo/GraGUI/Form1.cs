using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelGry;

namespace GraGUI
{
    public partial class Form1 : Form
    {
        public static  Gra g;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNowaGra_Click(object sender, EventArgs e)
        {
            groupBoxLosowanie.Visible = true;
            textBoxZakresOd.Enabled = true;
            textBoxZakresDo.Enabled = true;
            buttonWylosuj.Enabled = true;
            buttonSprawdz.Visible = true;
            buttonPoddaj.Enabled = true;
            buttonSprawdz.Enabled = true;
            textBoxLosuj.Enabled = true;
            labelWynik.Text = " ";


        }

        private void buttonWylosuj_Click(object sender, EventArgs e)
        {
            int zakresOd, zakresDo;

            try
            {

                zakresOd = int.Parse(textBoxZakresOd.Text);
                zakresDo = int.Parse(textBoxZakresDo.Text);
            }
            catch
            {
                zakresOd = 1;
                zakresDo = 200;
            }
            groupBoxZgaduj.Visible = true;
            g = new Gra( zakresOd, zakresDo );
            buttonHistoria.Enabled = true;

            textBoxZakresOd.Enabled = false;
            textBoxZakresDo.Enabled = false;
            buttonWylosuj.Enabled = false;
            buttonSprawdz.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxZakresOd_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxLosowanie_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSprawdz_Click(object sender, EventArgs e)
        {
            int zgadywana = 0;
            Gra.Odp odp;
            try
            {
                zgadywana = int.Parse(textBoxLosuj.Text);
            }
            catch
            {

            }
            odp = g.Ocena(zgadywana);

            labelRuchy.Text = g.LicznikRuchow.ToString();

            switch (odp)
            {
                case Gra.Odp.ZaMalo:
                    labelWynik.Text = "Za mało";
                    break;

                case Gra.Odp.ZaDuzo:
                    labelWynik.Text = "Za dużo";
                    break;

                case Gra.Odp.Trafiono:
                    labelWynik.Text = "Udało się!";
                    break;
            }

            if (g.Stan == Gra.StanGry.Odgadnieta)
            {
                DialogResult wygrana= MessageBox.Show($"Brawo! Wylosowana liczba to {g.CoByloWylosowane()}" , "Brawo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                buttonPoddaj.Enabled = false;
                buttonSprawdz.Enabled = false;
                textBoxLosuj.Enabled = false;

                if (wygrana == DialogResult.OK)
                {
                    groupBoxZgaduj.Visible = false;
                    groupBoxLosowanie.Visible = false;
                    buttonNowaGra.Enabled = true;
                    g.ResetujLicznik();


                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            g.Poddaj();

            if (g.Stan == Gra.StanGry.Poddana)
            {
                DialogResult poddanie = MessageBox.Show("Poddałeś się!", "Poddanie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                buttonPoddaj.Enabled = false;
                buttonSprawdz.Enabled = false;
                textBoxLosuj.Enabled = false;

                if (poddanie == DialogResult.OK)
                {
                    groupBoxZgaduj.Visible = false;
                    groupBoxLosowanie.Visible = false;
                    buttonNowaGra.Enabled = true;
                    g.ResetujLicznik();
                }

            }
        }

        private void buttonHistoria_Click(object sender, EventArgs e)
        {
            Form2 historiaF = new Form2();
            historiaF.Show();
        }

        private void labelRuchy_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBoxZakresDo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
//komentarz