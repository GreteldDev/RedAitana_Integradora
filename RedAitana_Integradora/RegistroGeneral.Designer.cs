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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroGeneral));
            label1 = new Label();
            btnSeleccionar = new Button();
            dgvGeneral = new DataGridView();
            pictureBox1 = new PictureBox();
            btnEditar = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvGeneral).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(71, 48, 120);
            label1.Location = new Point(36, 31);
            label1.Name = "label1";
            label1.Size = new Size(292, 37);
            label1.TabIndex = 4;
            label1.Text = "Registros Recientes";
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.BackColor = Color.FromArgb(177, 135, 193);
            btnSeleccionar.FlatAppearance.BorderSize = 0;
            btnSeleccionar.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 128, 108);
            btnSeleccionar.FlatStyle = FlatStyle.Flat;
            btnSeleccionar.Font = new Font("Century Gothic", 9F);
            btnSeleccionar.ForeColor = Color.White;
            btnSeleccionar.Location = new Point(23, 134);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(217, 36);
            btnSeleccionar.TabIndex = 5;
            btnSeleccionar.Text = "Visita por selección";
            btnSeleccionar.UseVisualStyleBackColor = false;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // dgvGeneral
            // 
            dgvGeneral.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGeneral.BackgroundColor = Color.FromArgb(224, 200, 232);
            dgvGeneral.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGeneral.GridColor = Color.FromArgb(177, 135, 193);
            dgvGeneral.Location = new Point(23, 190);
            dgvGeneral.Name = "dgvGeneral";
            dgvGeneral.RowHeadersWidth = 51;
            dgvGeneral.Size = new Size(569, 233);
            dgvGeneral.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(699, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(177, 135, 193);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 128, 108);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Century Gothic", 9F);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(263, 134);
            btnEditar.Margin = new Padding(2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(106, 36);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(12, 74);
            label4.Name = "label4";
            label4.Size = new Size(771, 20);
            label4.TabIndex = 19;
            label4.Text = "_______________________________________________________________________________________________________________________________";
            // 
            // RegistroGeneral
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(btnEditar);
            Controls.Add(pictureBox1);
            Controls.Add(dgvGeneral);
            Controls.Add(btnSeleccionar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistroGeneral";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistroGeneral";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGeneral).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnSeleccionar;
        private DataGridView dgvGeneral;
        private PictureBox pictureBox1;
        private Button btnEditar;
        private Label label4;
    }
}