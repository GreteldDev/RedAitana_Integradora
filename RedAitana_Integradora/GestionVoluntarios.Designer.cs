namespace RedAitana_Integradora
{
    partial class GestionVoluntarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionVoluntarios));
            panel2 = new Panel();
            btnEditar = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnAgregr = new Button();
            txtBuscar = new TextBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnEditar);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(btnAgregr);
            panel2.Controls.Add(txtBuscar);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 450);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(347, 164);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 117);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 10;
            label1.Text = "Buscador";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 214);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(504, 213);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnAgregr
            // 
            btnAgregr.BackColor = Color.FromArgb(177, 135, 193);
            btnAgregr.FlatStyle = FlatStyle.Flat;
            btnAgregr.ForeColor = Color.White;
            btnAgregr.Location = new Point(25, 158);
            btnAgregr.Name = "btnAgregr";
            btnAgregr.Size = new Size(228, 41);
            btnAgregr.TabIndex = 8;
            btnAgregr.Text = "+ Nuevo Visitante/Beneficiario";
            btnAgregr.UseVisualStyleBackColor = false;
            btnAgregr.Click += button1_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(124, 114);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(317, 27);
            txtBuscar.TabIndex = 7;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(549, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(112, 74);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(3, 77);
            label4.Name = "label4";
            label4.Size = new Size(543, 20);
            label4.TabIndex = 3;
            label4.Text = "_________________________________________________________________________________________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(25, 26);
            label3.Name = "label3";
            label3.Size = new Size(509, 38);
            label3.TabIndex = 5;
            label3.Text = "Catálogo de Visitantes y Beneficiarios";
            // 
            // GestionVoluntarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Name = "GestionVoluntarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GestionVoluntarios";
            Load += GestionVoluntarios_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label3;
        private Button btnAgregr;
        private TextBox txtBuscar;
        private DataGridView dataGridView1;
        private Label label1;
        private Button btnEditar;
    }
}