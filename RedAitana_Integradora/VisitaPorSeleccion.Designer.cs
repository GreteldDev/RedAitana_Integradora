namespace RedAitana_Integradora
{
    partial class VisitaPorSeleccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitaPorSeleccion));
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            btnRegistroSalida = new Button();
            txtBuscar = new TextBox();
            label10 = new Label();
            btnRegistroEntrada = new Button();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(btnRegistroSalida);
            panel1.Controls.Add(txtBuscar);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(btnRegistroEntrada);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(224, 200, 232);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(152, 190);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(493, 160);
            dataGridView1.TabIndex = 71;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnRegistroSalida
            // 
            btnRegistroSalida.BackColor = Color.FromArgb(177, 135, 193);
            btnRegistroSalida.FlatAppearance.BorderSize = 0;
            btnRegistroSalida.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 128, 108);
            btnRegistroSalida.FlatStyle = FlatStyle.Flat;
            btnRegistroSalida.ForeColor = Color.White;
            btnRegistroSalida.Location = new Point(501, 375);
            btnRegistroSalida.Name = "btnRegistroSalida";
            btnRegistroSalida.Size = new Size(144, 58);
            btnRegistroSalida.TabIndex = 70;
            btnRegistroSalida.Text = "Registrar Salida";
            btnRegistroSalida.UseVisualStyleBackColor = false;
            btnRegistroSalida.Click += btnRegistroSalida_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(151, 131);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar...";
            txtBuscar.Size = new Size(494, 27);
            txtBuscar.TabIndex = 69;
            txtBuscar.TextChanged += textBox1_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(263, 152);
            label10.Name = "label10";
            label10.Size = new Size(0, 20);
            label10.TabIndex = 68;
            // 
            // btnRegistroEntrada
            // 
            btnRegistroEntrada.BackColor = Color.FromArgb(177, 135, 193);
            btnRegistroEntrada.FlatAppearance.BorderSize = 0;
            btnRegistroEntrada.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 128, 108);
            btnRegistroEntrada.FlatStyle = FlatStyle.Flat;
            btnRegistroEntrada.ForeColor = Color.White;
            btnRegistroEntrada.Location = new Point(342, 375);
            btnRegistroEntrada.Name = "btnRegistroEntrada";
            btnRegistroEntrada.Size = new Size(144, 58);
            btnRegistroEntrada.TabIndex = 67;
            btnRegistroEntrada.Text = "Registrar Entrada";
            btnRegistroEntrada.UseVisualStyleBackColor = false;
            btnRegistroEntrada.Click += btnRegistroEntrada_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(555, 17);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(112, 74);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 66;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(129, 80);
            label4.Name = "label4";
            label4.Size = new Size(543, 20);
            label4.TabIndex = 64;
            label4.Text = "_________________________________________________________________________________________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(71, 48, 120);
            label3.Location = new Point(152, 33);
            label3.Name = "label3";
            label3.Size = new Size(403, 37);
            label3.TabIndex = 65;
            label3.Text = "Registro de Entrada/Salida";
            // 
            // VisitaPorSeleccion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "VisitaPorSeleccion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VisitaPorSeleccion";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Button btnRegistroSalida;
        private TextBox txtBuscar;
        private Label label10;
        private Button btnRegistroEntrada;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label3;
    }
}