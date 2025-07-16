namespace RedAitana_Integradora
{
    partial class GestionEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionEmpleados));
            panel2 = new Panel();
            panel4 = new Panel();
            btnEditar = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            txtBuscar = new TextBox();
            btnAgregar = new Button();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 450);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(btnEditar);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(dataGridView1);
            panel4.Controls.Add(txtBuscar);
            panel4.Controls.Add(btnAgregar);
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(800, 450);
            panel4.TabIndex = 3;
            panel4.Paint += panel4_Paint;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(177, 135, 193);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 128, 108);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(341, 153);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(105, 41);
            btnEditar.TabIndex = 17;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(71, 48, 120);
            label1.Location = new Point(34, 110);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 12;
            label1.Text = "Buscador";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 220);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(504, 213);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.FromArgb(224, 200, 232);
            txtBuscar.Font = new Font("Segoe UI", 9F);
            txtBuscar.Location = new Point(169, 104);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(317, 27);
            txtBuscar.TabIndex = 11;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(177, 135, 193);
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 128, 108);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Century Gothic", 9F);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(29, 153);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(283, 41);
            btnAgregar.TabIndex = 15;
            btnAgregar.Text = "+ Nuevo Empleado/Beneficiario";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(470, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(112, 74);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(3, 66);
            label4.Name = "label4";
            label4.Size = new Size(543, 20);
            label4.TabIndex = 11;
            label4.Text = "_________________________________________________________________________________________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(71, 48, 120);
            label3.Location = new Point(29, 32);
            label3.Name = "label3";
            label3.Size = new Size(435, 27);
            label3.TabIndex = 12;
            label3.Text = "Catálogo de Empleados y Voluntarios";
            // 
            // GestionEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Name = "GestionEmpleados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GestionEmpleados";
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel4;
        private DataGridView dataGridView1;
        private Button btnAgregar;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox txtBuscar;
        private Button btnEditar;
    }
}