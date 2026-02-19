using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Inventarios;
using static System.Net.WebRequestMethods;

namespace Sistema_Inventarios
{
    public partial class Menu : Form
    {
        private PruductosList productosForm;
        public Menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Supermol_Click(object sender, EventArgs e)
        {

        }

        private void btncategorias_Click(object sender, EventArgs e)
        {
            btnRe categoriasForm = new btnRe(productosForm); //Paso la instancia  de categorias
            categoriasForm.Show();
            this.Close();
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            PruductosList productos = new PruductosList();
            productos.Show();
            this.Close();
        }

        private void btninformes_Click(object sender, EventArgs e)
        {
            Informes frm = new Informes();
            frm.Show();
        }

        private void btnventas_Click(object sender, EventArgs e)
        {
            this.btnventas.Click += new System.EventHandler(this.btnventas_Click);
            Ventas ventas = new Ventas();
            ventas.Show();
            this.Hide();
        }

        private void btntutorial_Click(object sender, EventArgs e)//Muestro tutorial
        {
            DialogResult resultado = MessageBox.Show("¿Deseas ver el tutorial?", "Tutorial del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                string url = "https://youtu.be/FvveIt_2gZ0"; 
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
        }
    }
}

