namespace IACC2020
{
    partial class GestionProductos
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.IDPro = new System.Windows.Forms.TextBox();
            this.NomPro = new System.Windows.Forms.TextBox();
            this.StockPro = new System.Windows.Forms.TextBox();
            this.PrecioPro = new System.Windows.Forms.TextBox();
            this.DesPro = new System.Windows.Forms.TextBox();
            this.RdDisponible = new System.Windows.Forms.RadioButton();
            this.RdNoDisponible = new System.Windows.Forms.RadioButton();
            this.GridPro = new System.Windows.Forms.DataGridView();
            this.CboxCatPro = new System.Windows.Forms.ComboBox();
            this.CBoxPrvPro = new System.Windows.Forms.ComboBox();
            this.IDnew = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BusPro = new System.Windows.Forms.TextBox();
            this.AgregarPro = new System.Windows.Forms.Button();
            this.ModPro = new System.Windows.Forms.Button();
            this.ElimPro = new System.Windows.Forms.Button();
            this.LimPro = new System.Windows.Forms.Button();
            this.errorPro = new System.Windows.Forms.ErrorProvider(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.Calendario = new System.Windows.Forms.MonthCalendar();
            this.VenFecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridPro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(530, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Descripción";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Categoría";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Proveedor";
            // 
            // IDPro
            // 
            this.IDPro.Enabled = false;
            this.IDPro.Location = new System.Drawing.Point(101, 1);
            this.IDPro.Name = "IDPro";
            this.IDPro.Size = new System.Drawing.Size(29, 20);
            this.IDPro.TabIndex = 8;
            // 
            // NomPro
            // 
            this.NomPro.Location = new System.Drawing.Point(101, 32);
            this.NomPro.Name = "NomPro";
            this.NomPro.Size = new System.Drawing.Size(130, 20);
            this.NomPro.TabIndex = 9;
            // 
            // StockPro
            // 
            this.StockPro.Location = new System.Drawing.Point(101, 59);
            this.StockPro.Name = "StockPro";
            this.StockPro.Size = new System.Drawing.Size(130, 20);
            this.StockPro.TabIndex = 10;
            // 
            // PrecioPro
            // 
            this.PrecioPro.Location = new System.Drawing.Point(101, 85);
            this.PrecioPro.Name = "PrecioPro";
            this.PrecioPro.Size = new System.Drawing.Size(130, 20);
            this.PrecioPro.TabIndex = 11;
            // 
            // DesPro
            // 
            this.DesPro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DesPro.Location = new System.Drawing.Point(533, 25);
            this.DesPro.Multiline = true;
            this.DesPro.Name = "DesPro";
            this.DesPro.Size = new System.Drawing.Size(61, 162);
            this.DesPro.TabIndex = 12;
            // 
            // RdDisponible
            // 
            this.RdDisponible.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RdDisponible.AutoSize = true;
            this.RdDisponible.Location = new System.Drawing.Point(89, 201);
            this.RdDisponible.Name = "RdDisponible";
            this.RdDisponible.Size = new System.Drawing.Size(74, 17);
            this.RdDisponible.TabIndex = 13;
            this.RdDisponible.TabStop = true;
            this.RdDisponible.Text = "Disponible";
            this.RdDisponible.UseVisualStyleBackColor = true;
            // 
            // RdNoDisponible
            // 
            this.RdNoDisponible.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RdNoDisponible.AutoSize = true;
            this.RdNoDisponible.Location = new System.Drawing.Point(178, 199);
            this.RdNoDisponible.Name = "RdNoDisponible";
            this.RdNoDisponible.Size = new System.Drawing.Size(91, 17);
            this.RdNoDisponible.TabIndex = 14;
            this.RdNoDisponible.TabStop = true;
            this.RdNoDisponible.Text = "No Disponible";
            this.RdNoDisponible.UseVisualStyleBackColor = true;
            // 
            // GridPro
            // 
            this.GridPro.AllowUserToAddRows = false;
            this.GridPro.AllowUserToDeleteRows = false;
            this.GridPro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridPro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridPro.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPro.Location = new System.Drawing.Point(35, 239);
            this.GridPro.Name = "GridPro";
            this.GridPro.ReadOnly = true;
            this.GridPro.Size = new System.Drawing.Size(541, 150);
            this.GridPro.TabIndex = 17;
            this.GridPro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPro_CellContentClick);
            // 
            // CboxCatPro
            // 
            this.CboxCatPro.FormattingEnabled = true;
            this.CboxCatPro.Location = new System.Drawing.Point(101, 112);
            this.CboxCatPro.Name = "CboxCatPro";
            this.CboxCatPro.Size = new System.Drawing.Size(130, 21);
            this.CboxCatPro.TabIndex = 18;
            this.CboxCatPro.SelectedIndexChanged += new System.EventHandler(this.CboxCatPro_SelectedIndexChanged);
            // 
            // CBoxPrvPro
            // 
            this.CBoxPrvPro.FormattingEnabled = true;
            this.CBoxPrvPro.Location = new System.Drawing.Point(101, 143);
            this.CBoxPrvPro.Name = "CBoxPrvPro";
            this.CBoxPrvPro.Size = new System.Drawing.Size(130, 21);
            this.CBoxPrvPro.TabIndex = 19;
            // 
            // IDnew
            // 
            this.IDnew.AutoSize = true;
            this.IDnew.Location = new System.Drawing.Point(195, 3);
            this.IDnew.Name = "IDnew";
            this.IDnew.Size = new System.Drawing.Size(35, 13);
            this.IDnew.TabIndex = 20;
            this.IDnew.Text = "label9";
            this.IDnew.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Buscar";
            // 
            // BusPro
            // 
            this.BusPro.Location = new System.Drawing.Point(101, 170);
            this.BusPro.Name = "BusPro";
            this.BusPro.Size = new System.Drawing.Size(130, 20);
            this.BusPro.TabIndex = 22;
            this.BusPro.TextChanged += new System.EventHandler(this.BusPro_TextChanged);
            // 
            // AgregarPro
            // 
            this.AgregarPro.Location = new System.Drawing.Point(276, 199);
            this.AgregarPro.Name = "AgregarPro";
            this.AgregarPro.Size = new System.Drawing.Size(75, 23);
            this.AgregarPro.TabIndex = 23;
            this.AgregarPro.Text = "Agregar";
            this.AgregarPro.UseVisualStyleBackColor = true;
            this.AgregarPro.Click += new System.EventHandler(this.AgregarPro_Click);
            // 
            // ModPro
            // 
            this.ModPro.Location = new System.Drawing.Point(357, 199);
            this.ModPro.Name = "ModPro";
            this.ModPro.Size = new System.Drawing.Size(75, 23);
            this.ModPro.TabIndex = 24;
            this.ModPro.Text = "Modificar";
            this.ModPro.UseVisualStyleBackColor = true;
            this.ModPro.Click += new System.EventHandler(this.ModPro_Click);
            // 
            // ElimPro
            // 
            this.ElimPro.Location = new System.Drawing.Point(438, 199);
            this.ElimPro.Name = "ElimPro";
            this.ElimPro.Size = new System.Drawing.Size(75, 23);
            this.ElimPro.TabIndex = 25;
            this.ElimPro.Text = "Eliminar";
            this.ElimPro.UseVisualStyleBackColor = true;
            this.ElimPro.Click += new System.EventHandler(this.ElimPro_Click);
            // 
            // LimPro
            // 
            this.LimPro.Location = new System.Drawing.Point(519, 199);
            this.LimPro.Name = "LimPro";
            this.LimPro.Size = new System.Drawing.Size(75, 23);
            this.LimPro.TabIndex = 26;
            this.LimPro.Text = "Limpiar";
            this.LimPro.UseVisualStyleBackColor = true;
            this.LimPro.Click += new System.EventHandler(this.LimPro_Click);
            // 
            // errorPro
            // 
            this.errorPro.ContainerControl = this;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(246, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Fecha Vecimiento";
            // 
            // Calendario
            // 
            this.Calendario.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.Calendario.Location = new System.Drawing.Point(249, 25);
            this.Calendario.MaxSelectionCount = 1;
            this.Calendario.MinDate = new System.DateTime(2020, 10, 2, 11, 16, 12, 0);
            this.Calendario.Name = "Calendario";
            this.Calendario.TabIndex = 28;
            this.Calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendario_DateChanged);
            // 
            // VenFecha
            // 
            this.VenFecha.AutoSize = true;
            this.VenFecha.Location = new System.Drawing.Point(379, 8);
            this.VenFecha.Name = "VenFecha";
            this.VenFecha.Size = new System.Drawing.Size(41, 13);
            this.VenFecha.TabIndex = 29;
            this.VenFecha.Text = "label11";
            this.VenFecha.Visible = false;
            // 
            // GestionProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(605, 450);
            this.Controls.Add(this.VenFecha);
            this.Controls.Add(this.Calendario);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LimPro);
            this.Controls.Add(this.ElimPro);
            this.Controls.Add(this.ModPro);
            this.Controls.Add(this.AgregarPro);
            this.Controls.Add(this.BusPro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.IDnew);
            this.Controls.Add(this.CBoxPrvPro);
            this.Controls.Add(this.CboxCatPro);
            this.Controls.Add(this.GridPro);
            this.Controls.Add(this.RdNoDisponible);
            this.Controls.Add(this.RdDisponible);
            this.Controls.Add(this.DesPro);
            this.Controls.Add(this.PrecioPro);
            this.Controls.Add(this.StockPro);
            this.Controls.Add(this.NomPro);
            this.Controls.Add(this.IDPro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "GestionProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión Productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GestionProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridPro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox IDPro;
        private System.Windows.Forms.TextBox NomPro;
        private System.Windows.Forms.TextBox StockPro;
        private System.Windows.Forms.TextBox PrecioPro;
        private System.Windows.Forms.TextBox DesPro;
        private System.Windows.Forms.RadioButton RdDisponible;
        private System.Windows.Forms.RadioButton RdNoDisponible;
        private System.Windows.Forms.DataGridView GridPro;
        private System.Windows.Forms.ComboBox CboxCatPro;
        private System.Windows.Forms.ComboBox CBoxPrvPro;
        private System.Windows.Forms.Label IDnew;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox BusPro;
        private System.Windows.Forms.Button AgregarPro;
        private System.Windows.Forms.Button ModPro;
        private System.Windows.Forms.Button ElimPro;
        private System.Windows.Forms.Button LimPro;
        private System.Windows.Forms.ErrorProvider errorPro;
        private System.Windows.Forms.MonthCalendar Calendario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label VenFecha;
    }
}