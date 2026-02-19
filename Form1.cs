namespace Sistema_Inventarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Valido datos
        private void btncontinuar_Click(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == "" || txtusuario.Text =="")
            {
                MessageBox.Show("Por favor ingrese los datos");
                txtcontraseña.Focus();
            }
            else if (txtcontraseña.Text == "1234" && txtusuario.Text=="admin")
            {
                MessageBox.Show("Datos correctos");
                this.Hide();
                Menu menu = new Menu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Datos incorrectos");
                txtcontraseña.Text = "";
                txtcontraseña.Focus();
            }
           
        }
    }
}
