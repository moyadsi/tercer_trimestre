using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibLN_Empleado;
using System.Data.SqlClient;

namespace AppEmpresa
{
    public partial class DgvEpleado : Form
    {
        public DgvEpleado()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            // Instanciar la logica del negocio
            Empleado Obje = new Empleado();

            //Definir las variales
            string cedula,nombre,apellido,telefono;
            double salario;

            //Capturo Datos
            cedula=txtcedula.Text;
            nombre=txtnombre.Text;
            apellido=txtapellido.Text;
            telefono=txttelefono.Text;
            salario = Convert.ToDouble(txtsalario.Text);

            //Enviar datos a la logica de negocio
            Obje.Id_Emp = cedula;
            Obje.Nombre = nombre;
            Obje.Apellido = apellido;
            Obje.Telefono = telefono;
            Obje.Salario= salario;

            // Guardar datos a la logica d negocio
            if(!Obje.grabar_empleado())
            {
                MessageBox.Show(Obje.Error);
                Obje = null;
                return;
            }
            else
            {
                MessageBox.Show(Obje.Error);
                Obje=null;
                ListarEmpleado();
                return;
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            // Instanciar la logica del negocio
            Empleado Obje = new Empleado();

            //Definir las variales
            string cedula;

            //Capturo Datos
            cedula = txtcedula.Text;

            //Enviar datos a la logica de negocio
            Obje.Id_Emp = cedula;

            // Eliminar datos a la logica d negocio
            if (!Obje.eliminar_empleado())
            {
                MessageBox.Show(Obje.Error);
                Obje = null;
                return;
            }
            else
            {
                MessageBox.Show(Obje.Error);
                Obje = null;
                ListarEmpleado();
                return;
            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            // Instanciar la logica del negocio
            Empleado Obje = new Empleado();

            //Definir las variales
            string cedula, nombre, apellido, telefono;
            double salario;

            //Capturo Datos
            cedula = txtcedula.Text;
            nombre = txtnombre.Text;
            apellido = txtapellido.Text;
            telefono = txttelefono.Text;
            salario = Convert.ToDouble(txtsalario.Text);

            //Enviar datos a la logica de negocio
            Obje.Id_Emp = cedula;
            Obje.Nombre = nombre;
            Obje.Apellido = apellido;
            Obje.Telefono = telefono;
            Obje.Salario = salario;

            // Guardar datos a la logica d negocio
            if (!Obje.actualizar_empleado())
            {
                MessageBox.Show(Obje.Error);
                Obje = null;
                return;
            }
            else
            {
                MessageBox.Show(Obje.Error);
                Obje = null;
                ListarEmpleado();
                return;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            ListarEmpleado();
        }

        private void ListarEmpleado()
        {
            // Instanciar la logica del negocio
            Empleado Obje = new Empleado();

            // Guardar datos a la logica d negocio
            if (!Obje.listar_empleado(DgvEmpleado))
            {
                MessageBox.Show(Obje.Error);
                Obje = null;
                return;
            }
            else
            {
                Obje = null;
                return;
            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            // Instanciar la logica del negocio
            Empleado Obje = new Empleado();

            try
            {
                string id_emp = txtcedula.Text;
                Obje.Id_Emp = id_emp;
                if (!Obje.consultar_empleado())
                {
                    MessageBox.Show(Obje.Error);
                }
                else
                {
                    SqlDataReader reader;
                    reader = Obje.Reader;
                    if (reader.HasRows)
                    {
                        reader.Read();
                        txtcedula.Text = reader.GetString(0); 
                        txtnombre.Text = reader.GetString(1);
                        txtapellido.Text = reader.GetString(2);
                        txttelefono.Text = reader.GetString(3);
                        txtsalario.Text = Convert.ToString(reader.GetDouble(4));
                        reader.Close();
                    }
                        
                }

            }
            catch(Exception Error)
            {
                MessageBox.Show(Error.Message);
                Obje = null;
            }
        }
    }
}
