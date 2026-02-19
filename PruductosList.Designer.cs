namespace Sistema_Inventarios
{
    partial class PruductosList
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNombreProducto = new TextBox();
            txtPrecioProducto = new TextBox();
            txtStockProducto = new TextBox();
            cmbCategorias = new ComboBox();
            btnAgregarProducto = new Button();
            label6 = new Label();
            dgvProductos = new DataGridView();
            btnregresar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(323, 20);
            label1.Name = "label1";
            label1.Size = new Size(173, 43);
            label1.TabIndex = 2;
            label1.Text = "Productos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(72, 85);
            label2.Name = "label2";
            label2.Size = new Size(83, 24);
            label2.TabIndex = 3;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(72, 124);
            label3.Name = "label3";
            label3.Size = new Size(69, 24);
            label3.TabIndex = 4;
            label3.Text = "Precio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(367, 85);
            label4.Name = "label4";
            label4.Size = new Size(98, 24);
            label4.TabIndex = 5;
            label4.Text = "Categoria:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(367, 124);
            label5.Name = "label5";
            label5.Size = new Size(62, 24);
            label5.TabIndex = 6;
            label5.Text = "Stock:";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreProducto.Location = new Point(161, 85);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(187, 27);
            txtNombreProducto.TabIndex = 7;
            // 
            // txtPrecioProducto
            // 
            txtPrecioProducto.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecioProducto.Location = new Point(147, 124);
            txtPrecioProducto.Name = "txtPrecioProducto";
            txtPrecioProducto.Size = new Size(187, 27);
            txtPrecioProducto.TabIndex = 8;
            // 
            // txtStockProducto
            // 
            txtStockProducto.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStockProducto.Location = new Point(435, 124);
            txtStockProducto.Name = "txtStockProducto";
            txtStockProducto.Size = new Size(187, 27);
            txtStockProducto.TabIndex = 9;
            // 
            // cmbCategorias
            // 
            cmbCategorias.Font = new Font("Sitka Small", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategorias.FormattingEnabled = true;
            cmbCategorias.Location = new Point(471, 86);
            cmbCategorias.Name = "cmbCategorias";
            cmbCategorias.Size = new Size(161, 27);
            cmbCategorias.TabIndex = 10;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = Color.Lavender;
            btnAgregarProducto.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarProducto.ForeColor = SystemColors.ControlText;
            btnAgregarProducto.Location = new Point(654, 121);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(134, 34);
            btnAgregarProducto.TabIndex = 11;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(328, 166);
            label6.Name = "label6";
            label6.Size = new Size(168, 24);
            label6.TabIndex = 12;
            label6.Text = "Lista de productos";
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(54, 203);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(686, 235);
            dgvProductos.TabIndex = 13;
            // 
            // btnregresar
            // 
            btnregresar.BackColor = Color.Lavender;
            btnregresar.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnregresar.ForeColor = SystemColors.ControlText;
            btnregresar.Location = new Point(26, 20);
            btnregresar.Name = "btnregresar";
            btnregresar.Size = new Size(45, 34);
            btnregresar.TabIndex = 14;
            btnregresar.Text = "←";
            btnregresar.UseVisualStyleBackColor = false;
            btnregresar.Click += btnregresar_Click;
            // 
            // PruductosList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnregresar);
            Controls.Add(dgvProductos);
            Controls.Add(label6);
            Controls.Add(btnAgregarProducto);
            Controls.Add(cmbCategorias);
            Controls.Add(txtStockProducto);
            Controls.Add(txtPrecioProducto);
            Controls.Add(txtNombreProducto);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PruductosList";
            Text = "PruductosList";
            Load += PruductosList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNombreProducto;
        private TextBox txtPrecioProducto;
        private TextBox txtStockProducto;
        private Button btnAgregarProducto;
        private Label label6;
        private DataGridView dgvProductos;
        private Button btnregresar;
        public ComboBox cmbCategorias;
    }
}