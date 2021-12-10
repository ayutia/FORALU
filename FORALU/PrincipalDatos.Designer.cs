
namespace FORALU
{
    partial class PrincipalDatos
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblPaterno = new System.Windows.Forms.Label();
            this.txtApeP = new System.Windows.Forms.TextBox();
            this.lblMaterno = new System.Windows.Forms.Label();
            this.txtApeM = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 18);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(153, 15);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(344, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // lblPaterno
            // 
            this.lblPaterno.AutoSize = true;
            this.lblPaterno.Location = new System.Drawing.Point(20, 66);
            this.lblPaterno.Name = "lblPaterno";
            this.lblPaterno.Size = new System.Drawing.Size(111, 17);
            this.lblPaterno.TabIndex = 2;
            this.lblPaterno.Text = "Apellido paterno";
            // 
            // txtApeP
            // 
            this.txtApeP.Location = new System.Drawing.Point(153, 63);
            this.txtApeP.Name = "txtApeP";
            this.txtApeP.Size = new System.Drawing.Size(344, 22);
            this.txtApeP.TabIndex = 3;
            // 
            // lblMaterno
            // 
            this.lblMaterno.AutoSize = true;
            this.lblMaterno.Location = new System.Drawing.Point(20, 117);
            this.lblMaterno.Name = "lblMaterno";
            this.lblMaterno.Size = new System.Drawing.Size(114, 17);
            this.lblMaterno.TabIndex = 4;
            this.lblMaterno.Text = "Apellido materno";
            this.lblMaterno.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtApeM
            // 
            this.txtApeM.Location = new System.Drawing.Point(153, 117);
            this.txtApeM.Name = "txtApeM";
            this.txtApeM.Size = new System.Drawing.Size(344, 22);
            this.txtApeM.TabIndex = 5;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(20, 161);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(41, 17);
            this.lblEdad.TabIndex = 6;
            this.lblEdad.Text = "Edad";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(153, 161);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(56, 22);
            this.txtEdad.TabIndex = 7;
            this.txtEdad.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(12, 213);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(565, 30);
            this.btnIngresar.TabIndex = 8;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // PrincipalDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 255);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.txtApeM);
            this.Controls.Add(this.lblMaterno);
            this.Controls.Add(this.txtApeP);
            this.Controls.Add(this.lblPaterno);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "PrincipalDatos";
            this.Text = "Ingrese datos del alumno";
            this.Load += new System.EventHandler(this.PrincipalDatos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblPaterno;
        private System.Windows.Forms.TextBox txtApeP;
        private System.Windows.Forms.Label lblMaterno;
        private System.Windows.Forms.TextBox txtApeM;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Button btnIngresar;
    }
}