using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using RecetasSLN.dominio;
using RecetasSLN.datos;
using RecetasSLN.presentación;

namespace RecetasSLN
{
    public partial class AltaRecetas : Form
    {
        private Receta nueva;
        private HelperDb gestor;

        public AltaRecetas()
        {
            InitializeComponent();
            gestor = new HelperDb();
            nueva = new Receta();
        }

        private void lblNroReceta_Click(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void AltaRecetas_Load(object sender, EventArgs e)
        {
            CargarCombo("SP_CONSULTAR_INGREDIENTES", CmbIngredientes);
            CargarCombo("SP_CONSULTAR_TIPOS_RECETAS", CmbTipoReceta);
            ProximaFactura("SP_PROXIMA_FACTURA", "@Next");
            Limpiar();
        }

        private void Limpiar()
        {
            TxtNombre.Text = "";
            TxtCheff.Text = "";
            CmbTipoReceta.SelectedIndex = -1;
            CmbIngredientes.SelectedIndex = -1;
        }

        private void CargarCombo(string sp, ComboBox combo)
        {
            DataTable tabla = gestor.CargaCombo(sp, null);
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
        }

        private void ProximaFactura(string sp, string outPut)
        {
            int next = gestor.ObtenerProximo(sp, outPut);

            if (next == 0)
            {
                next = 1;
                lblNroReceta.Text = "N° de Receta: " + next.ToString();
            }
            if (next > 0)
            {
                lblNroReceta.Text = "N° de Receta: " + next.ToString();
            }
        }

        private void CalcularIngredientes()
        { 
            int total=nueva.CalcularTotalIngredientes();
            lblTotalIng.Text="Cantidad Ingredientes: "+total.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(CmbIngredientes.Text.Equals(string.Empty))
            {
                MessageBox.Show("No se ingreso ningún Articulo a la lista!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (NudCantidad.Value == 0)
            {
                MessageBox.Show("No se ingreso la cantidad del articulo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (DataGridViewRow row in DgwIngredientes.Rows)
            {
                if (row.Cells["Ingredientes"].Value == null)
                {
                    break;
                }
                if (row.Cells["Ingredientes"].Value.ToString().Equals(CmbIngredientes.Text))
                {
                    MessageBox.Show("El Ingrediente: " + CmbIngredientes.Text + " Ya fue ingresado en la lista!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

                DataRowView item = (DataRowView)CmbIngredientes.SelectedItem;
                int codigo = Convert.ToInt32(item.Row.ItemArray[0]);
                string nombre = item.Row.ItemArray[1].ToString();
                string unidad =item.Row.ItemArray[2].ToString();

                Ingrediente oIngrediente= new Ingrediente(codigo, nombre, unidad);

                int cantidad = Convert.ToInt32(NudCantidad.Value);
                DetalleReceta detalle = new DetalleReceta(oIngrediente, cantidad);

                nueva.AgregarDetalle(detalle);
                DgwIngredientes.Rows.Add(new object[] { item.Row.ItemArray[0], item.Row.ItemArray[1], item.Row.ItemArray[2], NudCantidad.Value });

                CalcularIngredientes();
        }

        private void DgwIngredientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgwIngredientes.CurrentCell.ColumnIndex == 4)
            {
                nueva.QuitarDetalle(DgwIngredientes.CurrentRow.Index);
                DgwIngredientes.Rows.Remove(DgwIngredientes.CurrentRow);
                CalcularIngredientes();
            }
        }

        private void GuardarReceta()
        {
            nueva.pNombre = TxtNombre.Text;
            nueva.pCheff = TxtCheff.Text;
            nueva.pNombre_receta.pNro_tipo_receta =Convert.ToInt32(CmbTipoReceta.SelectedValue);

            if (gestor.ConfirmarReceta(nueva))
            {
                MessageBox.Show("Se pudo cargar la receta correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("No Se pudo cargar la receta correctamente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (TxtNombre.Text == "")
            {
                MessageBox.Show("No se ingreso el nombre de la receta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TxtCheff.Text == "")
            {
                MessageBox.Show("No se ingreso el nombre del Cheff!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (CmbTipoReceta.SelectedIndex==-1)
            {
                MessageBox.Show("No se Selecciono el tipo de la receta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DgwIngredientes.Rows.Count==0)
            {
                MessageBox.Show("No se ingreso un ingrediente al detalle!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            GuardarReceta();
        }
    }
}
