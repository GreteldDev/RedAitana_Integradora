
namespace RedAitana_Integradora
{
    partial class Bienvenido : Form // Ensure Main inherits from Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) // Fix inheritance issue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bienvenido));
            panel1 = new Panel();
            panel3 = new Panel();
            label5 = new Label();
            label2 = new Label();
            btnGestionVoluntarios = new Button();
            btnGestionEmpleados = new Button();
            btnRegistroGeneral = new Button();
            panelContenedor = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(71, 48, 120);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btnGestionVoluntarios);
            panel1.Controls.Add(btnGestionEmpleados);
            panel1.Controls.Add(btnRegistroGeneral);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 444);
            panel1.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 95);
            panel3.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(7, 75);
            label5.Name = "label5";
            label5.Size = new Size(237, 20);
            label5.TabIndex = 1;
            label5.Text = "______________________________________";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 22.2F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(23, 25);
            label2.Name = "label2";
            label2.Size = new Size(205, 44);
            label2.TabIndex = 1;
            label2.Text = "RedAitana";
            label2.Click += label2_Click_1;
            // 
            // btnGestionVoluntarios
            // 
            btnGestionVoluntarios.BackColor = Color.FromArgb(117, 76, 154);
            btnGestionVoluntarios.FlatAppearance.BorderSize = 0;
            btnGestionVoluntarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 128, 108);
            btnGestionVoluntarios.FlatStyle = FlatStyle.Flat;
            btnGestionVoluntarios.Font = new Font("Century Gothic", 9F);
            btnGestionVoluntarios.ForeColor = Color.White;
            btnGestionVoluntarios.Location = new Point(13, 280);
            btnGestionVoluntarios.Name = "btnGestionVoluntarios";
            btnGestionVoluntarios.Size = new Size(222, 61);
            btnGestionVoluntarios.TabIndex = 3;
            btnGestionVoluntarios.Text = "Gestión de Visitantes y Beneficiarios";
            btnGestionVoluntarios.UseVisualStyleBackColor = false;
            btnGestionVoluntarios.Click += btnGestionVoluntarios_Click_1;
            // 
            // btnGestionEmpleados
            // 
            btnGestionEmpleados.BackColor = Color.FromArgb(117, 76, 154);
            btnGestionEmpleados.FlatAppearance.BorderSize = 0;
            btnGestionEmpleados.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 128, 108);
            btnGestionEmpleados.FlatStyle = FlatStyle.Flat;
            btnGestionEmpleados.Font = new Font("Century Gothic", 9F);
            btnGestionEmpleados.ForeColor = Color.White;
            btnGestionEmpleados.Location = new Point(12, 197);
            btnGestionEmpleados.Name = "btnGestionEmpleados";
            btnGestionEmpleados.Size = new Size(223, 61);
            btnGestionEmpleados.TabIndex = 2;
            btnGestionEmpleados.Text = "Gestión de Trabajadores y Colaboradores";
            btnGestionEmpleados.UseVisualStyleBackColor = false;
            btnGestionEmpleados.Click += btnGestionEmpleados_Click;
            // 
            // btnRegistroGeneral
            // 
            btnRegistroGeneral.BackColor = Color.FromArgb(117, 76, 154);
            btnRegistroGeneral.FlatAppearance.BorderSize = 0;
            btnRegistroGeneral.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 128, 108);
            btnRegistroGeneral.FlatStyle = FlatStyle.Flat;
            btnRegistroGeneral.Font = new Font("Century Gothic", 9F);
            btnRegistroGeneral.ForeColor = Color.White;
            btnRegistroGeneral.Location = new Point(13, 114);
            btnRegistroGeneral.Name = "btnRegistroGeneral";
            btnRegistroGeneral.Size = new Size(223, 61);
            btnRegistroGeneral.TabIndex = 0;
            btnRegistroGeneral.Text = "Registro General";
            btnRegistroGeneral.UseVisualStyleBackColor = false;
            btnRegistroGeneral.Click += btnRegistroGeneral_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.White;
            panelContenedor.Controls.Add(pictureBox1);
            panelContenedor.Controls.Add(label1);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(250, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(605, 444);
            panelContenedor.TabIndex = 4;
            panelContenedor.Paint += panelContenedor_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(195, 222);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 36F, FontStyle.Bold);
            label1.Location = new Point(115, 114);
            label1.Name = "label1";
            label1.Size = new Size(379, 70);
            label1.TabIndex = 0;
            label1.Text = "Bienvenidos";
            // 
            // Bienvenido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 444);
            Controls.Add(panelContenedor);
            Controls.Add(panel1);
            Location = new Point(372, 191);
            Name = "Bienvenido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RedAitana";
            Load += Bienvenido_Load_1;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label label5;
        private Label label2;
        private Button btnGestionVoluntarios;
        private Button btnGestionEmpleados;
        private Button btnRegistroGeneral;
        private Panel panelContenedor;
        private Label label1;
        private PictureBox pictureBox1;
    }
}