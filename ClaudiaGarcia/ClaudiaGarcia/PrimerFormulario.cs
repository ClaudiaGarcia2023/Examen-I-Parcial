using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaudiaGarcia
{
    public partial class PrimerFormulario : Form
    {
        public PrimerFormulario()
        {
            InitializeComponent();
        }

        private void PrimerFormulario_Load(object sender, EventArgs e)
        {

            this.txtTasaIntereses.Text = "0.015";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////MessageBox.Show (this.lstmes.SelectedItem.ToString());

            int mes=0;
            double resultado;

            if (this.lstmes.SelectedItem.ToString()== "Enero") 
            {
                mes = 1;
                ////MessageBox.Show(mes.ToString());

            }

            if (this.lstmes.SelectedItem.ToString() == "Febrero")
            {
                mes = 2;
                ////MessageBox.Show(mes.ToString());

            }
            if (this.lstmes.SelectedItem.ToString() == "Marzo")
            {
                mes = 3;
                ////MessageBox.Show(mes.ToString());

            }
            if (this.lstmes.SelectedItem.ToString() == "Abril")
            {
                mes = 4;
                ////MessageBox.Show(mes.ToString());

            }

            if (this.lstmes.SelectedItem.ToString() == "Mayo")
            {
                mes = 5;
                ////MessageBox.Show(mes.ToString());

            }
            if (this.lstmes.SelectedItem.ToString() == "Junio")
            {
                mes = 6;
                ////MessageBox.Show(mes.ToString());

            }
            if (this.lstmes.SelectedItem.ToString() == "Julio")
            {
                mes = 7;
                ////MessageBox.Show(mes.ToString());

            }
            if (this.lstmes.SelectedItem.ToString() == "Agosto")
            {
                mes = 8;
                ////MessageBox.Show(mes.ToString());

            }
            if (this.lstmes.SelectedItem.ToString() == "Septiembre")
            {
                mes = 9;
                ////MessageBox.Show(mes.ToString());

            }
            if (this.lstmes.SelectedItem.ToString() == "Octubre")
            {
                mes = 10;
                ////MessageBox.Show(mes.ToString());

            }
            if (this.lstmes.SelectedItem.ToString() == "Novimbre")
            {
                mes = 11;
                ////MessageBox.Show(mes.ToString());

            }
            if (this.lstmes.SelectedItem.ToString() == "Diciembre")
            {
                mes = 12;
                ////MessageBox.Show(mes.ToString());

            }

            resultado= calcular (Convert.ToDouble( this.txtCapital.Text), Convert.ToDouble(this.txtTasaIntereses.Text), mes);

            MessageBox.Show("El total de intereses es: " + Convert.ToString(resultado));




        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private double calcular(double monto, double intereses, int mes )
            

        {

            double resultado = 0;
            resultado = monto * intereses * mes;

            return resultado;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
