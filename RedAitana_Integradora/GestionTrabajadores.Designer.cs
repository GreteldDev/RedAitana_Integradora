namespace RedAitana_Integradora
{
    partial class GestionTrabajadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionTrabajadores));
            btnNuevoTrabajador = new Button();
            btnEditar = new Button();
            btnTrabajadores = new Button();
            btnColaboradores = new Button();
            txtBusqueda = new TextBox();
            dgvTrabajadores = new DataGridView();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTrabajadores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnNuevoTrabajador
            // 
            btnNuevoTrabajador.BackColor = Color.FromArgb(177, 135, 193);
            btnNuevoTrabajador.FlatAppearance.BorderSize = 0;
            btnNuevoTrabajador.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 128, 108);
            btnNuevoTrabajador.FlatStyle = FlatStyle.Flat;
            btnNuevoTrabajador.Font = new Font("Century Gothic", 9F);
            btnNuevoTrabajador.ForeColor = Color.White;
            btnNuevoTrabajador.Location = new Point(35, 173);
            btnNuevoTrabajador.Name = "btnNuevoTrabajador";
            btnNuevoTrabajador.Size = new Size(215, 50);
            btnNuevoTrabajador.TabIndex = 1;
            btnNuevoTrabajador.Text = "+ Nuevo Trabajador/Colaborador";
            btnNuevoTrabajador.UseVisualStyleBackColor = false;
            btnNuevoTrabajador.Click += btnNuevoTrabajador_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(177, 135, 193);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 128, 108);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Century Gothic", 9F);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(278, 173);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 50);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnTrabajadores
            // 
            btnTrabajadores.BackColor = Color.FromArgb(177, 135, 193);
            btnTrabajadores.FlatAppearance.BorderSize = 0;
            btnTrabajadores.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 128, 108);
            btnTrabajadores.FlatStyle = FlatStyle.Flat;
            btnTrabajadores.Font = new Font("Century Gothic", 9F);
            btnTrabajadores.ForeColor = Color.White;
            btnTrabajadores.Location = new Point(445, 163);
            btnTrabajadores.Name = "btnTrabajadores";
            btnTrabajadores.Size = new Size(134, 29);
            btnTrabajadores.TabIndex = 3;
            btnTrabajadores.Text = "Trabajadores";
            btnTrabajadores.UseVisualStyleBackColor = false;
            btnTrabajadores.Click += btnTrabajadores_Click;
            // 
            // btnColaboradores
            // 
            btnColaboradores.BackColor = Color.FromArgb(177, 135, 193);
            btnColaboradores.FlatAppearance.BorderSize = 0;
            btnColaboradores.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 128, 108);
            btnColaboradores.FlatStyle = FlatStyle.Flat;
            btnColaboradores.Font = new Font("Century Gothic", 9F);
            btnColaboradores.ForeColor = Color.White;
            btnColaboradores.Location = new Point(445, 202);
            btnColaboradores.Name = "btnColaboradores";
            btnColaboradores.Size = new Size(134, 29);
            btnColaboradores.TabIndex = 4;
            btnColaboradores.Text = "Colaboradores";
            btnColaboradores.UseVisualStyleBackColor = false;
            btnColaboradores.Click += btnColaboradores_Click;
            // 
            // txtBusqueda
            // 
            txtBusqueda.BackColor = Color.FromArgb(224, 200, 232);
            txtBusqueda.Location = new Point(145, 106);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(434, 27);
            txtBusqueda.TabIndex = 5;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // dgvTrabajadores
            // 
            dgvTrabajadores.BackgroundColor = Color.FromArgb(224, 200, 232);
            dgvTrabajadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTrabajadores.Location = new Point(35, 245);
            dgvTrabajadores.Name = "dgvTrabajadores";
            dgvTrabajadores.RowHeadersWidth = 51;
            dgvTrabajadores.Size = new Size(544, 188);
            dgvTrabajadores.TabIndex = 6;
            dgvTrabajadores.CellContentClick += dgvTrabajadores_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(71, 48, 120);
            label3.Location = new Point(35, 12);
            label3.Name = "label3";
            label3.Size = new Size(415, 64);
            label3.TabIndex = 20;
            label3.Text = "Catálogo de \r\nTrabajadores y Colaboradores\r\n";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(497, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(112, 74);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(9, 70);
            label4.Name = "label4";
            label4.Size = new Size(603, 20);
            label4.TabIndex = 18;
            label4.Text = "___________________________________________________________________________________________________";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(71, 48, 120);
            label1.Location = new Point(35, 109);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 21;
            label1.Text = "Buscador";
            // 
            // GestionTrabajadores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(dgvTrabajadores);
            Controls.Add(txtBusqueda);
            Controls.Add(btnColaboradores);
            Controls.Add(btnTrabajadores);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevoTrabajador);
            Name = "GestionTrabajadores";
            Text = "GestionTrabajadores";
            ((System.ComponentModel.ISupportInitialize)dgvTrabajadores).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnNuevoTrabajador;
        private Button btnEditar;
        private Button btnTrabajadores;
        private Button btnColaboradores;
        private TextBox txtBusqueda;
        private DataGridView dgvTrabajadores;
        private Label label3;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label1;
    }
}