namespace IACC2020
{
    partial class Limites
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
            this.AgrLim = new System.Windows.Forms.Button();
            this.ModLim = new System.Windows.Forms.Button();
            this.GridLim = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ElimLim = new System.Windows.Forms.Button();
            this.IDProducto = new System.Windows.Forms.TextBox();
            this.LimiteMod = new System.Windows.Forms.TextBox();
            this.IDLimite = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.errorlimite = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridLim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorlimite)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Límite de alerta";
            // 
            // AgrLim
            // 
            this.AgrLim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AgrLim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AgrLim.Location = new System.Drawing.Point(743, 22);
            this.AgrLim.Name = "AgrLim";
            this.AgrLim.Size = new System.Drawing.Size(36, 23);
            this.AgrLim.TabIndex = 2;
            this.AgrLim.Text = "+";
            this.AgrLim.UseVisualStyleBackColor = true;
            this.AgrLim.Click += new System.EventHandler(this.AgrLim_Click);
            // 
            // ModLim
            // 
            this.ModLim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ModLim.Location = new System.Drawing.Point(743, 310);
            this.ModLim.Name = "ModLim";
            this.ModLim.Size = new System.Drawing.Size(36, 23);
            this.ModLim.TabIndex = 3;
            this.ModLim.Text = "Modificar";
            this.ModLim.UseVisualStyleBackColor = true;
            this.ModLim.Click += new System.EventHandler(this.ModLim_Click);
            // 
            // GridLim
            // 
            this.GridLim.AllowUserToAddRows = false;
            this.GridLim.AllowUserToDeleteRows = false;
            this.GridLim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridLim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridLim.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridLim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridLim.Location = new System.Drawing.Point(23, 26);
            this.GridLim.Name = "GridLim";
            this.GridLim.ReadOnly = true;
            this.GridLim.Size = new System.Drawing.Size(554, 359);
            this.GridLim.TabIndex = 4;
            this.GridLim.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridLim_CellContentClick);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(617, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Agregar un nuevo límite";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(617, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Modificar límite";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(617, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Eliminar límite";
            // 
            // ElimLim
            // 
            this.ElimLim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ElimLim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ElimLim.Location = new System.Drawing.Point(743, 349);
            this.ElimLim.Name = "ElimLim";
            this.ElimLim.Size = new System.Drawing.Size(36, 23);
            this.ElimLim.TabIndex = 8;
            this.ElimLim.Text = "-";
            this.ElimLim.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ElimLim.UseVisualStyleBackColor = true;
            this.ElimLim.Click += new System.EventHandler(this.ElimLim_Click);
            // 
            // IDProducto
            // 
            this.IDProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.IDProducto.Enabled = false;
            this.IDProducto.Location = new System.Drawing.Point(646, 215);
            this.IDProducto.Name = "IDProducto";
            this.IDProducto.Size = new System.Drawing.Size(100, 20);
            this.IDProducto.TabIndex = 9;
            // 
            // LimiteMod
            // 
            this.LimiteMod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LimiteMod.Location = new System.Drawing.Point(646, 262);
            this.LimiteMod.Name = "LimiteMod";
            this.LimiteMod.Size = new System.Drawing.Size(100, 20);
            this.LimiteMod.TabIndex = 10;
            // 
            // IDLimite
            // 
            this.IDLimite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.IDLimite.Enabled = false;
            this.IDLimite.Location = new System.Drawing.Point(646, 167);
            this.IDLimite.Name = "IDLimite";
            this.IDLimite.Size = new System.Drawing.Size(100, 20);
            this.IDLimite.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(604, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "-----------------------------------------------------------";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(671, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "ID Límite";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(666, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "ID Producto";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(671, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Límite";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(592, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Para modificar o eliminar un límite debes";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(592, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "hacer click en el nombre del producto";
            // 
            // errorlimite
            // 
            this.errorlimite.ContainerControl = this;
            // 
            // Limites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IDLimite);
            this.Controls.Add(this.LimiteMod);
            this.Controls.Add(this.IDProducto);
            this.Controls.Add(this.ElimLim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GridLim);
            this.Controls.Add(this.ModLim);
            this.Controls.Add(this.AgrLim);
            this.Controls.Add(this.label1);
            this.Name = "Limites";
            this.Text = "Limites";
            this.Load += new System.EventHandler(this.Limites_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridLim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorlimite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AgrLim;
        private System.Windows.Forms.Button ModLim;
        private System.Windows.Forms.DataGridView GridLim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ElimLim;
        private System.Windows.Forms.TextBox IDProducto;
        private System.Windows.Forms.TextBox LimiteMod;
        private System.Windows.Forms.TextBox IDLimite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider errorlimite;
    }
}