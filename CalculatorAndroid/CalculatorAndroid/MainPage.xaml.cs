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
        double risultato;
        bool check;
        string head;
        string labeltext;
        string modifiedtext;
        string caseSwitch;

        public MainPage()
        {
            o = new Operazione();
            InitializeComponent();
            risultato = 0;
            check = false;
        }

        private void btn_soum_Clicked(object sender, EventArgs e)
        {
            if (lbl_numbers.Text != "")
            {
                lbl_showoperations.Text = lbl_showoperations.Text + lbl_numbers.Text + "+";
                risultato = o.Somma(double.Parse(lbl_numbers.Text));
                lbl_numbers.Text = risultato.ToString("F1");
                caseSwitch = "+";
                check = false;
            }
        }

        private void btn_sub_Clicked(object sender, EventArgs e)
        {
            if (lbl_numbers.Text != "")
            {
                lbl_showoperations.Text = lbl_showoperations.Text + lbl_numbers.Text + "-";
                risultato = o.Sottrazione(double.Parse(lbl_numbers.Text));
                lbl_numbers.Text = Convert.ToString(risultato);
                caseSwitch = "-";
                check = false;
            }

        }

        private void btn_div_Clicked(object sender, EventArgs e)
        {
            if (lbl_numbers.Text != "")
            {
                lbl_showoperations.Text = lbl_showoperations.Text + lbl_numbers.Text + "/";
                risultato = o.Divisione(double.Parse(lbl_numbers.Text));
                lbl_numbers.Text = Convert.ToString(risultato);
                caseSwitch = "/";
                check = false;
            }

        }

        private void btn_mol_Clicked(object sender, EventArgs e)
        {
            if (lbl_numbers.Text != "")
            {
                lbl_showoperations.Text = lbl_showoperations.Text + lbl_numbers.Text + "*";
                risultato = o.Moltiplicazione(double.Parse(lbl_numbers.Text));
                lbl_numbers.Text = Convert.ToString(risultato);
                caseSwitch = "*";
                check = false;
            }
        }

        private void btn_risultato_Clicked(object sender, EventArgs e)
        {
            switch (caseSwitch)
            {
                case "+":
                    risultato = o.Somma(Convert.ToDouble(lbl_numbers.Text));
                    lbl_numbers.Text = Convert.ToString(risultato);
                    break;
                case "-":
                    risultato = o.Sottrazione(Convert.ToDouble(lbl_numbers.Text));
                    lbl_numbers.Text = Convert.ToString(risultato);
                    break;
                case "*":
                    risultato = o.Moltiplicazione(Convert.ToDouble(lbl_numbers.Text));
                    lbl_numbers.Text = Convert.ToString(risultato);
                    break;
                case "/":
                    risultato = o.Divisione(Convert.ToDouble(lbl_numbers.Text));
                    lbl_numbers.Text = Convert.ToString(risultato);
                    break;
            }
            o = new Operazione();
            lbl_showoperations.Text = "";
            check = false;
        }

        private void btn_piumeno_Clicked(object sender, EventArgs e)
        {
            string text = lbl_numbers.Text;
            head = "-" + text.PadLeft(1, '-');
            lbl_numbers.Text = head;
        }

        private void btn_virgola_Clicked(object sender, EventArgs e)
        {
            lbl_numbers.Text = lbl_numbers.Text + ",";
            btn_virgola.IsEnabled = false;
        }

        private void btn_ClearEntry_Clicked(object sender, EventArgs e)
        {
            lbl_numbers.Text = "0";
            btn_virgola.IsEnabled = true;
        }

        private void btn_Clear_Clicked(object sender, EventArgs e)
        {
            lbl_numbers.Text = "0";
            lbl_showoperations.Text = "";
            o = new Operazione();
            btn_virgola.IsEnabled = true;
        }

        private void btn_delete_Clicked(object sender, EventArgs e)
        {
            if (lbl_numbers.Text != "0" && lbl_numbers.Text != "")
            {
                labeltext = lbl_numbers.Text;
                modifiedtext = labeltext.Remove(labeltext.Length - 1, 1);
                lbl_numbers.Text = modifiedtext;
            }
        }

        private void btn_easteregg_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_radicequadrata_Clicked(object sender, EventArgs e)
        {
            risultato = o.Radicequadrata(Convert.ToDouble(lbl_numbers.Text));
            lbl_numbers.Text = Convert.ToString(risultato);
            check = false;
        }

        private void btn_xallaseconda_Clicked(object sender, EventArgs e)
        {
            risultato = o.XAllaseconda(Convert.ToDouble(lbl_numbers.Text));
            lbl_numbers.Text = Convert.ToString(risultato);
            check = false;
        }

        private void btn_unosux_Clicked(object sender, EventArgs e)
        {
            risultato = o.Unosux(Convert.ToDouble(lbl_numbers.Text));
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
            lbl_numbers.Text = lbl_numbers.Text + btn.ClassId;
        }
    }
}
