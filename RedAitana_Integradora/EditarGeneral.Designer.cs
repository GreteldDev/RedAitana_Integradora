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
            dataGridView1 = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicFoto).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 210);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(566, 113);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(406, 168);
            btnEliminar.Margin = new Padding(2, 2, 2, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 27);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(515, 168);
            btnCancelar.Margin = new Padding(2, 2, 2, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 27);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnExaminar
            // 
            btnExaminar.Location = new Point(38, 168);
            btnExaminar.Margin = new Padding(2, 2, 2, 2);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(117, 27);
            btnExaminar.TabIndex = 4;
            btnExaminar.Text = "Examinar";
            btnExaminar.UseVisualStyleBackColor = true;
            btnExaminar.Click += btnExaminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(294, 168);
            btnGuardar.Margin = new Padding(2, 2, 2, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(90, 27);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // PicFoto
            // 
            PicFoto.Location = new Point(38, 25);
            PicFoto.Margin = new Padding(2, 2, 2, 2);
            PicFoto.Name = "PicFoto";
            PicFoto.Size = new Size(117, 125);
            PicFoto.SizeMode = PictureBoxSizeMode.Zoom;
            PicFoto.TabIndex = 6;
            PicFoto.TabStop = false;
            PicFoto.Click += PicFoto_Click;
            // 
            // Nombre
            // 
            Nombre.Location = new Point(322, 25);
            Nombre.Margin = new Padding(2, 2, 2, 2);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(191, 27);
            Nombre.TabIndex = 7;
            Nombre.TextChanged += Nombre_TextChanged;
            // 
            // Apellidos
            // 
            Apellidos.Location = new Point(322, 74);
            Apellidos.Margin = new Padding(2, 2, 2, 2);
            Apellidos.Name = "Apellidos";
            Apellidos.Size = new Size(191, 27);
            Apellidos.TabIndex = 8;
            Apellidos.TextChanged += textBox2_TextChanged;
            // 
            // Correo
            // 
            Correo.Location = new Point(190, 125);
            Correo.Margin = new Padding(2, 2, 2, 2);
            Correo.Name = "Correo";
            Correo.Size = new Size(194, 27);
            Correo.TabIndex = 9;
            Correo.TextChanged += Correo_TextChanged;
            // 
            // Telefono
            // 
            Telefono.Location = new Point(406, 125);
            Telefono.Margin = new Padding(2, 2, 2, 2);
            Telefono.Name = "Telefono";
            Telefono.Size = new Size(199, 27);
            Telefono.TabIndex = 10;
            Telefono.TextChanged += Telefono_TextChanged;
            // 
            // Id
            // 
            Id.Location = new Point(190, 25);
            Id.Margin = new Padding(2, 2, 2, 2);
            Id.Name = "Id";
            Id.Size = new Size(90, 27);
            Id.TabIndex = 11;
            Id.TextChanged += Id_TextChanged;
            // 
            // Rol
            // 
            Rol.Location = new Point(190, 75);
            Rol.Margin = new Padding(2, 2, 2, 2);
            Rol.Name = "Rol";
            Rol.Size = new Size(109, 27);
            Rol.TabIndex = 12;
            Rol.TextChanged += Rol_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(190, 2);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 13;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(322, 2);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 14;
            label2.Text = "Nombre(s)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(322, 52);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 15;
            label3.Text = "Apellido(s)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(406, 102);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 16;
            label4.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(190, 102);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 17;
            label5.Text = "Correo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(190, 52);
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
            ClientSize = new Size(640, 360);
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
            Controls.Add(dataGridView1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "EditarGeneral";
            Text = "EditarGeneral";
            Load += EditarGeneral_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
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