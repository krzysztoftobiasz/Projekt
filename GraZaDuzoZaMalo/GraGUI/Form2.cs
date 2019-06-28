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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            listViewHistoria.Columns.Add("Zgadywana", -2, HorizontalAlignment.Left);
            listViewHistoria.Columns.Add("Odpowiedź", -2, HorizontalAlignment.Left);
            listViewHistoria.Columns.Add("Czas", -2, HorizontalAlignment.Left);

            foreach(Gra.Ruch ruch in Form1.g.Historia)
            {
                ListViewItem historia = new ListViewItem(ruch.Propozycja.ToString());

                switch (ruch.Odpowiedz)
                {
                    case Gra.Odp.ZaMalo:
                        historia.SubItems.Add("Za mało");
                        break;

                    case Gra.Odp.ZaDuzo:
                        historia.SubItems.Add("Za dużo");
                        break;

                    case Gra.Odp.Trafiono:
                        historia.SubItems.Add("Trafiono");
                        break;
                }

                historia.SubItems.Add(ruch.Kiedy.ToString());


                listViewHistoria.Items.Add(historia);


            }
            Controls.Add(listViewHistoria);

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
