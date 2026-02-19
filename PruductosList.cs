using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Inventarios;

namespace Sistema_Inventarios
{
    public partial class PruductosList : Form
    {
        public PruductosList()
        {
            InitializeComponent();
        }
       
        private void PruductosList_Load(object sender, EventArgs e)
        {
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //Agregamos columnas al datagruve
            if (dgvProductos.Columns.Count == 0)
            {
                dgvProductos.Columns.Add("Nombre", "Nombre");
                dgvProductos.Columns.Add("Stock", "Stock");
                dgvProductos.Columns.Add("Categoria", "Categoría");
                dgvProductos.Columns.Add("Precio", "Precio"); 
            }

            // Agrego categorias por defecto enn caso d eque no haya agregado
            if (Datos.Categorias.Count == 0)
            {
                Datos.Categorias.Add(new Categorias { Nombre = "Electrónica" });
                Datos.Categorias.Add(new Categorias { Nombre = "Ropa" });
                Datos.Categorias.Add(new Categorias { Nombre = "Alimentos" });
            }
            dgvProductos.AllowUserToAddRows = false;

            
            CargarProductos();

            RecargarCategorias();
        }

        public void RecargarCategorias()
        {
            cmbCategorias.DataSource = null;  
            cmbCategorias.DataSource = Datos.Categorias;  
            cmbCategorias.DisplayMember = "Nombre";  
            //lleno el combo box de categorias con las que eagregado

        }


        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtPrecioProducto.Text, out double precio))
            {
                MessageBox.Show("Por favor, ingrese un precio válido.");
                return;
            }

            // Valido nombre
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre para el producto.");
                return;
            }

            // Valido stock
            if (!int.TryParse(txtStockProducto.Text, out int stock))
            {
                MessageBox.Show("Por favor, ingrese un número válido para el stock.");
                return;
            }

            // Valido categoría seleccionada
            Categorias categoriaSeleccionada = (Categorias)cmbCategorias.SelectedItem;
            if (categoriaSeleccionada == null)
            {
                MessageBox.Show("Por favor, seleccione una categoría.");
                return;
            }

            // Verifico que no se repita el nombre del producto
            bool productoExistente = Datos.Productos.Any(p => p.Nombre.Equals(txtNombreProducto.Text, StringComparison.OrdinalIgnoreCase));
            if (productoExistente)
            {
                MessageBox.Show("Ya existe un producto con ese nombre.");
                return;
            }

            // Creo el producto
            Producto nuevoProducto = new Producto
            {
                Nombre = txtNombreProducto.Text,
                Stock = stock,
                Categoria = categoriaSeleccionada,
                Precio = precio
            };
            //Añado el producto a la  lista de productos
            Datos.Productos.Add(nuevoProducto);

            // Lo que se muestra en el datagruve
            dgvProductos.Rows.Add(nuevoProducto.Nombre, nuevoProducto.Stock, nuevoProducto.Categoria.Nombre, nuevoProducto.Precio);

            MessageBox.Show($"Producto '{nuevoProducto.Nombre}' agregado a la categoría '{nuevoProducto.Categoria.Nombre}'");

            // Limpiar campos
            txtNombreProducto.Clear();
            txtStockProducto.Clear();
            txtPrecioProducto.Clear();
            cmbCategorias.SelectedIndex = -1;
        }
        private void CargarProductos()
        {
            // Limpio todas las filas antes de agregar nuevas
            dgvProductos.Rows.Clear();

            // Recorrer la lista de productos para agregar al datgruve
            foreach (var producto in Datos.Productos)
            {
                // Valido que el producto no sea nulo o vacio
                if (producto != null)
                {
                    dgvProductos.Rows.Add(producto.Nombre, producto.Stock, producto.Categoria.Nombre, producto.Precio);
                }
            }
        }

        //Regreso al menu principal 
        private void btnregresar_Click(object sender, EventArgs e)
        {
            
            Menu menu = new Menu();
            menu.Show();
            this.Close();

        }
       
    }
}
    

