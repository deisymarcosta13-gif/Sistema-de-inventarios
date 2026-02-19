namespace Sistema_Inventarios
{
    partial class Ventas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtcantidad = new TextBox();
            txtvalorproducto = new TextBox();
            txtvalortotal = new TextBox();
            cmbProductos = new ComboBox();
            btnagregarventa = new Button();
            btnlimpiar = new Button();
            btnregresar = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label7 = new Label();
            cmbcategorias = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(335, 9);
            label1.Name = "label1";
            label1.Size = new Size(123, 43);
            label1.TabIndex = 2;
            label1.Text = "Ventas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(83, 106);
            label3.Name = "label3";
            label3.Size = new Size(93, 24);
            label3.TabIndex = 4;
            label3.Text = "Producto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(82, 206);
            label4.Name = "label4";
            label4.Size = new Size(94, 24);
            label4.TabIndex = 5;
            label4.Text = "Cantidad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(78, 263);
            label5.Name = "label5";
            label5.Size = new Size(136, 24);
            label5.TabIndex = 6;
            label5.Text = "Valor unitario:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(81, 331);
            label6.Name = "label6";
            label6.Size = new Size(107, 24);
            label6.TabIndex = 7;
            label6.Text = "Valor total:";
            // 
            // txtcantidad
            // 
            txtcantidad.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcantidad.Location = new Point(182, 206);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(187, 27);
            txtcantidad.TabIndex = 8;
            txtcantidad.TextChanged += txtcantidad_TextChanged;
            // 
            // txtvalorproducto
            // 
            txtvalorproducto.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtvalorproducto.Location = new Point(220, 263);
            txtvalorproducto.Name = "txtvalorproducto";
            txtvalorproducto.Size = new Size(187, 27);
            txtvalorproducto.TabIndex = 9;
            // 
            // txtvalortotal
            // 
            txtvalortotal.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtvalortotal.Location = new Point(194, 331);
            txtvalortotal.Name = "txtvalortotal";
            txtvalortotal.Size = new Size(187, 27);
            txtvalortotal.TabIndex = 10;
            // 
            // cmbProductos
            // 
            cmbProductos.Font = new Font("Sitka Small", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Location = new Point(194, 103);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(172, 27);
            cmbProductos.TabIndex = 12;
            cmbProductos.SelectedIndexChanged += cmbProductos_SelectedIndexChanged;
            // 
            // btnagregarventa
            // 
            btnagregarventa.BackColor = Color.MediumSeaGreen;
            btnagregarventa.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnagregarventa.ForeColor = SystemColors.ControlLightLight;
            btnagregarventa.Location = new Point(603, 387);
            btnagregarventa.Name = "btnagregarventa";
            btnagregarventa.Size = new Size(150, 42);
            btnagregarventa.TabIndex = 13;
            btnagregarventa.Text = "Realizar venta \U0001f6d2";
            btnagregarventa.UseVisualStyleBackColor = false;
            btnagregarventa.Click += btnagregarventa_Click;
            // 
            // btnlimpiar
            // 
            btnlimpiar.BackColor = Color.Red;
            btnlimpiar.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlimpiar.ForeColor = SystemColors.ControlLightLight;
            btnlimpiar.Location = new Point(51, 387);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(150, 42);
            btnlimpiar.TabIndex = 14;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = false;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // btnregresar
            // 
            btnregresar.BackColor = Color.Lavender;
            btnregresar.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnregresar.ForeColor = SystemColors.ControlText;
            btnregresar.Location = new Point(12, 9);
            btnregresar.Name = "btnregresar";
            btnregresar.Size = new Size(45, 34);
            btnregresar.TabIndex = 15;
            btnregresar.Text = "←";
            btnregresar.UseVisualStyleBackColor = false;
            btnregresar.Click += btnregresar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(479, 92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(274, 266);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MediumSeaGreen;
            label2.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(67, 51);
            label2.Name = "label2";
            label2.Size = new Size(147, 24);
            label2.TabIndex = 17;
            label2.Text = "Realiza tu venta";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(78, 154);
            label7.Name = "label7";
            label7.Size = new Size(98, 24);
            label7.TabIndex = 18;
            label7.Text = "Categoria:";
            // 
            // cmbcategorias
            // 
            cmbcategorias.Font = new Font("Sitka Small", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbcategorias.FormattingEnabled = true;
            cmbcategorias.Location = new Point(194, 154);
            cmbcategorias.Name = "cmbcategorias";
            cmbcategorias.Size = new Size(172, 27);
            cmbcategorias.TabIndex = 19;
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbcategorias);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(btnregresar);
            Controls.Add(btnlimpiar);
            Controls.Add(btnagregarventa);
            Controls.Add(cmbProductos);
            Controls.Add(txtvalortotal);
            Controls.Add(txtvalorproducto);
            Controls.Add(txtcantidad);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Ventas";
            Text = "Ventas";
            Load += Ventas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtcantidad;
        private TextBox txtvalorproducto;
        private TextBox txtvalortotal;
        private ComboBox cmbProductos;
        private Button btnagregarventa;
        private Button btnlimpiar;
        private Button btnregresar;
        public PictureBox pictureBox1;
        private Label label2;
        private Label label7;
        private ComboBox cmbcategorias;
    }
}