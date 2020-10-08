namespace IACC2020
{
    partial class Modulo_RyR
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
            this.RespaldarDB = new System.Windows.Forms.Button();
            this.RestaurarBD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RespaldarDB
            // 
            this.RespaldarDB.Location = new System.Drawing.Point(105, 48);
            this.RespaldarDB.Name = "RespaldarDB";
            this.RespaldarDB.Size = new System.Drawing.Size(75, 23);
            this.RespaldarDB.TabIndex = 0;
            this.RespaldarDB.Text = "Respaldar";
            this.RespaldarDB.UseVisualStyleBackColor = true;
            this.RespaldarDB.Click += new System.EventHandler(this.RespaldarDB_Click);
            // 
            // RestaurarBD
            // 
            this.RestaurarBD.Location = new System.Drawing.Point(105, 96);
            this.RestaurarBD.Name = "RestaurarBD";
            this.RestaurarBD.Size = new System.Drawing.Size(75, 23);
            this.RestaurarBD.TabIndex = 1;
            this.RestaurarBD.Text = "Restaurar";
            this.RestaurarBD.UseVisualStyleBackColor = true;
            this.RestaurarBD.Click += new System.EventHandler(this.RestaurarBD_Click);
            // 
            // Modulo_RyR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 179);
            this.Controls.Add(this.RestaurarBD);
            this.Controls.Add(this.RespaldarDB);
            this.MaximizeBox = false;
            this.Name = "Modulo_RyR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulo_RyR";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RespaldarDB;
        private System.Windows.Forms.Button RestaurarBD;
    }
}