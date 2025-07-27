
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
            panel2 = new Panel();
            label1 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            btnEditar = new Button();
            label4 = new Label();
            dgvVisitantes = new DataGridView();
            txtBusqueda = new TextBox();
            btnAgregar = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVisitantes).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnAgregar);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(btnEditar);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dgvVisitantes);
            panel2.Controls.Add(txtBusqueda);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 450);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(71, 48, 120);
            label1.Location = new Point(32, 116);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 31;
            label1.Text = "Buscador";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(71, 48, 120);
            label3.Location = new Point(32, 19);
            label3.Name = "label3";
            label3.Size = new Size(333, 64);
            label3.TabIndex = 30;
            label3.Text = "Catálogo de \r\nVisitantes y Beneficiarios";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(494, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(112, 74);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(177, 135, 193);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 128, 108);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Century Gothic", 9F);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(275, 180);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 50);
            btnEditar.TabIndex = 23;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(6, 77);
            label4.Name = "label4";
            label4.Size = new Size(603, 20);
            label4.TabIndex = 28;
            label4.Text = "___________________________________________________________________________________________________";
            // 
            // dgvVisitantes
            // 
            dgvVisitantes.BackgroundColor = Color.FromArgb(224, 200, 232);
            dgvVisitantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVisitantes.Location = new Point(32, 252);
            dgvVisitantes.Name = "dgvVisitantes";
            dgvVisitantes.RowHeadersWidth = 51;
            dgvVisitantes.Size = new Size(544, 188);
            dgvVisitantes.TabIndex = 27;
            // 
            // txtBusqueda
            // 
            txtBusqueda.BackColor = Color.FromArgb(224, 200, 232);
            txtBusqueda.Location = new Point(142, 113);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(434, 27);
            txtBusqueda.TabIndex = 26;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(177, 135, 193);
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 128, 108);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Century Gothic", 9F);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(32, 180);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(215, 50);
            btnAgregar.TabIndex = 32;
            btnAgregar.Text = "+ Nuevo Visitante/Beneficiario";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // GestionVoluntarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Name = "GestionVoluntarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GestionVoluntarios";
            Load += GestionVoluntarios_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVisitantes).EndInit();
            ResumeLayout(false);
        }

        

        #endregion
        private Panel panel2;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox2;
        private Button btnEditar;
        private Label label4;
        private DataGridView dgvVisitantes;
        private TextBox txtBusqueda;
        private Button btnAgregar;
    }
}