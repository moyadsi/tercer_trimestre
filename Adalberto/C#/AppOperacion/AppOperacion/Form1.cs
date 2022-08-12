using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LIB_Operacion;

namespace AppOperacion
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

        private void button1_Click(object sender, EventArgs e)
        {
            int numero1, numero2;
            //capturamos los valores de las cajas de texto
            try
            {
            numero1 = Convert.ToInt32( txtn1.Text);
            numero2 = Convert.ToInt32(txtn2.Text);
            //Instanciar la logica del negocio
            Operacion ObjOp = new Operacion();
            
                //Enviar los valores a la logica de negocio
                ObjOp.setN1 = numero1;
                ObjOp.SetN2 = numero2;

                if (ObjOp.calcular())
                {
                    txtsuma.Text = ObjOp.GetSuma.ToString();
                    return;
                }
                else
                {
                    MessageBox.Show(ObjOp.GetError);
                    return;
                }
            }
            catch(Exception Ex)
            {
                MessageBox.Show("Su mensaje esta Re Paila");
            }
        }
    }
}
