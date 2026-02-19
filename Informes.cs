using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Inventarios
{
    public partial class Informes : Form
    {
        public Informes()
        {
            InitializeComponent();
        }

        private void Informes_Load(object sender, EventArgs e)
        {

            // Suscribir al evento para recibir la notificación de nueva venta
            var formularioVentas = Application.OpenForms["Ventas"] as Ventas;
            if (formularioVentas != null)
            {
                formularioVentas.VentaRegistrada += ActualizarDatos;
            }

            // Inicializamos el DataGridView
            dgvVentas.Columns.Clear();
            dgvVentas.Columns.Add("Fecha", "Fecha");
            dgvVentas.Columns.Add("Categoria", "Categoría");
            dgvVentas.Columns.Add("Producto", "Producto");
            dgvVentas.Columns.Add("Cantidad", "Cantidad");
            dgvVentas.Columns.Add("PrecioUnitario", "Precio Unitario");
            dgvVentas.Columns.Add("Total", "Total");
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.AllowUserToAddRows = false;

            // Cargamos las ventas al abrir
            CargarVentas();
        }
        private void ActualizarDatos()
        {
            // Actualizamos el DataGrid con las ventas
            CargarVentas();
        }

        private void CargarVentas()
        {
            dgvVentas.Rows.Clear();

            foreach (var venta in Datos.Ventas)
            {
                dgvVentas.Rows.Add(venta.Fecha.ToShortDateString(), venta.Categoria, venta.Producto, venta.Cantidad, venta.PrecioUnitario, venta.Total);
            }
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}
