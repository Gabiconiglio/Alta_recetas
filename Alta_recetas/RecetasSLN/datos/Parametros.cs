using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.datos
{
    internal class Parametros
    {
        private string clave;
        private object valor;


        public string pClave
        {
            get { return clave; }
            set { clave = value; }
        }

        public object pValor
        {
            get { return valor; }
            set { valor = value; }
        }

        public Parametros()
        {
            clave = string.Empty;
            valor = null;
        }

        public Parametros(string clave, object valor)
        {
            this.clave = clave;
            this.valor = valor;
        }
    }
}
