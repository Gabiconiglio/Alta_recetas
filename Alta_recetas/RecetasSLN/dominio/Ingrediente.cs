using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.dominio
{
    internal class Ingrediente
    {
        private int nro_ingrediente;
        private string nombre;
        private string unidad;

        public int pNro_ingrediente
        {
            get { return nro_ingrediente; }
            set { nro_ingrediente = value; }
        }

        public string pNombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string pUnidad
        {
            get { return unidad; }
            set { unidad = value; }
        }

        public Ingrediente()
        {
            nro_ingrediente = 0;
            nombre = string.Empty;
            unidad= string.Empty;
        }

        public Ingrediente(int nro_ingrediente, string nombre, string unidad)
        {
            this.nro_ingrediente = nro_ingrediente;
            this.nombre = nombre;
            this.unidad = unidad;
        }

        public override string ToString()
        {
            return "Ingrediente: "+nombre+" Unidad:"+unidad;
        }
    }
}

