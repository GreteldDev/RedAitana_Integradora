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
            panel1 = new Panel();
            txtSegundoApellido = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            txtPrimerApellido = new TextBox();
            cbxRol = new ComboBox();
            label3 = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            btnExaminar = new Button();
            pcbFoto = new PictureBox();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbFoto).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(txtSegundoApellido);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(txtPrimerApellido);
            panel1.Controls.Add(cbxRol);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Location = new Point(457, 204);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(151, 27);
            txtSegundoApellido.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F);
            label4.Location = new Point(318, 207);
            label4.Name = "label4";
            label4.Size = new Size(138, 20);
            label4.TabIndex = 26;
            label4.Text = "Segundo Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(457, 124);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(151, 27);
            txtNombre.TabIndex = 16;
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Location = new Point(457, 163);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(151, 27);
            txtPrimerApellido.TabIndex = 18;
            // 
            // cbxRol
            // 
            cbxRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxRol.FormattingEnabled = true;
            cbxRol.Location = new Point(457, 251);
            cbxRol.Name = "cbxRol";
            cbxRol.Size = new Size(151, 28);
            cbxRol.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F);
            label3.Location = new Point(318, 166);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 19;
            label3.Text = "Primer Apellido";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Font = new Font("Century Gothic", 9F);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(431, 343);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(109, 46);
            btnCancelar.TabIndex = 29;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(177, 135, 193);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Century Gothic", 9F);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(299, 343);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(116, 46);
            btnGuardar.TabIndex = 28;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // btnExaminar
            // 
            btnExaminar.BackColor = Color.FromArgb(177, 135, 193);
            btnExaminar.FlatAppearance.BorderSize = 0;
            btnExaminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 128, 108);
            btnExaminar.FlatStyle = FlatStyle.Flat;
            btnExaminar.Font = new Font("Century Gothic", 9F);
            btnExaminar.ForeColor = Color.White;
            btnExaminar.Location = new Point(152, 259);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(94, 29);
            btnExaminar.TabIndex = 27;
            btnExaminar.Text = "Examinar";
            btnExaminar.UseVisualStyleBackColor = false;
            btnExaminar.Click += btnExaminar_Click;
            // 
            // pcbFoto
            // 
            pcbFoto.BackColor = Color.White;
            pcbFoto.Location = new Point(152, 127);
            pcbFoto.Name = "pcbFoto";
            pcbFoto.Size = new Size(140, 123);
            pcbFoto.SizeMode = PictureBoxSizeMode.Zoom;
            pcbFoto.TabIndex = 26;
            pcbFoto.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Century Gothic", 9F);
            label6.Location = new Point(318, 259);
            label6.Name = "label6";
            label6.Size = new Size(31, 20);
            label6.TabIndex = 25;
            label6.Text = "Rol";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Century Gothic", 9F);
            label2.Location = new Point(318, 127);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 17;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(71, 48, 120);
            label1.Location = new Point(152, 61);
            label1.Name = "label1";
            label1.Size = new Size(427, 37);
            label1.TabIndex = 15;
            label1.Text = "Nuevo Visitante/Beneficiario";
            // 
            // NuevoVoluntario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(btnExaminar);
            Controls.Add(pcbFoto);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "NuevoVoluntario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NuevoVoluntario";
            Load += NuevoVoluntario_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnCancelar;
        private Button btnGuardar;
        private Button btnExaminar;
        private PictureBox pcbFoto;
        private Label label6;
        private ComboBox cbxRol;
        private Label label5;
        private TextBox txtTelefono;
        private Label label4;
        private Label label3;
        private TextBox txtPrimerApellido;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private TextBox txtSegundoApellido;
    }
}