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
    public partial class btnRe : Form
    {
        private PruductosList _productosForm;

        public btnRe(PruductosList productosForm)
        {
            InitializeComponent();
            _productosForm = productosForm;
        }


        private void CategoriaList_Load(object sender, EventArgs e)
        {
            InicializarDataGridView();  
            CargarCategorias();


        }
       

       
        private void InicializarDataGridView()
        {
            // Verificar si ya se ha agregado la columna
            if (dgvCategorias.Columns.Count == 0)
            {
                // Agrego la columna con el nombre "Categoría"
                dgvCategorias.Columns.Add("Categoria", "Categoría");

                // Configuro los datagrives
                dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;  
                dgvCategorias.AllowUserToAddRows = false;  
                dgvCategorias.ColumnHeadersVisible = true;  
            }


        }

       //Agrego categorias al datagruve
        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtnuevacategoria.Text))
            {
                Categorias nuevaCategoria = new Categorias
                {
                    Nombre = txtnuevacategoria.Text
                };

                Datos.Categorias.Add(nuevaCategoria);

                MessageBox.Show($"Categoría '{nuevaCategoria.Nombre}' agregada.");

                txtnuevacategoria.Clear();
                CargarCategorias();

                // Actualizo el ComboBox en el formulario de productos
                if (_productosForm != null)
                {
                    _productosForm.RecargarCategorias();
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un nombre para la categoría.");
            }

        }

        // Recarga las categorías en el DataGridView
        private void CargarCategorias()
        {
           
            dgvCategorias.Rows.Clear();

            // Verifico que la lista de categorías no sea nula
            if (Datos.Categorias != null && Datos.Categorias.Count > 0)
            {
                // Recorre la lista de categorías y se agregan al DataGridView
                foreach (var categoria in Datos.Categorias)
                {
                    // Valido que la categoria tenga un nombre
                    if (!string.IsNullOrEmpty(categoria.Nombre))
                    {
                        // Agrego la categoría al DataGridView
                        dgvCategorias.Rows.Add(categoria.Nombre);
                    }
                }
            }
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btntutorial_DockChanged(object sender, EventArgs e)
        {

        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }     
    
}
    
