using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.dominio
{
    internal class DetalleReceta
    {
        private int nro_detalle_receta;
        private Ingrediente ingrediente;
        private int cantidad;


        public int pNro_detalle_receta
        {
            get { return nro_detalle_receta; }
            set { nro_detalle_receta = value; }
        }

        public Ingrediente pIngrediente
        {
            get { return ingrediente; }
            set { ingrediente = value; }
        }

        public int pCantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public DetalleReceta()
        { 
            nro_detalle_receta=0;
            ingrediente=null;
            cantidad = 0;
        }

        public DetalleReceta(Ingrediente ingrediente, int cantidad)
        {
            this.ingrediente = ingrediente;
            this.cantidad = cantidad;
        }

        public override string ToString()
        {
            return " Ingrediente: "+ingrediente+" Cantidad: "+cantidad;
        }

    }
}
