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
            label5 = new Label();
            txtSegundoApellido = new TextBox();
            btnExaminar = new Button();
            PicFoto = new PictureBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            txtPrimerApellido = new TextBox();
            label12 = new Label();
            label10 = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            txtNombre = new TextBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtSegundoApellido);
            panel1.Controls.Add(btnExaminar);
            panel1.Controls.Add(PicFoto);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(txtPrimerApellido);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label1);
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F);
            label5.Location = new Point(260, 230);
            label5.Name = "label5";
            label5.Size = new Size(138, 20);
            label5.TabIndex = 53;
            label5.Text = "Segundo Apellido";
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Location = new Point(415, 223);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(207, 27);
            txtSegundoApellido.TabIndex = 52;
            // 
            // btnExaminar
            // 
            btnExaminar.BackColor = Color.FromArgb(177, 135, 193);
            btnExaminar.FlatAppearance.BorderSize = 0;
            btnExaminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 128, 108);
            btnExaminar.FlatStyle = FlatStyle.Flat;
            btnExaminar.Font = new Font("Century Gothic", 9F);
            btnExaminar.ForeColor = Color.White;
            btnExaminar.Location = new Point(50, 332);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(122, 45);
            btnExaminar.TabIndex = 51;
            btnExaminar.Text = "Examinar";
            btnExaminar.UseVisualStyleBackColor = false;
            btnExaminar.Click += btnExaminar_Click;
            // 
            // PicFoto
            // 
            PicFoto.Location = new Point(50, 143);
            PicFoto.Name = "PicFoto";
            PicFoto.Size = new Size(151, 163);
            PicFoto.SizeMode = PictureBoxSizeMode.Zoom;
            PicFoto.TabIndex = 50;
            PicFoto.TabStop = false;
            PicFoto.Click += PicFoto_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F);
            label2.Location = new Point(260, 267);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 49;
            label2.Text = "Selección de Rol";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(415, 264);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(207, 28);
            comboBox1.TabIndex = 48;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Location = new Point(415, 178);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(207, 27);
            txtPrimerApellido.TabIndex = 47;
            txtPrimerApellido.TextChanged += txtPrimerApellido_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 9F);
            label12.Location = new Point(260, 185);
            label12.Name = "label12";
            label12.Size = new Size(118, 20);
            label12.TabIndex = 46;
            label12.Text = "Primer Apellido";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(219, 143);
            label10.Name = "label10";
            label10.Size = new Size(0, 20);
            label10.TabIndex = 43;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(177, 135, 193);
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 128, 108);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 9F);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(528, 332);
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
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 128, 108);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Century Gothic", 9F);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(415, 332);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 41);
            btnGuardar.TabIndex = 41;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(415, 143);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(207, 27);
            txtNombre.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F);
            label1.Location = new Point(260, 143);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 33;
            label1.Text = "Nombre";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(528, 19);
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
            label4.Location = new Point(75, 93);
            label4.Name = "label4";
            label4.Size = new Size(543, 20);
            label4.TabIndex = 29;
            label4.Text = "_________________________________________________________________________________________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(75, 52);
            label3.Name = "label3";
            label3.Size = new Size(354, 27);
            label3.TabIndex = 30;
            label3.Text = "Nuevo Visitante o Beneficiario ";
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
            ((System.ComponentModel.ISupportInitialize)PicFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtPrimerApellido;
        private Label label12;
        private Label label10;
        private Button btnCancelar;
        private Button btnGuardar;
        private TextBox txtNombre;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label3;
        private ComboBox comboBox1;
        private Label label2;
        private Button btnExaminar;
        private PictureBox PicFoto;
        private Label label5;
        private TextBox txtSegundoApellido;
    }
}