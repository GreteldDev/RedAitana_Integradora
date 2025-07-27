namespace RedAitana_Integradora
{
    partial class NuevoTrabajador
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtApellidos = new TextBox();
            label3 = new Label();
            txtCorreo = new TextBox();
            label4 = new Label();
            txtTelefono = new TextBox();
            label5 = new Label();
            cbxRol = new ComboBox();
            label6 = new Label();
            pcbFoto = new PictureBox();
            btnExaminar = new Button();
            btnGuardar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)pcbFoto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(71, 48, 120);
            label1.Location = new Point(47, 34);
            label1.Name = "label1";
            label1.Size = new Size(497, 37);
            label1.TabIndex = 0;
            label1.Text = "Nuevo Trabajador / Colaborador";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(316, 97);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(151, 27);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F);
            label2.Location = new Point(213, 100);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(316, 130);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(151, 27);
            txtApellidos.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F);
            label3.Location = new Point(213, 133);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 4;
            label3.Text = "Apellidos";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(316, 163);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(151, 27);
            txtCorreo.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F);
            label4.Location = new Point(213, 166);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 6;
            label4.Text = "Correo";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(316, 196);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(151, 27);
            txtTelefono.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F);
            label5.Location = new Point(213, 199);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 8;
            label5.Text = "Teléfono";
            // 
            // cbxRol
            // 
            cbxRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxRol.FormattingEnabled = true;
            cbxRol.Location = new Point(316, 229);
            cbxRol.Name = "cbxRol";
            cbxRol.Size = new Size(151, 28);
            cbxRol.TabIndex = 9;
            cbxRol.SelectedIndexChanged += cbxRol_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F);
            label6.Location = new Point(213, 232);
            label6.Name = "label6";
            label6.Size = new Size(31, 20);
            label6.TabIndex = 10;
            label6.Text = "Rol";
            // 
            // pcbFoto
            // 
            pcbFoto.BackColor = Color.White;
            pcbFoto.Location = new Point(47, 100);
            pcbFoto.Name = "pcbFoto";
            pcbFoto.Size = new Size(140, 123);
            pcbFoto.SizeMode = PictureBoxSizeMode.Zoom;
            pcbFoto.TabIndex = 11;
            pcbFoto.TabStop = false;
            // 
            // btnExaminar
            // 
            btnExaminar.BackColor = Color.FromArgb(177, 135, 193);
            btnExaminar.FlatAppearance.BorderSize = 0;
            btnExaminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 128, 108);
            btnExaminar.FlatStyle = FlatStyle.Flat;
            btnExaminar.Font = new Font("Century Gothic", 9F);
            btnExaminar.ForeColor = Color.White;
            btnExaminar.Location = new Point(47, 232);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(94, 29);
            btnExaminar.TabIndex = 12;
            btnExaminar.Text = "Examinar";
            btnExaminar.UseVisualStyleBackColor = false;
            btnExaminar.Click += btnExaminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(177, 135, 193);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Century Gothic", 9F);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(194, 316);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(116, 46);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Font = new Font("Century Gothic", 9F);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(326, 316);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(109, 46);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // NuevoTrabajador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(btnExaminar);
            Controls.Add(pcbFoto);
            Controls.Add(label6);
            Controls.Add(cbxRol);
            Controls.Add(label5);
            Controls.Add(txtTelefono);
            Controls.Add(label4);
            Controls.Add(txtCorreo);
            Controls.Add(label3);
            Controls.Add(txtApellidos);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "NuevoTrabajador";
            Text = "NuevoTrabajador";
            Load += NuevoTrabajador_Load;
            ((System.ComponentModel.ISupportInitialize)pcbFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtApellidos;
        private Label label3;
        private TextBox txtCorreo;
        private Label label4;
        private TextBox txtTelefono;
        private Label label5;
        private ComboBox cbxRol;
        private Label label6;
        private PictureBox pcbFoto;
        private Button btnExaminar;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}