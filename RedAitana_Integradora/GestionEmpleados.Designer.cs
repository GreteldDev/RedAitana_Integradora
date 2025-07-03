namespace RedAitana_Integradora
{
    partial class GestionEmpleados
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
            label1 = new Label();
            btnAtras = new Button();
            panel2 = new Panel();
            panel4 = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label2 = new Label();
            btnGestionVoluntarios = new Button();
            btnGestionEmpleados = new Button();
            btnRegistroGeneral = new Button();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(175, 197);
            label1.Name = "label1";
            label1.Size = new Size(251, 20);
            label1.TabIndex = 0;
            label1.Text = "Pantalla de Gestión de empleados :b";
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(71, 114);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(94, 29);
            btnAtras.TabIndex = 1;
            btnAtras.Text = "<- Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 450);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnAtras);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(250, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(550, 450);
            panel4.TabIndex = 3;
            panel4.Paint += panel4_Paint;
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
            panel1.Size = new Size(250, 450);
            panel1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 95);
            panel3.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 48);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
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
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(83, 28);
            label2.Name = "label2";
            label2.Size = new Size(152, 38);
            label2.TabIndex = 1;
            label2.Text = "RedAitana";
            // 
            // btnGestionVoluntarios
            // 
            btnGestionVoluntarios.BackColor = Color.FromArgb(117, 76, 154);
            btnGestionVoluntarios.FlatAppearance.BorderSize = 0;
            btnGestionVoluntarios.FlatStyle = FlatStyle.Flat;
            btnGestionVoluntarios.ForeColor = Color.White;
            btnGestionVoluntarios.Location = new Point(13, 280);
            btnGestionVoluntarios.Name = "btnGestionVoluntarios";
            btnGestionVoluntarios.Size = new Size(222, 61);
            btnGestionVoluntarios.TabIndex = 3;
            btnGestionVoluntarios.Text = "Gestión Voluntarios";
            btnGestionVoluntarios.UseVisualStyleBackColor = false;
            // 
            // btnGestionEmpleados
            // 
            btnGestionEmpleados.BackColor = Color.FromArgb(117, 76, 154);
            btnGestionEmpleados.FlatAppearance.BorderSize = 0;
            btnGestionEmpleados.FlatStyle = FlatStyle.Flat;
            btnGestionEmpleados.ForeColor = Color.White;
            btnGestionEmpleados.Location = new Point(12, 197);
            btnGestionEmpleados.Name = "btnGestionEmpleados";
            btnGestionEmpleados.Size = new Size(223, 61);
            btnGestionEmpleados.TabIndex = 2;
            btnGestionEmpleados.Text = "Gestión Empleados";
            btnGestionEmpleados.UseVisualStyleBackColor = false;
            // 
            // btnRegistroGeneral
            // 
            btnRegistroGeneral.BackColor = Color.FromArgb(117, 76, 154);
            btnRegistroGeneral.FlatAppearance.BorderSize = 0;
            btnRegistroGeneral.FlatStyle = FlatStyle.Flat;
            btnRegistroGeneral.ForeColor = Color.White;
            btnRegistroGeneral.Location = new Point(13, 114);
            btnRegistroGeneral.Name = "btnRegistroGeneral";
            btnRegistroGeneral.Size = new Size(223, 61);
            btnRegistroGeneral.TabIndex = 0;
            btnRegistroGeneral.Text = "Registro General";
            btnRegistroGeneral.UseVisualStyleBackColor = false;
            // 
            // GestionEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Name = "GestionEmpleados";
            Text = "GestionEmpleados";
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnAtras;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label2;
        private Button btnGestionVoluntarios;
        private Button btnGestionEmpleados;
        private Button btnRegistroGeneral;
        private Panel panel4;
    }
}