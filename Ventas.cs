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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            cmbProductos.SelectedIndexChanged += cmbProductos_SelectedIndexChanged;
            txtcantidad.TextChanged += txtcantidad_TextChanged;

            //Cagro productos en el ComboBox
            cmbProductos.DataSource = null;
            cmbProductos.DataSource = Datos.Productos;
            cmbProductos.DisplayMember = "Nombre";

            cmbcategorias.DataSource = null;
            cmbcategorias.DataSource = Datos.Categorias;
            cmbcategorias.DisplayMember = "Nombre";

        }
        // Definir un evento en el formulario de Ventas
        public event Action VentaRegistrada;
        private void btnagregarventa_Click(object sender, EventArgs e)
        {
            // Validación de cantidad
            if (!int.TryParse(txtcantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.");
                return;
            }

            Producto productoSeleccionado = (Producto)cmbProductos.SelectedItem;

            // Validación de producto seleccionado
            if (productoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un producto.");
                return;
            }

            // Validación de stock
            if (productoSeleccionado.Stock < cantidad)
            {
                MessageBox.Show("No hay suficiente stock disponible.");
                return;
            }

            double total = cantidad * productoSeleccionado.Precio;

            // Crear nueva venta
            Venta nuevaVenta = new Venta
            {
                Fecha = DateTime.Now,
                Categoria = productoSeleccionado.Categoria.Nombre,
                Producto = productoSeleccionado.Nombre,
                Cantidad = cantidad,
                PrecioUnitario = productoSeleccionado.Precio,
                Total = total
            };



            // Agregar la venta a la lista
            Datos.Ventas.Add(nuevaVenta);

            // Actualizar stock
            productoSeleccionado.Stock -= cantidad;

            // Mensaje de éxito
            MessageBox.Show("Venta registrada correctamente.");

            // Limpiar los campos
            txtcantidad.Clear();
            cmbProductos.SelectedIndex = -1;

            // Notificar a otros formularios (como Informes)
            VentaRegistrada?.Invoke();  // Se dispara el eventol evento
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProductos.SelectedItem is Producto productoSeleccionado)
            {
                txtvalorproducto.Text = productoSeleccionado.Precio.ToString("N0"); 
                CalcularTotal();
            }
        }

        private void txtcantidad_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        //metodo para calcular el total de los productos
        private void CalcularTotal()
        {
            if (cmbProductos.SelectedItem is Producto productoSeleccionado &&
                int.TryParse(txtcantidad.Text, out int cantidad) &&
                cantidad > 0)
            {
                double total = cantidad * productoSeleccionado.Precio;
                txtvalortotal.Text = total.ToString("N0");
            }
            else
            {
                txtvalortotal.Text = ""; // Borra si hay datos inválidos
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtvalorproducto.Clear();
            txtvalortotal.Clear();
            txtcantidad.Clear();
        }
    }
}
