using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.dominio
{
    internal class Receta
    {
        private int nro_receta;
        private string nombre;
        private TipoReceta nombre_receta;
        private string cheff;
        public List<DetalleReceta> DetalleRecetas { get; set; }  

        public int pNro_receta
        {
            get { return nro_receta; }
            set { nro_receta = value; }
        }

        public string pNombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public TipoReceta pNombre_receta
        {
            get { return nombre_receta; }
            set { nombre_receta = value; }
        }

        public string pCheff
        {
            get { return cheff; }
            set { cheff = value; }
        }

        public Receta()
        {
            nro_receta = 0;
            nombre=string.Empty;
            nombre_receta = new TipoReceta();
            cheff = string.Empty;
            DetalleRecetas = new List<DetalleReceta>();
        }

        public Receta(int nro_receta, string nombre, TipoReceta nombre_receta, string cheff, List<DetalleReceta> detalleRecetas)
        {
            this.nro_receta = nro_receta;
            this.nombre = nombre;
            this.nombre_receta = nombre_receta;
            this.cheff = cheff;
            this.DetalleRecetas = detalleRecetas;       
        }

        public void AgregarDetalle(DetalleReceta detalle)
        {
            DetalleRecetas.Add(detalle);
        }

        public void QuitarDetalle(int indice)
        {
            DetalleRecetas.RemoveAt(indice);
        }

        public int CalcularTotalIngredientes()
        {
           int total = 0;
            foreach (DetalleReceta item in DetalleRecetas)
            {
                total += item.pCantidad;
            }
            return total;
        }

        public override string ToString()
        {
            return "Nro receta: "+nro_receta+" Nombre: "+nombre;
        }
    }
}
