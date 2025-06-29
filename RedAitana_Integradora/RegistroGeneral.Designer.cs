namespace RedAitana_Integradora
{
    partial class RegistroGeneral
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
            button3 = new Button();
            button2 = new Button();
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            button4 = new Button();
            button5 = new Button();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            btnAtras = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(71, 48, 120);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(170, 450);
            panel1.TabIndex = 1;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(117, 76, 154);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(13, 280);
            button3.Name = "button3";
            button3.Size = new Size(145, 61);
            button3.TabIndex = 3;
            button3.Text = "Gestión Voluntarios";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(117, 76, 154);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(12, 197);
            button2.Name = "button2";
            button2.Size = new Size(145, 61);
            button2.TabIndex = 2;
            button2.Text = "Gestión Empleados";
            button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 24);
            label2.Name = "label2";
            label2.Size = new Size(152, 38);
            label2.TabIndex = 1;
            label2.Text = "RedAitana";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(223, 128, 108);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(13, 114);
            button1.Name = "button1";
            button1.Size = new Size(145, 61);
            button1.TabIndex = 0;
            button1.Text = "Registro General";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(198, 24);
            label1.Name = "label1";
            label1.Size = new Size(268, 38);
            label1.TabIndex = 4;
            label1.Text = "Registros Recientes";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(177, 135, 193);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(351, 126);
            button4.Name = "button4";
            button4.Size = new Size(115, 36);
            button4.TabIndex = 4;
            button4.Text = "Visita General";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(177, 135, 193);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(493, 126);
            button5.Name = "button5";
            button5.Size = new Size(115, 36);
            button5.TabIndex = 5;
            button5.Text = "Visita";
            button5.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(203, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(562, 27);
            textBox1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(209, 192);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(569, 233);
            dataGridView1.TabIndex = 7;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.FromArgb(177, 135, 193);
            btnAtras.FlatAppearance.BorderSize = 0;
            btnAtras.FlatStyle = FlatStyle.Flat;
            btnAtras.ForeColor = Color.White;
            btnAtras.Location = new Point(209, 126);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(115, 36);
            btnAtras.TabIndex = 8;
            btnAtras.Text = "<- Atras";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // RegistroGeneral
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAtras);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "RegistroGeneral";
            Text = "Form3";
            Load += Form3_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button2;
        private Label label2;
        private Button button1;
        private Label label1;
        private Button button4;
        private Button button5;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button btnAtras;
    }
}