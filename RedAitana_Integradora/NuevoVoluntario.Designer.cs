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
            btnExaminar = new Button();
            pictureBox1 = new PictureBox();
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
            txtSegundoApellido = new TextBox();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtSegundoApellido);
            panel1.Controls.Add(btnExaminar);
            panel1.Controls.Add(pictureBox1);
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
            // 
            // btnExaminar
            // 
            btnExaminar.Location = new Point(46, 280);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(122, 45);
            btnExaminar.TabIndex = 51;
            btnExaminar.Text = "Examinar";
            btnExaminar.UseVisualStyleBackColor = true;
            btnExaminar.Click += btnExaminar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(48, 117);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 134);
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(217, 255);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 49;
            label2.Text = "Selección de Rol";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(372, 252);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(207, 28);
            comboBox1.TabIndex = 48;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Location = new Point(372, 166);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(207, 27);
            txtPrimerApellido.TabIndex = 47;
            txtPrimerApellido.TextChanged += txtPrimerApellido_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(217, 173);
            label12.Name = "label12";
            label12.Size = new Size(113, 20);
            label12.TabIndex = 46;
            label12.Text = "Primer Apellido";
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
            btnCancelar.Location = new Point(485, 321);
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
            btnGuardar.Location = new Point(372, 321);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 41);
            btnGuardar.TabIndex = 41;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(372, 131);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(207, 27);
            txtNombre.TabIndex = 37;
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
            label3.Size = new Size(449, 38);
            label3.TabIndex = 30;
            label3.Text = "Nuevo Visitante o Beneficiario :b";
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Location = new Point(372, 211);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(207, 27);
            txtSegundoApellido.TabIndex = 52;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(217, 218);
            label5.Name = "label5";
            label5.Size = new Size(129, 20);
            label5.TabIndex = 53;
            label5.Text = "Segundo Apellido";
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private Label label5;
        private TextBox txtSegundoApellido;
    }
}