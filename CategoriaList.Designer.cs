namespace Sistema_Inventarios
{
    partial class btnRe
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
            txtnuevacategoria = new TextBox();
            btnagregar = new Button();
            dgvCategorias = new DataGridView();
            label3 = new Label();
            btnregresar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(298, 18);
            label1.Name = "label1";
            label1.Size = new Size(183, 43);
            label1.TabIndex = 1;
            label1.Text = "Categorias";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(66, 86);
            label2.Name = "label2";
            label2.Size = new Size(222, 24);
            label2.TabIndex = 2;
            label2.Text = "Nombre nueva categoria:";
            // 
            // txtnuevacategoria
            // 
            txtnuevacategoria.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnuevacategoria.Location = new Point(294, 86);
            txtnuevacategoria.Name = "txtnuevacategoria";
            txtnuevacategoria.Size = new Size(187, 27);
            txtnuevacategoria.TabIndex = 5;
            // 
            // btnagregar
            // 
            btnagregar.BackColor = Color.Lavender;
            btnagregar.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnagregar.ForeColor = SystemColors.ControlText;
            btnagregar.Location = new Point(505, 86);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(107, 34);
            btnagregar.TabIndex = 7;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = false;
            btnagregar.Click += btnagregar_Click;
            // 
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(49, 173);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.Size = new Size(686, 265);
            dgvCategorias.TabIndex = 8;
            dgvCategorias.CellContentClick += dgvCategorias_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(306, 137);
            label3.Name = "label3";
            label3.Size = new Size(170, 24);
            label3.TabIndex = 9;
            label3.Text = "Lista de categorias";
            // 
            // btnregresar
            // 
            btnregresar.BackColor = Color.Lavender;
            btnregresar.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnregresar.ForeColor = SystemColors.ControlText;
            btnregresar.Location = new Point(23, 18);
            btnregresar.Name = "btnregresar";
            btnregresar.Size = new Size(45, 34);
            btnregresar.TabIndex = 11;
            btnregresar.Text = "←";
            btnregresar.UseVisualStyleBackColor = false;
            btnregresar.Click += btnregresar_Click;
            // 
            // btnRe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnregresar);
            Controls.Add(label3);
            Controls.Add(dgvCategorias);
            Controls.Add(btnagregar);
            Controls.Add(txtnuevacategoria);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "btnRe";
            Text = "CategoriaList";
            Load += CategoriaList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtnuevacategoria;
        private Button btnagregar;
        private DataGridView dgvCategorias;
        private Label label3;
        private Button btnregresar;
    }
}