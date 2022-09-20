using currency_converter.Classes;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace currency_converter
{
    public partial class mainwindow : Form
    {
        //double[,] rates = new double[3, 3]
        //{
        //    {1, 79.5944, 1.00133},
        //    {0.01254, 1, 0.01256},
        //    {0.99851, 79.4757,1}
        //};
        double[,] rates = new double[15, 15];

        List<string> currencies = new List<string>(new string[]
        {
                "USD", "EUR", "INR", "JPY", "AUD", "GBP", "CAD", "CHF",
                "CNY", "HKD", "NZD", "SEK", "SGD", "MXN", "RUB"
        });
        public mainwindow()
        {
            InitializeComponent();
            /*
            vector<string> curr 
            {
	            "USD", "EUR", "JPY", "AUD", "GBP", "CAD", "CHF", "CNY", 
	            "HKD", "NZD", "SEK", "SGD", "MXN", "INR", "RUB"
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

            foreach (string s in currencies)
            {
                from_comboBox.Items.Add(s);
                to_comboBox.Items.Add(s);
            }
            fill_data();
        }
        private void update_currencies(int i, Currencies Base)
        {
            rates[i, 0] = Base.usd;
            rates[i, 1] = Base.eur;
            rates[i, 2] = Base.inr;
            rates[i, 3] = Base.jpy;
            rates[i, 4] = Base.aud;
            rates[i, 5] = Base.gbp;
            rates[i, 6] = Base.cad;
            rates[i, 7] = Base.chf;
            rates[i, 8] = Base.cny;
            rates[i, 9] = Base.hkd;
            rates[i, 10] = Base.nzd;
            rates[i, 11] = Base.sek;
            rates[i, 12] = Base.sgd;
            rates[i, 13] = Base.mxn;
            rates[i, 14] = Base.rub;
        }

        private async void fill_data()
        {
            for (int i = 0; i < 15; i++)
            {
                string base_currency = currencies[i].ToLower();
                string url = "https://cdn.jsdelivr.net/gh/fawazahmed0/currency-api@1/latest/currencies/" + base_currency + ".json";

                Root output = await url.GetJsonAsync<Root>();
                update_currencies(i, output.Base);
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
            if (double.TryParse(from_textbox.Text, out test) == false)
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

            double res = rates[i, j] * input;
            to_textbox.Text = res.ToString();
        }
    }
}
