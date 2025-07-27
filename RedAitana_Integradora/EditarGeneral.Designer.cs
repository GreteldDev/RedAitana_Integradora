namespace RedAitana_Integradora
{
    partial class EditarGeneral
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
            dgvEditar = new DataGridView();
            btnEliminar = new Button();
            btnCancelar = new Button();
            btnExaminar = new Button();
            btnGuardar = new Button();
            PicFoto = new PictureBox();
            Nombre = new TextBox();
            Apellidos = new TextBox();
            Correo = new TextBox();
            Telefono = new TextBox();
            Id = new TextBox();
            Rol = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEditar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicFoto).BeginInit();
            SuspendLayout();
            // 
            // dgvEditar
            // 
            dgvEditar.BackgroundColor = Color.FromArgb(224, 200, 232);
            dgvEditar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEditar.Location = new Point(56, 249);
            dgvEditar.Margin = new Padding(2);
            dgvEditar.Name = "dgvEditar";
            dgvEditar.RowHeadersWidth = 62;
            dgvEditar.Size = new Size(563, 189);
            dgvEditar.TabIndex = 0;
            dgvEditar.CellContentClick += dgvEditar_CellContentClick;
            dgvEditar.SelectionChanged += dgvEditar_SelectionChanged;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(117, 76, 154);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 128, 108);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Century Gothic", 9F);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(420, 198);
            btnEliminar.Margin = new Padding(2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 27);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(117, 76, 154);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 128, 108);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 9F);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(529, 198);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 27);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnExaminar
            // 
            btnExaminar.BackColor = Color.FromArgb(117, 76, 154);
            btnExaminar.FlatAppearance.BorderSize = 0;
            btnExaminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 128, 108);
            btnExaminar.FlatStyle = FlatStyle.Flat;
            btnExaminar.Font = new Font("Century Gothic", 9F);
            btnExaminar.ForeColor = Color.White;
            btnExaminar.Location = new Point(45, 198);
            btnExaminar.Margin = new Padding(2);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(117, 27);
            btnExaminar.TabIndex = 4;
            btnExaminar.Text = "Examinar";
            btnExaminar.UseVisualStyleBackColor = false;
            btnExaminar.Click += btnExaminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(117, 76, 154);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 128, 108);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Century Gothic", 9F);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(308, 198);
            btnGuardar.Margin = new Padding(2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(90, 27);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // PicFoto
            // 
            PicFoto.BackColor = Color.White;
            PicFoto.Location = new Point(45, 55);
            PicFoto.Margin = new Padding(2);
            PicFoto.Name = "PicFoto";
            PicFoto.Size = new Size(117, 125);
            PicFoto.SizeMode = PictureBoxSizeMode.Zoom;
            PicFoto.TabIndex = 6;
            PicFoto.TabStop = false;
            PicFoto.Click += PicFoto_Click;
            // 
            // Nombre
            // 
            Nombre.Location = new Point(336, 55);
            Nombre.Margin = new Padding(2);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(191, 27);
            Nombre.TabIndex = 7;
            Nombre.TextChanged += Nombre_TextChanged;
            // 
            // Apellidos
            // 
            Apellidos.Location = new Point(336, 104);
            Apellidos.Margin = new Padding(2);
            Apellidos.Name = "Apellidos";
            Apellidos.Size = new Size(191, 27);
            Apellidos.TabIndex = 8;
            Apellidos.TextChanged += textBox2_TextChanged;
            // 
            // Correo
            // 
            Correo.Location = new Point(204, 155);
            Correo.Margin = new Padding(2);
            Correo.Name = "Correo";
            Correo.Size = new Size(194, 27);
            Correo.TabIndex = 9;
            Correo.TextChanged += Correo_TextChanged;
            // 
            // Telefono
            // 
            Telefono.Location = new Point(420, 155);
            Telefono.Margin = new Padding(2);
            Telefono.Name = "Telefono";
            Telefono.Size = new Size(199, 27);
            Telefono.TabIndex = 10;
            Telefono.TextChanged += Telefono_TextChanged;
            // 
            // Id
            // 
            Id.Location = new Point(204, 55);
            Id.Margin = new Padding(2);
            Id.Name = "Id";
            Id.Size = new Size(90, 27);
            Id.TabIndex = 11;
            Id.TextChanged += Id_TextChanged;
            // 
            // Rol
            // 
            Rol.Location = new Point(204, 105);
            Rol.Margin = new Padding(2);
            Rol.Name = "Rol";
            Rol.Size = new Size(109, 27);
            Rol.TabIndex = 12;
            Rol.TextChanged += Rol_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(204, 32);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 13;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(336, 32);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 14;
            label2.Text = "Nombre(s)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(336, 82);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 15;
            label3.Text = "Apellido(s)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(420, 132);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 16;
            label4.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(204, 132);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 17;
            label5.Text = "Correo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(204, 82);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 18;
            label6.Text = "Tipo";
            // 
            // EditarGeneral
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 503);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Rol);
            Controls.Add(Id);
            Controls.Add(Telefono);
            Controls.Add(Correo);
            Controls.Add(Apellidos);
            Controls.Add(Nombre);
            Controls.Add(PicFoto);
            Controls.Add(btnGuardar);
            Controls.Add(btnExaminar);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(dgvEditar);
            Margin = new Padding(2);
            Name = "EditarGeneral";
            Text = "EditarGeneral";
            Load += EditarGeneral_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEditar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEditar;
        private Button btnEliminar;
        private Button btnCancelar;
        private Button btnExaminar;
        private Button btnGuardar;
        private PictureBox PicFoto;
        private TextBox Nombre;
        private TextBox Apellidos;
        private TextBox Correo;
        private TextBox Telefono;
        private TextBox Id;
        private TextBox Rol;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}