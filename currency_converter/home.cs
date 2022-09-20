using currency_converter.Classes;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace currency_converter
{
    public partial class mainwindow : Form
    {
        //double[,] curr = new double[3, 3]
        //{
        //    {1, 79.5944, 1.00133},
        //    {0.01254, 1, 0.01256},
        //    {0.99851, 79.4757,1}
        //};


        public mainwindow()
        {
            InitializeComponent();
            /*
            vector<string> curr 
            {
	            "USD", "EUR", "JPY", "AUD", "GBP", "CAD", "CHF", "CNY", 
	            "HKD", "NZD", "SEK", "SGD", "NOK", "MXN", "INR", "RUB"
            };
            for (int i = 0; i < 20; i++)
            {
                string base = curr[i];
                string url "https://cdn.jsdelivr.net/gh/fawazahmed0/currency-api@1/latest/currencies/" + base + ".json";
                //al the a adat wutg there string are fetched 
                unordered_map<string, double> all_data = fetch(url);
                //only 20 valid currencues are taken here 
                for (int j = 0; j < 20; j++)
                {
                    string dest = curr[j];
                    mat[i][j] = all_data[dest];
                }
            }
            */
            fill_data();

        }

        private async void fill_data()
        {
            List<string> curr = new List<string>(new string[]
            {
                "USD", "EUR", "JPY", "AUD", "GBP", "CAD", "CHF", "CNY",
                "HKD", "NZD", "SEK", "SGD", "MXN", "INR", "RUB"
            });
            for (int i = 0; i < 15; i++)
            {
                string base_currency = curr[i].ToLower();
                string url = "https://cdn.jsdelivr.net/gh/fawazahmed0/currency-api@1/latest/currencies/" + base_currency + ".json";
                Root output = await url.GetJsonAsync<Root>();

                //var a = output.Bas;
                //var base_c = output.Base;
                //var to = base_c.inr;
            }
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            from_textbox.Clear();
            to_textbox.Clear();
        }

        private bool validate_amount()
        {
            errorProvider.Clear();
         
         
            double test;
            if(double.TryParse(from_textbox.Text, out test) == false)
            {
                errorProvider.SetError(from_textbox, "Please enter an amount");
                return false;
            }
             if (from_comboBox.SelectedIndex == -1)
            {
                errorProvider.SetError(from_comboBox, "Please select a currency");
                return false;
            }
            if (to_comboBox.SelectedIndex == -1)
            {
                errorProvider.SetError(to_comboBox, "Please select a currency");
                return false;
            }
            return true;
        }

        private void convert_button_Click(object sender, EventArgs e)
        {
            if (validate_amount() == false)
            {
                return;
            }
          
            double input;
            double.TryParse(from_textbox.Text, out input);
            int i = from_comboBox.SelectedIndex;
            int j = to_comboBox.SelectedIndex;
            // double res = curr[i, j] * input;
            // to_textbox.Text = res.ToString();
        }

        private void from_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
