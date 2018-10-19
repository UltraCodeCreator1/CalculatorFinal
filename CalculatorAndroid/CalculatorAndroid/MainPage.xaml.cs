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
        bool piumenobool;
        bool numberWriterBool;
        string head;
        string labeltext;
        string modifiedtext;
        string caseSwitch;

        public MainPage()
        {
            InitializeComponent();
            o = new Operazione();
            risultato = 0;
            numberWriterBool = false;
            piumenobool = false;
        }

        private void btn_soum_Clicked(object sender, EventArgs e)
        {
            if (lbl_numbers.Text != "")
            {
                lbl_showoperations.Text = lbl_showoperations.Text + lbl_numbers.Text + "+";
                caseSwitch = "+";
                risultato = o.Calcolo(double.Parse(lbl_numbers.Text), caseSwitch);
                lbl_numbers.Text = risultato.ToString();
                numberWriterBool = false;
            }
        }

        private void btn_sub_Clicked(object sender, EventArgs e)
        {
            if (lbl_numbers.Text != "")
            {
                lbl_showoperations.Text = lbl_showoperations.Text + lbl_numbers.Text + "-";
                caseSwitch = "-";
                risultato = o.Calcolo(double.Parse(lbl_numbers.Text), caseSwitch);
                lbl_numbers.Text = risultato.ToString();
                numberWriterBool = false;
            }

        }

        private void btn_div_Clicked(object sender, EventArgs e)
        {
            if (lbl_numbers.Text != "")
            {
                lbl_showoperations.Text = lbl_showoperations.Text + lbl_numbers.Text + "/";
                caseSwitch = "/";
                risultato = o.Calcolo(double.Parse(lbl_numbers.Text), caseSwitch);
                lbl_numbers.Text = risultato.ToString();
                numberWriterBool = false;
            }

        }

        private void btn_mol_Clicked(object sender, EventArgs e)
        {
            if (lbl_numbers.Text != "")
            {
                lbl_showoperations.Text = lbl_showoperations.Text + lbl_numbers.Text + "*";
                caseSwitch = "*";
                risultato = o.Calcolo(double.Parse(lbl_numbers.Text), caseSwitch);
                lbl_numbers.Text = risultato.ToString();
                numberWriterBool = false;
            }
        }

        private void btn_risultato_Clicked(object sender, EventArgs e)
        {
            risultato = o.Calcolo(double.Parse(lbl_numbers.Text), caseSwitch);
            lbl_numbers.Text = Convert.ToString(risultato);
            o = new Operazione();
            lbl_showoperations.Text = "";
            numberWriterBool = false;
        }

        private void btn_piumeno_Clicked(object sender, EventArgs e)
        {
            string text = lbl_numbers.Text;
            if (lbl_numbers.Text != "0" && lbl_numbers.Text != "")
            { 
                if (piumenobool == false)
                {
                    head = "-" + text.PadLeft(1, '-');
                    lbl_numbers.Text = head;
                    piumenobool = true;
                }
                else
                {
                    modifiedtext = text.Remove(0, 1);
                    lbl_numbers.Text = modifiedtext;
                    piumenobool = false;
                }
            }

        }

        private void btn_virgola_Clicked(object sender, EventArgs e)
        {
            lbl_numbers.Text = lbl_numbers.Text + ",";
            btn_virgola.IsEnabled = false;
        }

        private void btn_ClearEntry_Clicked(object sender, EventArgs e)
        {
            numberWriterBool = false;
            lbl_numbers.Text = "0";
            btn_virgola.IsEnabled = true;
        }

        private void btn_Clear_Clicked(object sender, EventArgs e)
        {
            numberWriterBool = false;
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
                if (labeltext.Length > 1)
                {
                    modifiedtext = labeltext.Remove(labeltext.Length - 1, 1);
                    lbl_numbers.Text = modifiedtext;
                }
                else
                {
                    lbl_numbers.Text = "0";
                    numberWriterBool = false;

                }
            }

        }

        private void btn_easteregg_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_radicequadrata_Clicked(object sender, EventArgs e)
        {
            risultato = o.Radicequadrata(Convert.ToDouble(lbl_numbers.Text));
            lbl_numbers.Text = Convert.ToString(risultato);
            numberWriterBool = false;
        }

        private void btn_xallaseconda_Clicked(object sender, EventArgs e)
        {
            risultato = o.XAllaseconda(Convert.ToDouble(lbl_numbers.Text));
            lbl_numbers.Text = Convert.ToString(risultato);
            numberWriterBool = false;
        }

        private void btn_unosux_Clicked(object sender, EventArgs e)
        {
            risultato = o.Unosux(Convert.ToDouble(lbl_numbers.Text));
            lbl_numbers.Text = Convert.ToString(risultato);
            numberWriterBool = false;
        }

        private void btn_number_Clicked(object sender, EventArgs e)
        {
            if (numberWriterBool == false)
            {
                lbl_numbers.Text = "";
                numberWriterBool = true;
            }
            Button btn = sender as Button;
            lbl_numbers.Text = lbl_numbers.Text + btn.ClassId;
        }
    }
}
