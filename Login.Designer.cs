namespace IACC2020
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lgnusuario = new System.Windows.Forms.TextBox();
            this.lgncontraseña = new System.Windows.Forms.TextBox();
            this.lgningresar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbfecha = new System.Windows.Forms.Label();
            this.lbhora = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbidbit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // lgnusuario
            // 
            this.lgnusuario.Location = new System.Drawing.Point(69, 56);
            this.lgnusuario.Name = "lgnusuario";
            this.lgnusuario.Size = new System.Drawing.Size(100, 20);
            this.lgnusuario.TabIndex = 2;
            // 
            // lgncontraseña
            // 
            this.lgncontraseña.Location = new System.Drawing.Point(69, 117);
            this.lgncontraseña.MaxLength = 200;
            this.lgncontraseña.Name = "lgncontraseña";
            this.lgncontraseña.PasswordChar = '*';
            this.lgncontraseña.Size = new System.Drawing.Size(100, 20);
            this.lgncontraseña.TabIndex = 3;
            // 
            // lgningresar
            // 
            this.lgningresar.Location = new System.Drawing.Point(80, 153);
            this.lgningresar.Name = "lgningresar";
            this.lgningresar.Size = new System.Drawing.Size(75, 23);
            this.lgningresar.TabIndex = 4;
            this.lgningresar.Text = "Ingresar";
            this.lgningresar.UseVisualStyleBackColor = true;
            this.lgningresar.Click += new System.EventHandler(this.Lgningresar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lbfecha
            // 
            this.lbfecha.AutoSize = true;
            this.lbfecha.Location = new System.Drawing.Point(192, 177);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(0, 13);
            this.lbfecha.TabIndex = 5;
            this.lbfecha.Visible = false;
            // 
            // lbhora
            // 
            this.lbhora.AutoSize = true;
            this.lbhora.Location = new System.Drawing.Point(195, 153);
            this.lbhora.Name = "lbhora";
            this.lbhora.Size = new System.Drawing.Size(0, 13);
            this.lbhora.TabIndex = 6;
            this.lbhora.Visible = false;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(13, 13);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(0, 13);
            this.lbID.TabIndex = 7;
            this.lbID.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 8;
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // lbidbit
            // 
            this.lbidbit.AutoSize = true;
            this.lbidbit.Location = new System.Drawing.Point(195, 13);
            this.lbidbit.Name = "lbidbit";
            this.lbidbit.Size = new System.Drawing.Size(0, 13);
            this.lbidbit.TabIndex = 9;
            this.lbidbit.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 202);
            this.Controls.Add(this.lbidbit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.lbhora);
            this.Controls.Add(this.lbfecha);
            this.Controls.Add(this.lgningresar);
            this.Controls.Add(this.lgncontraseña);
            this.Controls.Add(this.lgnusuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lgnusuario;
        private System.Windows.Forms.TextBox lgncontraseña;
        private System.Windows.Forms.Button lgningresar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbfecha;
        private System.Windows.Forms.Label lbhora;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbidbit;
    }
}