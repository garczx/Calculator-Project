using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtX.Clear();
            txtTotal.Clear();
            txtY.Clear();
            rdbSomar.Checked = true;
            txtX.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double x, y, total;
            
            if (double.TryParse(txtX.Text, out x) == false)
            {

                MessageBox.Show("Informe um valor válido", "Calculadora", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtX.Clear();   
                txtX.Focus();  
                return;  
            }

            if (double.TryParse(txtY.Text, out y) == false)
            {
                MessageBox.Show("Informe um valor válido", "Calculadora", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtY.Clear();   
                txtY.Focus();  
                return;  
            }           

            if (rdbSomar.Checked == true)
            {
                total = x + y;
            }

            else if (rdbSubtrair.Checked)
            {
                total = x - y;
            }
            else if (rdbMultiplicar.Checked)
            {
                total = x * y;
            }
            else
            {

                if (y == 0)
                {
                    txtTotal.Text = "Divisão por zero";
                    return;      
                }

                total = x / y;
            }
          

            txtTotal.Text = total.ToString();
        }
               }
        }
    
