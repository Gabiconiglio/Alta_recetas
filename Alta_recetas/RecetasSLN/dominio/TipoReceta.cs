using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.dominio
{
    internal class TipoReceta
    {
        private int nro_tipo_receta;
        private string nombre_tipo_receta;

        public int pNro_tipo_receta
        {
            get { return nro_tipo_receta; }
            set { nro_tipo_receta = value; }
        }

        public string pNombre_tipo_receta
        {
            get {return nombre_tipo_receta;}
            set { nombre_tipo_receta = value; }
        }

        public TipoReceta()
        {
            nro_tipo_receta = 0;
            nombre_tipo_receta = string.Empty;
        }

        public TipoReceta(int nro_tipo_receta, string nombre_tipo_receta)        {
            this.nro_tipo_receta = nro_tipo_receta;
            this.nombre_tipo_receta = nombre_tipo_receta;
        }

        public override string ToString()
        {
            return "Tipo de receta: "+nombre_tipo_receta;
        }

    }
}
