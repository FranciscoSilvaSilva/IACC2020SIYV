namespace IACC2020
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Idprv = new System.Windows.Forms.TextBox();
            this.nombreprov = new System.Windows.Forms.TextBox();
            this.dirprov = new System.Windows.Forms.TextBox();
            this.rutprov = new System.Windows.Forms.TextBox();
            this.buscarprov = new System.Windows.Forms.TextBox();
            this.tbprov = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.mdprov = new System.Windows.Forms.Button();
            this.eliprv = new System.Windows.Forms.Button();
            this.limprv = new System.Windows.Forms.Button();
            this.errorprv = new System.Windows.Forms.ErrorProvider(this.components);
            this.newid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbprov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorprv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 51);
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
            this.label3.Location = new System.Drawing.Point(23, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dirección";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rut";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Buscar";
            // 
            // Idprv
            // 
            this.Idprv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Idprv.Location = new System.Drawing.Point(81, 22);
            this.Idprv.Name = "Idprv";
            this.Idprv.Size = new System.Drawing.Size(104, 20);
            this.Idprv.TabIndex = 5;
            this.Idprv.TextChanged += new System.EventHandler(this.Idprv_TextChanged);
            // 
            // nombreprov
            // 
            this.nombreprov.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nombreprov.Location = new System.Drawing.Point(81, 48);
            this.nombreprov.Name = "nombreprov";
            this.nombreprov.Size = new System.Drawing.Size(281, 20);
            this.nombreprov.TabIndex = 6;
            // 
            // dirprov
            // 
            this.dirprov.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dirprov.Location = new System.Drawing.Point(81, 80);
            this.dirprov.Name = "dirprov";
            this.dirprov.Size = new System.Drawing.Size(281, 20);
            this.dirprov.TabIndex = 7;
            // 
            // rutprov
            // 
            this.rutprov.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rutprov.Location = new System.Drawing.Point(81, 110);
            this.rutprov.Name = "rutprov";
            this.rutprov.Size = new System.Drawing.Size(281, 20);
            this.rutprov.TabIndex = 8;
            // 
            // buscarprov
            // 
            this.buscarprov.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buscarprov.Location = new System.Drawing.Point(81, 140);
            this.buscarprov.Name = "buscarprov";
            this.buscarprov.Size = new System.Drawing.Size(104, 20);
            this.buscarprov.TabIndex = 9;
            this.buscarprov.TextChanged += new System.EventHandler(this.Buscarprov_TextChanged);
            // 
            // tbprov
            // 
            this.tbprov.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbprov.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbprov.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tbprov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbprov.Location = new System.Drawing.Point(26, 178);
            this.tbprov.Name = "tbprov";
            this.tbprov.Size = new System.Drawing.Size(541, 187);
            this.tbprov.TabIndex = 10;
            this.tbprov.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tbprov_CellContentClick_1);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(401, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // mdprov
            // 
            this.mdprov.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mdprov.Location = new System.Drawing.Point(492, 25);
            this.mdprov.Name = "mdprov";
            this.mdprov.Size = new System.Drawing.Size(75, 23);
            this.mdprov.TabIndex = 12;
            this.mdprov.Text = "Modificar";
            this.mdprov.UseVisualStyleBackColor = true;
            this.mdprov.Click += new System.EventHandler(this.Mdprov_Click);
            // 
            // eliprv
            // 
            this.eliprv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.eliprv.Location = new System.Drawing.Point(401, 78);
            this.eliprv.Name = "eliprv";
            this.eliprv.Size = new System.Drawing.Size(75, 23);
            this.eliprv.TabIndex = 13;
            this.eliprv.Text = "Eliminar";
            this.eliprv.UseVisualStyleBackColor = true;
            this.eliprv.Click += new System.EventHandler(this.Eliprv_Click);
            // 
            // limprv
            // 
            this.limprv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.limprv.Location = new System.Drawing.Point(492, 78);
            this.limprv.Name = "limprv";
            this.limprv.Size = new System.Drawing.Size(75, 23);
            this.limprv.TabIndex = 14;
            this.limprv.Text = "Limpiar";
            this.limprv.UseVisualStyleBackColor = true;
            this.limprv.Click += new System.EventHandler(this.Limprv_Click);
            // 
            // errorprv
            // 
            this.errorprv.ContainerControl = this;
            // 
            // newid
            // 
            this.newid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newid.AutoSize = true;
            this.newid.Location = new System.Drawing.Point(204, 22);
            this.newid.Name = "newid";
            this.newid.Size = new System.Drawing.Size(0, 13);
            this.newid.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(582, 377);
            this.Controls.Add(this.newid);
            this.Controls.Add(this.limprv);
            this.Controls.Add(this.eliprv);
            this.Controls.Add(this.mdprov);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbprov);
            this.Controls.Add(this.buscarprov);
            this.Controls.Add(this.rutprov);
            this.Controls.Add(this.dirprov);
            this.Controls.Add(this.nombreprov);
            this.Controls.Add(this.Idprv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbprov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorprv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Idprv;
        private System.Windows.Forms.TextBox nombreprov;
        private System.Windows.Forms.TextBox dirprov;
        private System.Windows.Forms.TextBox rutprov;
        private System.Windows.Forms.TextBox buscarprov;
        private System.Windows.Forms.DataGridView tbprov;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button mdprov;
        private System.Windows.Forms.Button eliprv;
        private System.Windows.Forms.Button limprv;
        private System.Windows.Forms.ErrorProvider errorprv;
        private System.Windows.Forms.Label newid;
    }
}

