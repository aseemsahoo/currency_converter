using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace currency_converter
{
    public partial class mainwindow : Form
    {
        double[,] curr = new double[3, 3]
        {
            {1, 79.5944, 1.00133},
            {0.01254, 1, 0.01256},
            {0.99851, 79.4757,1}
        };

        public mainwindow()
        {
            InitializeComponent();
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            from_textbox.Clear();
            to_textbox.Clear();
            //from_comboBox.SelectedIndex = -1;
            //to_comboBox.SelectedIndex = -1;
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
            double res = curr[i, j] * input;
            to_textbox.Text = res.ToString();
        }

        private void from_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
