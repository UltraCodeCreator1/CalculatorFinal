using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using OperationLIbrary;

namespace CalculatorAndroid
{
    public partial class MainPage : ContentPage
    {
        Operazione o;
        int risultato;
        double decimale;
        bool check;
        string labeltext;
        string modifiedtext;
        string puntatore;
        public MainPage()
        {
            o = new Operazione(false);
            InitializeComponent();
            check = false;
        }

        private void btn_soum_Clicked(object sender, EventArgs e)
        {
            lbl_showoperations.Text = lbl_showoperations.Text + lbl_numbers.Text + "+";
            risultato = o.Somma(Convert.ToInt32(lbl_numbers.Text));
            lbl_numbers.Text = Convert.ToString(risultato);
            puntatore = "+";
            check = false;

            
        }

        private void btn_sub_Clicked(object sender, EventArgs e)
        {
            lbl_showoperations.Text = lbl_showoperations.Text + lbl_numbers.Text + "-";
            risultato = o.Sottrazione(Convert.ToInt32(lbl_numbers.Text));
            lbl_numbers.Text = Convert.ToString(risultato);
            puntatore = "-";
            check = false;

        }

        private void btn_div_Clicked(object sender, EventArgs e)
        {
            lbl_showoperations.Text = lbl_showoperations.Text + lbl_numbers.Text + "/";
            risultato = o.Divisione(Convert.ToInt32(lbl_numbers.Text));
            lbl_numbers.Text = Convert.ToString(risultato);
            puntatore = "/";
            check = false;


        }

        private void btn_mol_Clicked(object sender, EventArgs e)
        {
            lbl_showoperations.Text = lbl_showoperations.Text + lbl_numbers.Text + "*";
            risultato = o.Moltiplicazione(Convert.ToInt32(lbl_numbers.Text));
            lbl_numbers.Text = Convert.ToString(risultato);
            puntatore = "*";
            check = false;

        }

        private void btn_risultato_Clicked(object sender, EventArgs e)
        {
           
        }

        private void btn_piumeno_Clicked(object sender, EventArgs e)
        {
             
        }

        private void btn_virgola_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_ClearEntry_Clicked(object sender, EventArgs e)
        {
            lbl_numbers.Text = "";

        }

        private void btn_Clear_Clicked(object sender, EventArgs e)
        {
            lbl_numbers.Text = "";
            lbl_showoperations.Text = "";
            o = new Operazione(false);
        }

        private void btn_delete_Clicked(object sender, EventArgs e)
        {
            labeltext = lbl_numbers.Text;
            modifiedtext = labeltext.Remove(labeltext.Length - 1, 1);
            lbl_numbers.Text = modifiedtext;
        }

        private void btn_easteregg_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_radicequadrata_Clicked(object sender, EventArgs e)
        {
            decimale = o.Radicequadrata(Convert.ToInt32(lbl_numbers.Text));
            risultato = Convert.ToInt32(decimale);
            lbl_numbers.Text = Convert.ToString(risultato);
            check = false;
        }

        private void btn_xallaseconda_Clicked(object sender, EventArgs e)
        {
            risultato = o.XAllaseconda(Convert.ToInt32(lbl_numbers.Text));
            lbl_numbers.Text = Convert.ToString(risultato);
            check = false;
        }

        private void btn_unosux_Clicked(object sender, EventArgs e)
        {
            decimale = o.Unosux(Convert.ToInt32(lbl_numbers.Text));
            risultato = Convert.ToInt32(decimale);
            lbl_numbers.Text = Convert.ToString(risultato);
            check = false;
        }

        private void btn_number_Clicked(object sender, EventArgs e)
        {
            if (check == false)
            {
                lbl_numbers.Text = "";
                check = true;
            }
           
            Button btn = sender as Button;
            if (btn.ClassId == "9")
                lbl_numbers.Text = lbl_numbers.Text + "9";
            if (btn.ClassId == "8")
                lbl_numbers.Text = lbl_numbers.Text + "8";
            if (btn.ClassId == "7")
                lbl_numbers.Text = lbl_numbers.Text + "7";
            if (btn.ClassId == "6")
                lbl_numbers.Text = lbl_numbers.Text + "6";
            if (btn.ClassId == "5")
                lbl_numbers.Text = lbl_numbers.Text + "5";
            if (btn.ClassId == "4")
                lbl_numbers.Text = lbl_numbers.Text + "4";
            if (btn.ClassId == "3")
                lbl_numbers.Text = lbl_numbers.Text + "3";
            if (btn.ClassId == "2")
                lbl_numbers.Text = lbl_numbers.Text + "2";
            if (btn.ClassId == "1")
                lbl_numbers.Text = lbl_numbers.Text + "1";
            if (btn.ClassId == "0")
                lbl_numbers.Text = lbl_numbers.Text + "0";
        }
    }
}
