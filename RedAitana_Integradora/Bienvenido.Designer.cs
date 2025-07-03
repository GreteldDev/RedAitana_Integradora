
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
            panel1 = new Panel();
            panel3 = new Panel();
            btnGestionVoluntarios = new Button();
            btnRegistroGeneral = new Button();
            btnGestionEmpleados = new Button();
            label3 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(71, 48, 120);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btnGestionEmpleados);
            panel1.Controls.Add(btnGestionVoluntarios);
            panel1.Controls.Add(btnRegistroGeneral);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 444);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 108);
            panel3.TabIndex = 4;
            // 
            // btnGestionVoluntarios
            // 
            btnGestionVoluntarios.BackColor = Color.FromArgb(71, 48, 120);
            btnGestionVoluntarios.FlatAppearance.BorderSize = 0;
            btnGestionVoluntarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(117, 76, 154);
            btnGestionVoluntarios.FlatStyle = FlatStyle.Flat;
            btnGestionVoluntarios.ForeColor = Color.White;
            btnGestionVoluntarios.Location = new Point(0, 280);
            btnGestionVoluntarios.Name = "btnGestionVoluntarios";
            btnGestionVoluntarios.Size = new Size(250, 71);
            btnGestionVoluntarios.TabIndex = 3;
            btnGestionVoluntarios.Text = "Gestión Voluntarios";
            btnGestionVoluntarios.UseVisualStyleBackColor = false;
            btnGestionVoluntarios.Click += btnGestionVoluntarios_Click_1;
            // 
            // btnRegistroGeneral
            // 
            btnRegistroGeneral.BackColor = Color.FromArgb(71, 48, 120);
            btnRegistroGeneral.FlatAppearance.BorderSize = 0;
            btnRegistroGeneral.FlatAppearance.MouseOverBackColor = Color.FromArgb(117, 76, 154);
            btnRegistroGeneral.FlatStyle = FlatStyle.Flat;
            btnRegistroGeneral.ForeColor = Color.White;
            btnRegistroGeneral.Location = new Point(0, 114);
            btnRegistroGeneral.Name = "btnRegistroGeneral";
            btnRegistroGeneral.Size = new Size(250, 88);
            btnRegistroGeneral.TabIndex = 0;
            btnRegistroGeneral.Text = "Registro General";
            btnRegistroGeneral.UseVisualStyleBackColor = false;
            btnRegistroGeneral.Click += btnRegistroGeneral_Click;
            // 
            // btnGestionEmpleados
            // 
            btnGestionEmpleados.BackColor = Color.FromArgb(71, 48, 120);
            btnGestionEmpleados.FlatAppearance.BorderSize = 0;
            btnGestionEmpleados.FlatAppearance.MouseOverBackColor = Color.FromArgb(117, 76, 154);
            btnGestionEmpleados.FlatStyle = FlatStyle.Flat;
            btnGestionEmpleados.ForeColor = Color.White;
            btnGestionEmpleados.Location = new Point(0, 185);
            btnGestionEmpleados.Name = "btnGestionEmpleados";
            btnGestionEmpleados.Size = new Size(250, 84);
            btnGestionEmpleados.TabIndex = 2;
            btnGestionEmpleados.Text = "Gestión Empleados";
            btnGestionEmpleados.UseVisualStyleBackColor = false;
            btnGestionEmpleados.Click += btnGestionEmpleados_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(315, 168);
            label3.Name = "label3";
            label3.Size = new Size(0, 81);
            label3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(250, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(605, 444);
            panel2.TabIndex = 2;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Purple;
            label4.Location = new Point(87, 185);
            label4.Name = "label4";
            label4.Size = new Size(484, 81);
            label4.TabIndex = 4;
            label4.Text = "BIENVENIDO/A \r\n";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // Bienvenido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 444);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(panel1);
            Location = new Point(372, 191);
            Name = "Bienvenido";
            Text = "Form2";
            Load += Bienvenido_Load_1;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private Button btnRegistroGeneral;
        private Label label1;
        private Button btnGestionVoluntarios;
        private Button btnGestionEmpleados;
        private Label label3;
        private Panel panel2;
        private Label label4;
        private Panel panel3;
    }
}