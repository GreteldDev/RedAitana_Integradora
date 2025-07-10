namespace RedAitana_Integradora
{
    partial class NuevoVoluntario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoVoluntario));
            panel1 = new Panel();
            label2 = new Label();
            comboBox1 = new ComboBox();
            txtApellidos = new TextBox();
            label12 = new Label();
            label10 = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            txtNombre = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(txtApellidos);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(217, 288);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 49;
            label2.Text = "Selección de Rol";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(372, 285);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(207, 28);
            comboBox1.TabIndex = 48;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(372, 166);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(207, 27);
            txtApellidos.TabIndex = 47;
            txtApellidos.TextChanged += txtPrimerApellido_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(217, 166);
            label12.Name = "label12";
            label12.Size = new Size(72, 20);
            label12.TabIndex = 46;
            label12.Text = "Apellidos";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(217, 130);
            label10.Name = "label10";
            label10.Size = new Size(0, 20);
            label10.TabIndex = 43;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(177, 135, 193);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(485, 367);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 41);
            btnCancelar.TabIndex = 42;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(177, 135, 193);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(372, 367);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 41);
            btnGuardar.TabIndex = 41;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(372, 240);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(207, 27);
            txtCorreo.TabIndex = 40;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(372, 207);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(207, 27);
            txtTelefono.TabIndex = 39;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(372, 131);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(207, 27);
            txtNombre.TabIndex = 37;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(217, 240);
            label9.Name = "label9";
            label9.Size = new Size(132, 20);
            label9.TabIndex = 36;
            label9.Text = "Correo electronico";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(217, 207);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 35;
            label8.Text = "Teléfono";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(217, 131);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 33;
            label1.Text = "Nombre";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(555, 19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(112, 74);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 31;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(129, 82);
            label4.Name = "label4";
            label4.Size = new Size(543, 20);
            label4.TabIndex = 29;
            label4.Text = "_________________________________________________________________________________________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(104, 44);
            label3.Name = "label3";
            label3.Size = new Size(445, 38);
            label3.TabIndex = 30;
            label3.Text = "Nuevo Voluntario o Empleado :b";
            // 
            // NuevoVoluntario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "NuevoVoluntario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NuevoVoluntario";
            Load += NuevoVoluntario_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtApellidos;
        private Label label12;
        private Label label10;
        private Button btnCancelar;
        private Button btnGuardar;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private TextBox txtNombre;
        private Label label9;
        private Label label8;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label3;
        private ComboBox comboBox1;
        private Label label2;
    }
}