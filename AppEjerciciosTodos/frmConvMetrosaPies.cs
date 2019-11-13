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
    public partial class frmConvMetrosaPies : Form
    {
        public frmConvMetrosaPies()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.txtMetros.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar los metros");
                this.txtMetros.Focus();
                return;
            }
            try
            {
                double metros = double.Parse(this.txtMetros.Text);
                this.txtPulgadas.Text = fnMetrosaPulgadas(metros).ToString();

                this.txtPies.Text = fnMetrosaPies(metros).ToString();
            }
            catch(Exception ex)
            {
                //para mostrar o captura los errores y muestra los errores
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private double fnMetrosaPulgadas(double metros)
        {
            return (metros * 39.37);
        }

        private double fnMetrosaPies(double metros)
        {
            return (metros *  3.28084);
        }
    }
}
