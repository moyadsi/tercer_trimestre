using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//usar libreria conexon
using LibConexionBD;
using LibLlenarGrid;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace LibLN_Empleado
{
    public class Empleado
    {
        #region atributos
        private string id_Emp;
        private string nombre;
        private string apellido;
        private string telefono;
        private double salario;
        private string error;
        private SqlDataReader reader;
        #endregion

        #region metodos publicos
        public bool grabar_empleado()
        {
            ClsConexion Objc = new ClsConexion();
            string sentencia = "execute USP_grabar_Emp '" + id_Emp + "','" + nombre + "','" + apellido + "','" + telefono + "'," + salario;
            if (!Objc.EjecutarSentencia(sentencia, false))
            {
                error = Objc.Error;
                Objc = null;
                return false;
            }
            error = "Se guardo exitosamente";
            Objc = null;
            return true;
        }

        public bool listar_empleado(DataGridView ObjGdv)
        {
            ClsLlenarGrid Objg = new ClsLlenarGrid();
            Objg.NombreTabla = "Datos Empleados";
            Objg.SQL = "execute USP_lista_Emp";
            if (!Objg.LlenarGrid(ObjGdv))
            {

                error = Objg.Error;
                Objg = null;
                return false;
            }

            Objg = null;
            return true;
        }

        public bool consultar_empleado()
        {
            ClsConexion Objconexion = new ClsConexion();
            string sentencia = "execute USP_consultar_Emp '" + id_Emp + "'";
            if (!Objconexion.Consultar(sentencia,false))
            {

                error = Objconexion.Error;
                Objconexion = null;
                return false;
            }

            Reader = Objconexion.Reader;
            Objconexion = null;
            return true;
        }


        public bool actualizar_empleado()
        {
            ClsConexion Objc = new ClsConexion();
            string sentencia = "execute USP_actualizar_Emp '" + id_Emp + "','" + nombre + "','" + apellido + "','" + telefono + "'," + salario;
            if (!Objc.EjecutarSentencia(sentencia, false))
            {
                error = Objc.Error;
                Objc = null;
                return false;
            }
            error = "Se actualizo exitosamente";
            Objc = null;
            return true;
        }
        #endregion

        #region metodos publicos
        public bool eliminar_empleado()
        {
            ClsConexion Objc = new ClsConexion();
            string sentencia = "execute USP_eliminar_Emp '" + id_Emp +"'";
            if (!Objc.EjecutarSentencia(sentencia, false))
            {
                error = Objc.Error;
                Objc = null;
                return false;
            }
            error = "Se elimino exitosamente";
            Objc = null;
            return true;
        }
        #endregion

        #region propiedades
        public string Id_Emp { get => id_Emp; set => id_Emp = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public double Salario { get => salario; set => salario = value; }
        public string Error { get => error; set => error = value; }
        public SqlDataReader Reader { get => reader; set => reader = value; }
        #endregion


        #region metodos privados
        #endregion
    }
}
