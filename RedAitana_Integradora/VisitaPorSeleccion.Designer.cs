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
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 562);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(190, 238);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(616, 200);
            dataGridView1.TabIndex = 71;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnRegistroSalida
            // 
            btnRegistroSalida.BackColor = Color.FromArgb(177, 135, 193);
            btnRegistroSalida.FlatStyle = FlatStyle.Flat;
            btnRegistroSalida.ForeColor = Color.White;
            btnRegistroSalida.Location = new Point(626, 469);
            btnRegistroSalida.Margin = new Padding(4);
            btnRegistroSalida.Name = "btnRegistroSalida";
            btnRegistroSalida.Size = new Size(180, 72);
            btnRegistroSalida.TabIndex = 70;
            btnRegistroSalida.Text = "Registrar Salida";
            btnRegistroSalida.UseVisualStyleBackColor = false;
            btnRegistroSalida.Click += btnRegistroSalida_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(190, 184);
            txtBuscar.Margin = new Padding(4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar...";
            txtBuscar.Size = new Size(616, 31);
            txtBuscar.TabIndex = 69;
            txtBuscar.TextChanged += textBox1_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(329, 190);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(0, 25);
            label10.TabIndex = 68;
            // 
            // btnRegistroEntrada
            // 
            btnRegistroEntrada.BackColor = Color.FromArgb(177, 135, 193);
            btnRegistroEntrada.FlatStyle = FlatStyle.Flat;
            btnRegistroEntrada.ForeColor = Color.White;
            btnRegistroEntrada.Location = new Point(428, 469);
            btnRegistroEntrada.Margin = new Padding(4);
            btnRegistroEntrada.Name = "btnRegistroEntrada";
            btnRegistroEntrada.Size = new Size(180, 72);
            btnRegistroEntrada.TabIndex = 67;
            btnRegistroEntrada.Text = "Registrar Entrada";
            btnRegistroEntrada.UseVisualStyleBackColor = false;
            btnRegistroEntrada.Click += btnRegistroEntrada_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(694, 21);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(140, 92);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 66;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(161, 100);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(635, 25);
            label4.TabIndex = 64;
            label4.Text = "_________________________________________________________________________________________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(190, 41);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(433, 45);
            label3.TabIndex = 65;
            label3.Text = "Registro de Entrada/Salida";
            // 
            // VisitaPorSeleccion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 562);
            Controls.Add(panel1);
            Margin = new Padding(4);
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