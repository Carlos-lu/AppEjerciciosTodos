using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEjerciciosTodos
{
    public partial class frmArea_Triangulo : Form
    {
        public frmArea_Triangulo()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmArea_Triangulo_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
              if(this.txtA.Text=="")
                {
                MessageBox.Show("Debe ingresar el valor de A"); 
                this.txtA.Focus();
                return;
                }
            if (this.txtB.Text =="")
            {
                MessageBox.Show("Debe ingresar el valor de B");
                this.txtB.Focus();
                return;
            }
            if (this.txtC.Text == "")
            {
                MessageBox.Show("Debe ingresar el valor de C");
                this.txtC.Focus();
                return;
            }
            double a,b,c,result;
            if(double.TryParse(this.txtA.Text,out result))
            {
                a = result;
            }else
            {
                MessageBox.Show("Debe ingresar valores numericos");
                this.txtA.Focus();
                return;
            }

            if (double.TryParse(this.txtB.Text, out result))
            {
                b = result;
            }
            else
            {
                MessageBox.Show("Debe ingresar valores numericos");
                this.txtB.Focus();
                return;
            }

            if (double.TryParse(this.txtC.Text, out result))
            {
                c = result;
            }
            else
            {
                MessageBox.Show("Debe ingresar valores numericos");
                this.txtC.Focus();
                return;
            }

            this.txtAreaTriangulo.Text = fnAreaTriangulo(a, b, c).ToString("0.00");

        }

        private double fnAreaTriangulo(double a, double b, double c)
        {
            double area, sp;
            sp = (a + b + c) / 2;
            area = Math.Sqrt(sp * (sp - a) * (sp - b) * (sp - c));
            return area;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
