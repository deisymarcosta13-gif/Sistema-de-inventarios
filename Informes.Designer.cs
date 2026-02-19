namespace Sistema_Inventarios
{
    partial class Informes
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
            dgvVentas = new DataGridView();
            btnregresar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(230, 22);
            label1.Name = "label1";
            label1.Size = new Size(300, 43);
            label1.TabIndex = 2;
            label1.Text = "Informe de ventas";
            // 
            // dgvVentas
            // 
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(64, 91);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.Size = new Size(684, 294);
            dgvVentas.TabIndex = 3;
            // 
            // btnregresar
            // 
            btnregresar.BackColor = Color.Lavender;
            btnregresar.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnregresar.ForeColor = SystemColors.ControlText;
            btnregresar.Location = new Point(31, 31);
            btnregresar.Name = "btnregresar";
            btnregresar.Size = new Size(45, 34);
            btnregresar.TabIndex = 12;
            btnregresar.Text = "←";
            btnregresar.UseVisualStyleBackColor = false;
            btnregresar.Click += btnregresar_Click;
            // 
            // Informes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnregresar);
            Controls.Add(dgvVentas);
            Controls.Add(label1);
            Name = "Informes";
            Text = "Informes";
            Load += Informes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvVentas;
        private Button btnregresar;
    }
}