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
    public partial class frmCacularFactorial : Form
    {
        public frmCacularFactorial()
        {
            InitializeComponent();
            this.txtNumero.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.txtNumero.Text.Length==0)
            {
                MessageBox.Show("POR FAVOR INGRASR UN VALOR");
                this.txtNumero.Focus();
                return;
            }
            int a = int.Parse(this.txtNumero.Text);
            this.txtFactorial.Text = fmfactorial(a).ToString();
            
        }
        private int fmfactorial(int n)
        {
            if (n < 0)
            {
                return 0;
            }
            else if (n > 1)
            {
                return n * fmfactorial(n - 1);
            }
              
            return 1;
            
        }

        private void btnNUEVO_Click(object sender, EventArgs e)
        {
            this.txtNumero.Text = "";
            this.txtFactorial.Text = "0";
            this.txtNumero.Focus();
        }

        private void txtSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
