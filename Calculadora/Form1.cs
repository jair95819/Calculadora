using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        Funciones funciones = new Funciones();
        int num1, num2, result;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_suma_Click(object sender, EventArgs e)
        {
            txtbx_resultado.Clear();

            try
            {
                num1 = Convert.ToInt32(txtbx_num1.Text);
                num2 = Convert.ToInt32(txtbx_num2.Text);
                result = funciones.Sum(num1, num2);
                txtbx_resultado.Text = result.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"No has ingresado valores!\nInformación del error: {ex.Message}", "Error");
            }
        }

        private void btn_resta_Click(object sender, EventArgs e)
        {
            txtbx_resultado.Clear();

            try
            {
                num1 = Convert.ToInt32(txtbx_num1.Text);
                num2 = Convert.ToInt32(txtbx_num2.Text);
                result = funciones.Substraction(num1, num2);
                txtbx_resultado.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No has ingresado valores!\nInformación del error: {ex.Message}", "Error");
            }
        }

        private void btn_multiplicacion_Click(object sender, EventArgs e)
        {
            txtbx_resultado.Clear();

            try
            {
                num1 = Convert.ToInt32(txtbx_num1.Text);
                num2 = Convert.ToInt32(txtbx_num2.Text);
                result = funciones.Multiplication(num1, num2);
                txtbx_resultado.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No has ingresado valores!\nInformación del error: {ex.Message}", "Error");
            }
        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            txtbx_resultado.Clear();

            try
            {
                num1 = Convert.ToInt32(txtbx_num1.Text);
                num2 = Convert.ToInt32(txtbx_num2.Text);
                double result_div = funciones.Division(num1, num2); //I made the result variable double here to avoid decimal errors. 
                if(result_div < 0)
                {
                    MessageBox.Show("No puedes dividir entre 0 :/");
                    txtbx_num2.Clear();
                    txtbx_num2.Focus();
                }
                else
                {
                    txtbx_resultado.Text = result_div.ToString("N4");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No has ingresado valores!\nInformación del error: {ex.Message}", "Error");
            }
        }
    }
}
