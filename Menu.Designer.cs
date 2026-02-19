namespace Sistema_Inventarios
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            label1 = new Label();
            Supermol = new Label();
            pictureBox1 = new PictureBox();
            btntutorial = new Button();
            btninformes = new Button();
            btnproductos = new Button();
            btncategorias = new Button();
            btnventas = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(514, 34);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 24);
            label1.TabIndex = 0;
            // 
            // Supermol
            // 
            Supermol.AutoSize = true;
            Supermol.Font = new Font("Sitka Small", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Supermol.Location = new Point(664, 19);
            Supermol.Margin = new Padding(5, 0, 5, 0);
            Supermol.Name = "Supermol";
            Supermol.Size = new Size(167, 43);
            Supermol.TabIndex = 4;
            Supermol.Text = "Supermol";
            Supermol.Click += Supermol_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(-12, -3);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(572, 522);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btntutorial
            // 
            btntutorial.BackColor = Color.LightSlateGray;
            btntutorial.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btntutorial.ForeColor = SystemColors.ButtonHighlight;
            btntutorial.Location = new Point(649, 95);
            btntutorial.Margin = new Padding(5);
            btntutorial.Name = "btntutorial";
            btntutorial.Size = new Size(208, 62);
            btntutorial.TabIndex = 6;
            btntutorial.Text = "Tutorial";
            btntutorial.UseVisualStyleBackColor = false;
            btntutorial.Click += btntutorial_Click;
            // 
            // btninformes
            // 
            btninformes.BackColor = Color.LightSlateGray;
            btninformes.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btninformes.ForeColor = SystemColors.ButtonHighlight;
            btninformes.Location = new Point(649, 179);
            btninformes.Margin = new Padding(5);
            btninformes.Name = "btninformes";
            btninformes.Size = new Size(208, 62);
            btninformes.TabIndex = 7;
            btninformes.Text = "Informes";
            btninformes.UseVisualStyleBackColor = false;
            btninformes.Click += btninformes_Click;
            // 
            // btnproductos
            // 
            btnproductos.BackColor = Color.LightSlateGray;
            btnproductos.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnproductos.ForeColor = SystemColors.ButtonHighlight;
            btnproductos.Location = new Point(649, 265);
            btnproductos.Margin = new Padding(5);
            btnproductos.Name = "btnproductos";
            btnproductos.Size = new Size(208, 62);
            btnproductos.TabIndex = 8;
            btnproductos.Text = "Productos";
            btnproductos.UseVisualStyleBackColor = false;
            btnproductos.Click += btnproductos_Click;
            // 
            // btncategorias
            // 
            btncategorias.BackColor = Color.LightSlateGray;
            btncategorias.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncategorias.ForeColor = SystemColors.ButtonHighlight;
            btncategorias.Location = new Point(649, 354);
            btncategorias.Margin = new Padding(5);
            btncategorias.Name = "btncategorias";
            btncategorias.Size = new Size(208, 62);
            btncategorias.TabIndex = 9;
            btncategorias.Text = "Categorias";
            btncategorias.UseVisualStyleBackColor = false;
            btncategorias.Click += btncategorias_Click;
            // 
            // btnventas
            // 
            btnventas.BackColor = Color.LightSlateGray;
            btnventas.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnventas.ForeColor = SystemColors.ButtonHighlight;
            btnventas.Location = new Point(649, 435);
            btnventas.Margin = new Padding(5);
            btnventas.Name = "btnventas";
            btnventas.Size = new Size(208, 62);
            btnventas.TabIndex = 10;
            btnventas.Text = "Ventas";
            btnventas.UseVisualStyleBackColor = false;
            btnventas.Click += btnventas_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 513);
            Controls.Add(btnventas);
            Controls.Add(btncategorias);
            Controls.Add(btnproductos);
            Controls.Add(btninformes);
            Controls.Add(btntutorial);
            Controls.Add(pictureBox1);
            Controls.Add(Supermol);
            Controls.Add(label1);
            Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Menu";
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Supermol;
        private PictureBox pictureBox1;
        private Button btntutorial;
        private Button btninformes;
        private Button btnproductos;
        private Button btncategorias;
        private Button btnventas;
    }
}