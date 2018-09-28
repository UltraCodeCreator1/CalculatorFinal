using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculatorAndroid
{
    public partial class MainPage : ContentPage
    {
        int risultato;
        bool check;
        string puntatore;
        public MainPage()
        {
            InitializeComponent();
            risultato = 0;
            check = false;
        }

        private void btn_soum_Clicked(object sender, EventArgs e)
        {
            try
            {
                if(check == false)
                {
                    risultato = Convert.ToInt32(ent_num1.Text);
                    check = true;
                }
                else
                {
                    risultato = risultato + Convert.ToInt32(ent_num1.Text);

                }
                ent_num1.Text = "";
                lbl_risultato.Text = risultato.ToString();
                puntatore = "+";
            }catch(Exception)
            {
                lbl_risultato.Text = "ERRORE";
            }

        }

        private void btn_sub_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (check == false)
                {
                    risultato = Convert.ToInt32(ent_num1.Text);
                    check = true;
                }
                else
                {
                    risultato = risultato - Convert.ToInt32(ent_num1.Text);

                }
                ent_num1.Text = "";
                lbl_risultato.Text = risultato.ToString();
                puntatore = "-";
            }catch(Exception)
            {
                lbl_risultato.Text = "ERRORE";
            }
        }

        private void btn_div_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (check == false)
                {
                    risultato = Convert.ToInt32(ent_num1.Text);
                    check = true;
                }
                else
                {
                    risultato = risultato / Convert.ToInt32(ent_num1.Text);
                }
                ent_num1.Text = "";
                lbl_risultato.Text = risultato.ToString();
                puntatore = "/";
            }catch(Exception)
            {
                lbl_risultato.Text = "ERRORE";
            }
        }

        private void btn_mol_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (check == false)
                {
                    risultato = Convert.ToInt32(ent_num1.Text);
                    check = true;
                }
                else
                {
                    risultato = risultato * Convert.ToInt32(ent_num1.Text);
                }
                ent_num1.Text = "";
                puntatore = "*";
                lbl_risultato.Text = risultato.ToString();
            }catch(Exception)
            {
                lbl_risultato.Text = "ERRORE";
            }
        }

        private void btn_risultato_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (puntatore == "+")
                    risultato = risultato + Convert.ToInt32(ent_num1.Text);
                if (puntatore == "-")
                    risultato = risultato - Convert.ToInt32(ent_num1.Text);
                if (puntatore == "/")
                    risultato = risultato / Convert.ToInt32(ent_num1.Text);
                if (puntatore == "*")
                    risultato = risultato * Convert.ToInt32(ent_num1.Text);
            }catch(Exception)
            {
                lbl_risultato.Text = "ERRORE";
            }
            lbl_risultato.Text = risultato.ToString();
            ent_num1.Text = "";
            check = false;
            risultato = 0;
        }
    }
}
