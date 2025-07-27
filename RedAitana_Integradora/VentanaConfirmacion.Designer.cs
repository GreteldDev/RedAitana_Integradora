namespace RedAitana_Integradora
{
    partial class VentanaConfirmacion
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
            txtClave = new TextBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 27);
            label1.Name = "label1";
            label1.Size = new Size(162, 60);
            label1.TabIndex = 0;
            label1.Text = "Ingrese la contraseña \r\nde administrador\r\npara continuar";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(50, 109);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(166, 27);
            txtClave.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(26, 164);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.White;
            btnAceptar.ForeColor = Color.Black;
            btnAceptar.Location = new Point(146, 164);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // VentanaConfirmacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(117, 76, 154);
            ClientSize = new Size(279, 227);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(txtClave);
            Controls.Add(label1);
            Name = "VentanaConfirmacion";
            Text = "VentanaConfirmacion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtClave;
        private Button btnCancelar;
        private Button btnAceptar;
    }
}