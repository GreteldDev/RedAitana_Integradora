namespace RedAitana_Integradora
{
    partial class InicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            txtPassword = new TextBox();
            btnIngresar = new Button();
            btnCancelar = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(115, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label1.Location = new Point(115, 100);
            label1.Name = "label1";
            label1.Size = new Size(112, 23);
            label1.TabIndex = 1;
            label1.Text = "RedAitana";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(24, 123);
            label2.Name = "label2";
            label2.Size = new Size(302, 20);
            label2.TabIndex = 2;
            label2.Text = "Ingrese sus credenciales para continuar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F);
            label3.Location = new Point(52, 169);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 3;
            label3.Text = "Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F);
            label4.Location = new Point(52, 237);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 4;
            label4.Text = "Contraseña";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.White;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(52, 192);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(231, 28);
            comboBox1.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(52, 260);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(231, 27);
            txtPassword.TabIndex = 6;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(223, 128, 108);
            btnIngresar.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(76, 309);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(187, 40);
            btnIngresar.TabIndex = 7;
            btnIngresar.Text = "Iniciar Sesión";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(64, 64, 64);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(76, 355);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(187, 30);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnIngresar);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(225, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(345, 390);
            panel1.TabIndex = 0;
            // 
            // InicioSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(117, 76, 154);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "InicioSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de Sesión";
            Load += InicioSesion_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private TextBox txtPassword;
        private Button btnIngresar;
        private Button btnCancelar;
        private Panel panel1;
    }
}
