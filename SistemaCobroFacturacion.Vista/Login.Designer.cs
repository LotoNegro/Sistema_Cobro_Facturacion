namespace SistemaCobroFacturacion.Vista
{
    partial class Login
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
            this.lbl_Titulo = new System.Windows.Forms.TextBox();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lvl_Clave = new System.Windows.Forms.Label();
            this.txtbox_Usuario = new System.Windows.Forms.TextBox();
            this.txtbox_Clave = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.BackColor = System.Drawing.SystemColors.Menu;
            this.lbl_Titulo.ForeColor = System.Drawing.Color.Black;
            this.lbl_Titulo.Location = new System.Drawing.Point(62, 57);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(209, 20);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "INGRESO AL SISTEMA";
            this.lbl_Titulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(59, 154);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(56, 13);
            this.lbl_Usuario.TabIndex = 1;
            this.lbl_Usuario.Text = "USUARIO";
            // 
            // lvl_Clave
            // 
            this.lvl_Clave.AutoSize = true;
            this.lvl_Clave.Location = new System.Drawing.Point(59, 219);
            this.lvl_Clave.Name = "lvl_Clave";
            this.lvl_Clave.Size = new System.Drawing.Size(41, 13);
            this.lvl_Clave.TabIndex = 2;
            this.lvl_Clave.Text = "CLAVE";
            // 
            // txtbox_Usuario
            // 
            this.txtbox_Usuario.Location = new System.Drawing.Point(121, 151);
            this.txtbox_Usuario.Name = "txtbox_Usuario";
            this.txtbox_Usuario.Size = new System.Drawing.Size(150, 20);
            this.txtbox_Usuario.TabIndex = 3;
            // 
            // txtbox_Clave
            // 
            this.txtbox_Clave.Location = new System.Drawing.Point(121, 216);
            this.txtbox_Clave.Name = "txtbox_Clave";
            this.txtbox_Clave.Size = new System.Drawing.Size(150, 20);
            this.txtbox_Clave.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 348);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbox_Clave);
            this.Controls.Add(this.txtbox_Usuario);
            this.Controls.Add(this.lvl_Clave);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.lbl_Titulo);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lbl_Titulo;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label lvl_Clave;
        private System.Windows.Forms.TextBox txtbox_Usuario;
        private System.Windows.Forms.TextBox txtbox_Clave;
        private System.Windows.Forms.Button button1;
    }
}