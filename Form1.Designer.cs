namespace Sistema_Inventarios
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Supermol = new Label();
            txtusuario = new TextBox();
            txtcontraseña = new TextBox();
            btncontinuar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(125, 26);
            label1.Name = "label1";
            label1.Size = new Size(373, 43);
            label1.TabIndex = 0;
            label1.Text = "Sistema de inventarios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(125, 158);
            label2.Name = "label2";
            label2.Size = new Size(84, 24);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(125, 214);
            label3.Name = "label3";
            label3.Size = new Size(113, 24);
            label3.TabIndex = 2;
            label3.Text = "Contraseña:";
            // 
            // Supermol
            // 
            Supermol.AutoSize = true;
            Supermol.Font = new Font("Sitka Small", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Supermol.Location = new Point(252, 83);
            Supermol.Name = "Supermol";
            Supermol.Size = new Size(121, 31);
            Supermol.TabIndex = 3;
            Supermol.Text = "Supermol";
            // 
            // txtusuario
            // 
            txtusuario.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusuario.Location = new Point(244, 158);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(187, 27);
            txtusuario.TabIndex = 4;
            // 
            // txtcontraseña
            // 
            txtcontraseña.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcontraseña.Location = new Point(244, 211);
            txtcontraseña.Name = "txtcontraseña";
            txtcontraseña.PasswordChar = '*';
            txtcontraseña.Size = new Size(187, 27);
            txtcontraseña.TabIndex = 5;
            // 
            // btncontinuar
            // 
            btncontinuar.BackColor = Color.Lavender;
            btncontinuar.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncontinuar.Location = new Point(244, 277);
            btncontinuar.Name = "btncontinuar";
            btncontinuar.Size = new Size(143, 37);
            btncontinuar.TabIndex = 6;
            btncontinuar.Text = "Acceder";
            btncontinuar.UseVisualStyleBackColor = false;
            btncontinuar.Click += btncontinuar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(633, 376);
            Controls.Add(btncontinuar);
            Controls.Add(txtcontraseña);
            Controls.Add(txtusuario);
            Controls.Add(Supermol);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label Supermol;
        private TextBox txtusuario;
        private TextBox txtcontraseña;
        private Button btncontinuar;
    }
}
