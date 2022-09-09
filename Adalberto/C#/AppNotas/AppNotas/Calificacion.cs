using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNotas
{
    public class Calificacion
    {
        #region Atributos
        private string identificacion;
        private string nombre;
        private double nota1;
        private double nota2;
        private double nota3;
        private double nota4;
        private double promedio;
        private string error;
        #endregion

        #region metodos publicos
        public Calificacion()
        {
            nota1 = 0;
            nota2 = 0;
            nota3 = 0;
            nota4 = 0;
            promedio = 0;
            error = "";
        }
    
     #region propiedades
        public double setnota1
        {
            set { nota1 = value; }
        }
        public double setnota2
        {
            set { nota2 = value; }
        }
        public double setnota3
        {
            set { nota3 = value; }
        }
        public double setnota4
        {
            set { nota4 = value; }
        }
        public double getpromedio
        {
            get { return promedio; }
        }
        public string geterror
        {
            get { return error; }
        }

    #endregion
    public bool calcular()
        {
            if (!validar())
                return false;

            try
            {
                promedio = (nota1 + nota2 + nota3 + nota4) / 4;
                return true;
            }catch(Exception x)
            {
                error = x.Message;
                return false;
            }
            

        }
        #endregion

        #region metodos privados
        private bool validar()
        {
            if (nota1<0  || nota2<0 || nota3<0 || nota4 < 0 || nota1 > 5 || nota2 > 5 || nota3 > 5 || nota4 > 5)
            {
                error = "Los valores son negativos";
                return false;
            }
            return true;
        }
        #endregion

    }
}
