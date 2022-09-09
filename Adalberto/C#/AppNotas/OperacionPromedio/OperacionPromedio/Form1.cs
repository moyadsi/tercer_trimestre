using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Usar logica de negocio
using AppNotas;

namespace OperacionPromedio
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

        private void btn_Click(object sender, EventArgs e)
        {
            // OBTENER LOS VALORES DE LAS CAJAS DE TEXTO
            int nota1, nota2, nota3, nota4;
            try
            {
                nota1 = Convert.ToInt32(txtn1.Text);
                nota2 = Convert.ToInt32(txtn2.Text);
                nota3 = Convert.ToInt32(txtn3.Text);
                nota4 = Convert.ToInt32(txtn4.Text);
                //Creamos objeto de la clase operacion
                Calificacion objO = new Calificacion();
                //Enviando los valores a la logica de negocio
                objO.setnota1 = nota1;
                objO.setnota2 = nota2;
                objO.setnota3 = nota3;
                objO.setnota4 = nota4;

                if (!objO.calcular())
                {
                    MessageBox.Show(objO.geterror);
                    return;
                }
                txtpr.Text = objO.getpromedio.ToString();
            }catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}
