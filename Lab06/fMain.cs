using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbX1.Text) || (String.IsNullOrEmpty(tbX2.Text)))
            {
                tbY.Text = "Не введено даних!"; 
                return;
            }

            double x1 = double.Parse(tbX1.Text); 
            double x2 = double.Parse(tbX2.Text);

            double y = Math.Pow(x1, 3) + Math.Sqrt(123) + 4 - x2;

            int variant = int.Parse(tbVariant.Text);
            int last_num = variant % 10;

            if (last_num >= 0 && last_num <= 3)
            {
                tbY.Text = y.ToString("0.####");
            }
            else if (last_num >= 4 && last_num <= 6)
            {
                tbY.Text = y.ToString("0.###");
            }
            else
            {
                tbY.Text = y.ToString("0,00E+00");
            }

            double result;
            if (last_num >= 0 && last_num <= 3)
            {
                result = (x1 + x2) / 2;
                lblResult.Text = $"Середнє арифметичне: {result:0.####}";
            }
            else if (last_num >= 4 && last_num <= 6)
            {
                result = Math.Min(x1, x2);
                lblResult.Text = $"Мінімальне значення: {result:0.###}";
            }
            else if (last_num >= 7 && last_num <= 9)
            {
                result = Math.Max(x1, x2);
                lblResult.Text = $"Максимальне значення: {result:0,00E+00}";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbX1.Text = string.Empty; 
            tbX2.Text = string.Empty; 
            tbY.Text = string.Empty;
            tbVariant.Text = string.Empty;
            lblResult.Text = "-";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}