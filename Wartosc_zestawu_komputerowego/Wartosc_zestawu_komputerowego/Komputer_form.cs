using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wartosc_zestawu_komputerowego
{
    public partial class Komputer_form : Form
    {
        private Form1 _form1;

        int laczna_cena = 0;

        private bool[] array_check_box = { false, false, false, false };
        private int[] ceny_check_box = { 200, 500, 100, 50 };

        private bool[] array_radio_buttons = { false, false, false };
        private int[] ceny_radio_buttons = { 150, 250, 350 };

        private bool cena_karty_zaznaczona = false;
        private int nr_karty_graficznej = -1;
        private int[] ceny_kart_graficznych = { 7949, 4484, 2399, 2699, 4559, 1859, 1389 };
        public Komputer_form(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }

        private void Komputer_form_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            array_check_box[0] = !array_check_box[0];
            ZaktualizujLacznaCene();
            ZaktualizujLabelzCena();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            array_check_box[1] = !array_check_box[1];
            ZaktualizujLacznaCene();
            ZaktualizujLabelzCena();

        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            array_check_box[2] = !array_check_box[2];
            ZaktualizujLacznaCene();
            ZaktualizujLabelzCena();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            array_check_box[3] = !array_check_box[3];
            ZaktualizujLacznaCene();
            ZaktualizujLabelzCena();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            array_radio_buttons[0] = !array_radio_buttons[0];
            ZaktualizujLacznaCene();
            ZaktualizujLabelzCena();

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            array_radio_buttons[1] = !array_radio_buttons[1];
            ZaktualizujLacznaCene();
            ZaktualizujLabelzCena();
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            array_radio_buttons[2] = !array_radio_buttons[2];
            ZaktualizujLacznaCene();
            ZaktualizujLabelzCena();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cena_karty_zaznaczona = true;
            nr_karty_graficznej = comboBox1.SelectedIndex;
            ZaktualizujLacznaCene();
            ZaktualizujLabelzCena();
        }

        private void ZaktualizujLacznaCene()
        {
            laczna_cena = 0;

            for (int i = 0; i < array_radio_buttons.Length; i++)
            {
                if (array_radio_buttons[i])
                {
                    laczna_cena += ceny_radio_buttons[i];
                }
            }
            for (int j = 0; j < array_check_box.Length; j++)
            {
                if (array_check_box[j])
                {
                    laczna_cena += ceny_check_box[j];
                }
            }

            if (cena_karty_zaznaczona)
            {
                laczna_cena += ceny_kart_graficznych[nr_karty_graficznej];
            }

        }

        private void ZaktualizujLabelzCena()
        {
            label1.Text = laczna_cena.ToString() + "zl";
        }

        private void Zapisz_button_Click(object sender, EventArgs e)
        {
            ZaktualizujLacznaCene();
            _form1.CenaKomputera = laczna_cena;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


    }
}
