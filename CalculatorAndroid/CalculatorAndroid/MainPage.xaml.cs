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
        public MainPage()
        {
            InitializeComponent();
            risultato = 0;
        }

        private void btn_soum_Clicked(object sender, EventArgs e)
        {
            try
            {
                risultato = risultato + Convert.ToInt32(ent_num1.Text);
                ent_num1.Text = "";
                lbl_risultato.Text = risultato.ToString();
            }catch(Exception)
            {
                lbl_risultato.Text = "ERRORE";
            }
        }

        private void btn_sub_Clicked(object sender, EventArgs e)
        {
            try
            {
                risultato = risultato - Convert.ToInt32(ent_num1.Text);
                ent_num1.Text = "";
                lbl_risultato.Text = risultato.ToString();
            }catch(Exception)
            {
                lbl_risultato.Text = "ERRORE";
            }
        }

        private void btn_div_Clicked(object sender, EventArgs e)
        {
            try
            {
                risultato = risultato / Convert.ToInt32(ent_num1.Text);
                ent_num1.Text = "";
                lbl_risultato.Text = risultato.ToString();
            }catch(Exception)
            {
                lbl_risultato.Text = "ERRORE";
            }
        }

        private void btn_mol_Clicked(object sender, EventArgs e)
        {
            try
            { 
                risultato = risultato * Convert.ToInt32(ent_num1.Text);
                ent_num1.Text = "";
                lbl_risultato.Text = risultato.ToString();
            }catch(Exception)
            {
                lbl_risultato.Text = "ERRORE";
            }
        }

        private void btn_risultato_Clicked(object sender, EventArgs e)
        {
            lbl_risultato.Text = risultato.ToString();
            ent_num1.Text = "";
            risultato = 0;
        }
    }
}
