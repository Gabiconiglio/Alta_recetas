using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecetasSLN.datos;
using RecetasSLN.dominio;

namespace RecetasSLN.datos
{
    internal class HelperDb
    {
        private static HelperDb instancia;
        SqlConnection cnn = new SqlConnection(Properties.Resources.conexion);

        public static HelperDb ObtenerInstancia() //singleton
        {
            if (instancia == null)
            {
                instancia = new HelperDb();
            }
            return instancia;
        }

        public DataTable CargaCombo(string nombre_sp, List<Parametros> values)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmdCombo = new SqlCommand();
            cnn.Open();
            cmdCombo.Connection = cnn;
            cmdCombo.CommandText = nombre_sp;
            cmdCombo.CommandType = CommandType.StoredProcedure;

            if (values != null)
            {
                foreach (Parametros oParametro in values)
                {
                    cmdCombo.Parameters.AddWithValue(oParametro.pClave, oParametro.pValor);
                }
            }
            tabla.Load(cmdCombo.ExecuteReader());
            cnn.Close();
            return tabla;
        }

        public int ObtenerProximo(string sp, string nombre_out)
        {
            SqlCommand cmdProx = new SqlCommand();
            cnn.Open();
            cmdProx.Connection = cnn;
            cmdProx.CommandText = sp;
            cmdProx.CommandType = CommandType.StoredProcedure;
            SqlParameter Output = new SqlParameter();
            Output.ParameterName = nombre_out;
            Output.Direction = ParameterDirection.Output;
            Output.DbType = DbType.Int32;
            cmdProx.Parameters.Add(Output);
            cmdProx.ExecuteNonQuery();
            cnn.Close();
            return (int)Output.Value;
        }

        public bool ConfirmarReceta(Receta oReceta)
        {
            bool ok = true;
            SqlTransaction t = null;
            SqlCommand cmdGrabar = new SqlCommand();
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                cmdGrabar.Connection = cnn;
                cmdGrabar.Transaction = t;
                cmdGrabar.CommandText = "SP_INSERTAR_RECETA";
                cmdGrabar.CommandType = CommandType.StoredProcedure;
                cmdGrabar.Parameters.AddWithValue("@NOMBRE", oReceta.pNombre);
                cmdGrabar.Parameters.AddWithValue("@CHEFF", oReceta.pCheff);
                cmdGrabar.Parameters.AddWithValue("@TIPO_RECETA", oReceta.pNombre_receta.pNro_tipo_receta);

                //parametros de salida

                SqlParameter pOut = new SqlParameter();
                pOut.ParameterName = "@NEXT";
                pOut.DbType = DbType.Int32;
                pOut.Direction = ParameterDirection.Output;
                cmdGrabar.Parameters.Add(pOut);
                cmdGrabar.ExecuteNonQuery();

                int nro_receta = (int)pOut.Value;

                SqlCommand cmdDetalle;
                foreach (DetalleReceta item in oReceta.DetalleRecetas)
                {
                    cmdDetalle = new SqlCommand("SP_CARGA_DETALLE_RECETA", cnn, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@NEXT", nro_receta);
                    cmdDetalle.Parameters.AddWithValue("@ID_INGREDIENTE", item.pIngrediente.pNro_ingrediente);
                    cmdDetalle.Parameters.AddWithValue("@CANTIDAD", item.pCantidad);
                    cmdDetalle.ExecuteNonQuery();
                }
                t.Commit();
            }
            catch (Exception ex)
            {
                if (t != null)
                {
                    t.Rollback();
                    ok = false;
                }
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                { 
                    cnn.Close();  
                }
            }
            return ok;
        }
    }
}
