using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace currency_converter
{
    public partial class mainwindow : Form
    {
        public mainwindow()
        {
            InitializeComponent();
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            from_textbox.Clear();
            to_textbox.Clear();
        }

        private void convert_button_Click(object sender, EventArgs e)
        {
            int cal = 70 * Convert.ToInt32(from_textbox.Text);
            string ans = cal.ToString();
            to_textbox.Text = ans;
        }

        private void amount_label_Click(object sender, EventArgs e)
        {

        }
    }
}
