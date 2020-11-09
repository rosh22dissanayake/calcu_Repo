using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcu
{
    public partial class Form1 : Form
    {
        String operation = " ";
        double result_value = 0;
        bool is_operation_performed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if (tb_result.Text == "0" || is_operation_performed)
            {
                tb_result.Clear();

            }

            Button btn = (Button)sender;
            is_operation_performed = false;

            if (btn.Text == ". ")
            {

                tb_result.Text = tb_result.Text + btn.Text;
            }
        
        else
    {
         tb_result.Text = tb_result.Text + btn.Text;
    }
}

        private void operation_performed(object sender, EventArgs e)
        {
            if (result_value != 0)
            {
                button23.PerformClick();
                Button btn = (Button)sender;
                operation = btn.Text;
                result_value = double.Parse(tb_result.Text);

                lb_result.Text = result_value + operation;
                is_operation_performed = true;

            }

            else
            {

                Button btn = (Button)sender;
                operation = btn.Text;
                result_value = double.Parse(tb_result.Text);

                lb_result.Text = result_value + operation;
                is_operation_performed = true;

            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    tb_result.Text = (result_value + double.Parse(tb_result.Text)).ToString();
                    break;

                case "-":
                    tb_result.Text = (result_value - double.Parse(tb_result.Text)).ToString();
                    break;

                case "*":
                    tb_result.Text = (result_value * double.Parse(tb_result.Text)).ToString();

                    break;

                case "/":
                    tb_result.Text = (result_value / double.Parse(tb_result.Text)).ToString();
                    break;


            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            tb_result.Text = "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            tb_result.Text = "0";
            lb_result.Text = " ";
        }
    }
}
