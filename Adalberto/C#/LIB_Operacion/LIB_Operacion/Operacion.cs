using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_Operacion
{
    public class Operacion
    {
        #region Atributos
        private int n1;
        private int n2;
        private int suma;
        private string error;
        #endregion

        #region Metodos publicos
        public Operacion()
        {
            n1 = 0;
            n2 = 0;
            suma= 0;
            error = "";
        }
        public bool calcular()
        {
            if(!validar())
                return false;
            try
            {
                suma = n1 + n2;
                return true;
            }
            catch(Exception ex)
            {
                error =ex.Message;
                return false;
            }
        }
        #endregion

        #region Metodos Privados
            private bool validar()
        {
            if (n1 < 0 || n2 < 0)
            {
                error = "Valores negativos";
                return false;
            }
            return true;
        }
        #endregion
        #region Propiedades
        public int setN1
        {
            set { n1= value; }
        }
        public int SetN2
        {
            set { n2 = value; }
        }
        public int GetSuma
        {
            get { return suma; }
        }
        public string GetError
        {
            get { return error; }
        }
        #endregion
    }
}
