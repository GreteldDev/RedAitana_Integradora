namespace RedAitana_Integradora
{
    partial class GestionVoluntarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionVoluntarios));
            btnAtras = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label2 = new Label();
            btnGestionVoluntarios = new Button();
            btnGestionEmpleados = new Button();
            btnRegistroGeneral = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.FromArgb(177, 135, 193);
            btnAtras.FlatStyle = FlatStyle.Flat;
            btnAtras.ForeColor = Color.White;
            btnAtras.Location = new Point(23, 153);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(94, 41);
            btnAtras.TabIndex = 1;
            btnAtras.Text = "<-Atras";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
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
            btnGestionVoluntarios.BackColor = Color.FromArgb(223, 128, 108);
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
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnAtras);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(250, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(550, 450);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 214);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(504, 213);
            dataGridView1.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(177, 135, 193);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(148, 153);
            button1.Name = "button1";
            button1.Size = new Size(164, 41);
            button1.TabIndex = 8;
            button1.Text = "+ Nuevo Voluntario";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 114);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(493, 27);
            textBox1.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(426, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(112, 74);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(0, 75);
            label4.Name = "label4";
            label4.Size = new Size(543, 20);
            label4.TabIndex = 3;
            label4.Text = "_________________________________________________________________________________________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(23, 28);
            label3.Name = "label3";
            label3.Size = new Size(330, 38);
            label3.TabIndex = 5;
            label3.Text = "Catálogo de voluntarios";
            // 
            // GestionVoluntarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "GestionVoluntarios";
            Text = "GestionVoluntarios";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAtras;
        private Panel panel1;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label2;
        private Button btnGestionVoluntarios;
        private Button btnGestionEmpleados;
        private Button btnRegistroGeneral;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label3;
        private Button button1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
    }
}