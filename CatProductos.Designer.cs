namespace IACC2020
{
    partial class CatProductos
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
            this.IDCatPro = new System.Windows.Forms.TextBox();
            this.NomCatPro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AgregarCatPro = new System.Windows.Forms.Button();
            this.ModCatPro = new System.Windows.Forms.Button();
            this.ElimCatPro = new System.Windows.Forms.Button();
            this.LimCatPro = new System.Windows.Forms.Button();
            this.GridCatPrdouctos = new System.Windows.Forms.DataGridView();
            this.errorCatPro = new System.Windows.Forms.ErrorProvider(this.components);
            this.NewIDCatPro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridCatPrdouctos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCatPro)).BeginInit();
            this.SuspendLayout();
            // 
            // IDCatPro
            // 
            this.IDCatPro.Enabled = false;
            this.IDCatPro.Location = new System.Drawing.Point(92, 29);
            this.IDCatPro.Name = "IDCatPro";
            this.IDCatPro.Size = new System.Drawing.Size(53, 20);
            this.IDCatPro.TabIndex = 0;
            // 
            // NomCatPro
            // 
            this.NomCatPro.Location = new System.Drawing.Point(92, 75);
            this.NomCatPro.Name = "NomCatPro";
            this.NomCatPro.Size = new System.Drawing.Size(100, 20);
            this.NomCatPro.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre";
            // 
            // AgregarCatPro
            // 
            this.AgregarCatPro.Location = new System.Drawing.Point(22, 173);
            this.AgregarCatPro.Name = "AgregarCatPro";
            this.AgregarCatPro.Size = new System.Drawing.Size(75, 23);
            this.AgregarCatPro.TabIndex = 6;
            this.AgregarCatPro.Text = "Agregar";
            this.AgregarCatPro.UseVisualStyleBackColor = true;
            this.AgregarCatPro.Click += new System.EventHandler(this.AgregarCatPro_Click);
            // 
            // ModCatPro
            // 
            this.ModCatPro.Location = new System.Drawing.Point(116, 173);
            this.ModCatPro.Name = "ModCatPro";
            this.ModCatPro.Size = new System.Drawing.Size(75, 23);
            this.ModCatPro.TabIndex = 7;
            this.ModCatPro.Text = "Modificar";
            this.ModCatPro.UseVisualStyleBackColor = true;
            this.ModCatPro.Click += new System.EventHandler(this.ModCatPro_Click);
            // 
            // ElimCatPro
            // 
            this.ElimCatPro.Location = new System.Drawing.Point(22, 232);
            this.ElimCatPro.Name = "ElimCatPro";
            this.ElimCatPro.Size = new System.Drawing.Size(75, 23);
            this.ElimCatPro.TabIndex = 8;
            this.ElimCatPro.Text = "Eliminar";
            this.ElimCatPro.UseVisualStyleBackColor = true;
            this.ElimCatPro.Click += new System.EventHandler(this.ElimCatPro_Click);
            // 
            // LimCatPro
            // 
            this.LimCatPro.Location = new System.Drawing.Point(116, 232);
            this.LimCatPro.Name = "LimCatPro";
            this.LimCatPro.Size = new System.Drawing.Size(75, 23);
            this.LimCatPro.TabIndex = 9;
            this.LimCatPro.Text = "Limpiar";
            this.LimCatPro.UseVisualStyleBackColor = true;
            this.LimCatPro.Click += new System.EventHandler(this.LimCatPro_Click);
            // 
            // GridCatPrdouctos
            // 
            this.GridCatPrdouctos.AllowUserToAddRows = false;
            this.GridCatPrdouctos.AllowUserToDeleteRows = false;
            this.GridCatPrdouctos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridCatPrdouctos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridCatPrdouctos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridCatPrdouctos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCatPrdouctos.Location = new System.Drawing.Point(280, 29);
            this.GridCatPrdouctos.Name = "GridCatPrdouctos";
            this.GridCatPrdouctos.ReadOnly = true;
            this.GridCatPrdouctos.Size = new System.Drawing.Size(251, 226);
            this.GridCatPrdouctos.TabIndex = 10;
            this.GridCatPrdouctos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridCatPrdouctos_CellContentClick);
            // 
            // errorCatPro
            // 
            this.errorCatPro.ContainerControl = this;
            // 
            // NewIDCatPro
            // 
            this.NewIDCatPro.AutoSize = true;
            this.NewIDCatPro.Location = new System.Drawing.Point(157, 29);
            this.NewIDCatPro.Name = "NewIDCatPro";
            this.NewIDCatPro.Size = new System.Drawing.Size(72, 13);
            this.NewIDCatPro.TabIndex = 11;
            this.NewIDCatPro.Text = "NewIDCatPro";
            this.NewIDCatPro.Visible = false;
            // 
            // CatProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 270);
            this.Controls.Add(this.NewIDCatPro);
            this.Controls.Add(this.GridCatPrdouctos);
            this.Controls.Add(this.LimCatPro);
            this.Controls.Add(this.ElimCatPro);
            this.Controls.Add(this.ModCatPro);
            this.Controls.Add(this.AgregarCatPro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NomCatPro);
            this.Controls.Add(this.IDCatPro);
            this.MaximizeBox = false;
            this.Name = "CatProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorías";
            this.Load += new System.EventHandler(this.CatProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridCatPrdouctos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCatPro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IDCatPro;
        private System.Windows.Forms.TextBox NomCatPro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AgregarCatPro;
        private System.Windows.Forms.Button ModCatPro;
        private System.Windows.Forms.Button ElimCatPro;
        private System.Windows.Forms.Button LimCatPro;
        private System.Windows.Forms.DataGridView GridCatPrdouctos;
        private System.Windows.Forms.ErrorProvider errorCatPro;
        private System.Windows.Forms.Label NewIDCatPro;
    }
}