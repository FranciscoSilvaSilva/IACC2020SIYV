namespace IACC2020
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.límitesParaReponerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registarBajaVencimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenciónUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.respaldoYRestauraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbfecha = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbiD = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.listadoDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaProductosAVencerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.proveedorToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.informesToolStripMenuItem,
            this.mantenciónUsuariosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarCategoriasToolStripMenuItem,
            this.gestionarProductosToolStripMenuItem,
            this.límitesParaReponerToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // gestionarCategoriasToolStripMenuItem
            // 
            this.gestionarCategoriasToolStripMenuItem.Name = "gestionarCategoriasToolStripMenuItem";
            this.gestionarCategoriasToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.gestionarCategoriasToolStripMenuItem.Text = "Gestionar categorías";
            this.gestionarCategoriasToolStripMenuItem.Click += new System.EventHandler(this.GestionarCategoriasToolStripMenuItem_Click);
            // 
            // gestionarProductosToolStripMenuItem
            // 
            this.gestionarProductosToolStripMenuItem.Name = "gestionarProductosToolStripMenuItem";
            this.gestionarProductosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.gestionarProductosToolStripMenuItem.Text = "Gestionar productos";
            this.gestionarProductosToolStripMenuItem.Click += new System.EventHandler(this.GestionarProductosToolStripMenuItem_Click);
            // 
            // límitesParaReponerToolStripMenuItem
            // 
            this.límitesParaReponerToolStripMenuItem.Name = "límitesParaReponerToolStripMenuItem";
            this.límitesParaReponerToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.límitesParaReponerToolStripMenuItem.Text = "Límites para reponer";
            this.límitesParaReponerToolStripMenuItem.Click += new System.EventHandler(this.LímitesParaReponerToolStripMenuItem_Click);
            // 
            // proveedorToolStripMenuItem
            // 
            this.proveedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarProveedoresToolStripMenuItem});
            this.proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
            this.proveedorToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.proveedorToolStripMenuItem.Text = "Proveedor";
            this.proveedorToolStripMenuItem.Click += new System.EventHandler(this.ProveedorToolStripMenuItem_Click);
            // 
            // gestionarProveedoresToolStripMenuItem
            // 
            this.gestionarProveedoresToolStripMenuItem.Name = "gestionarProveedoresToolStripMenuItem";
            this.gestionarProveedoresToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.gestionarProveedoresToolStripMenuItem.Text = "Gestionar proveedores";
            this.gestionarProveedoresToolStripMenuItem.Click += new System.EventHandler(this.GestionarProveedoresToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarVentasToolStripMenuItem,
            this.registarBajaVencimientoToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // registrarVentasToolStripMenuItem
            // 
            this.registrarVentasToolStripMenuItem.Name = "registrarVentasToolStripMenuItem";
            this.registrarVentasToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.registrarVentasToolStripMenuItem.Text = "Registrar Ventas";
            // 
            // registarBajaVencimientoToolStripMenuItem
            // 
            this.registarBajaVencimientoToolStripMenuItem.Name = "registarBajaVencimientoToolStripMenuItem";
            this.registarBajaVencimientoToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.registarBajaVencimientoToolStripMenuItem.Text = "Registar Baja por Vencimiento";
            this.registarBajaVencimientoToolStripMenuItem.Click += new System.EventHandler(this.RegistarBajaVencimientoToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeProductosToolStripMenuItem,
            this.listaProductosAVencerToolStripMenuItem});
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // mantenciónUsuariosToolStripMenuItem
            // 
            this.mantenciónUsuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarUsuariosToolStripMenuItem,
            this.respaldoYRestauraciónToolStripMenuItem});
            this.mantenciónUsuariosToolStripMenuItem.Name = "mantenciónUsuariosToolStripMenuItem";
            this.mantenciónUsuariosToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.mantenciónUsuariosToolStripMenuItem.Text = "Mantención";
            // 
            // gestionarUsuariosToolStripMenuItem
            // 
            this.gestionarUsuariosToolStripMenuItem.Name = "gestionarUsuariosToolStripMenuItem";
            this.gestionarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.gestionarUsuariosToolStripMenuItem.Text = "Gestionar Usuarios";
            this.gestionarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.GestionarUsuariosToolStripMenuItem_Click);
            // 
            // respaldoYRestauraciónToolStripMenuItem
            // 
            this.respaldoYRestauraciónToolStripMenuItem.Name = "respaldoYRestauraciónToolStripMenuItem";
            this.respaldoYRestauraciónToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.respaldoYRestauraciónToolStripMenuItem.Text = "Respaldo y Restauración";
            this.respaldoYRestauraciónToolStripMenuItem.Click += new System.EventHandler(this.RespaldoYRestauraciónToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick_1);
            // 
            // lbfecha
            // 
            this.lbfecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbfecha.AutoSize = true;
            this.lbfecha.Location = new System.Drawing.Point(651, 428);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(37, 13);
            this.lbfecha.TabIndex = 2;
            this.lbfecha.Text = "Fecha";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(683, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cerrar sesión";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lbiD
            // 
            this.lbiD.AutoSize = true;
            this.lbiD.Location = new System.Drawing.Point(753, 31);
            this.lbiD.Name = "lbiD";
            this.lbiD.Size = new System.Drawing.Size(35, 13);
            this.lbiD.TabIndex = 4;
            this.lbiD.Text = "label1";
            this.lbiD.UseWaitCursor = true;
            this.lbiD.Visible = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(654, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // listadoDeProductosToolStripMenuItem
            // 
            this.listadoDeProductosToolStripMenuItem.Name = "listadoDeProductosToolStripMenuItem";
            this.listadoDeProductosToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.listadoDeProductosToolStripMenuItem.Text = "Listado de productos";
            // 
            // listaProductosAVencerToolStripMenuItem
            // 
            this.listaProductosAVencerToolStripMenuItem.Name = "listaProductosAVencerToolStripMenuItem";
            this.listaProductosAVencerToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.listaProductosAVencerToolStripMenuItem.Text = "Lista productos a vencer";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbiD);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbfecha);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Principal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarProveedoresToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbfecha;
        private System.Windows.Forms.ToolStripMenuItem mantenciónUsuariosToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbiD;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem gestionarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem respaldoYRestauraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarCategoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem límitesParaReponerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registarBajaVencimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaProductosAVencerToolStripMenuItem;
    }
}