namespace IACC2020
{
    partial class Nuevo_Lim
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
            this.GridNewLIm = new System.Windows.Forms.DataGridView();
            this.GuardarLimNew = new System.Windows.Forms.Button();
            this.IDProLim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LimNuevo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IDLim = new System.Windows.Forms.TextBox();
            this.NewIDLim = new System.Windows.Forms.Label();
            this.errorNewLim = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridNewLIm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNewLim)).BeginInit();
            this.SuspendLayout();
            // 
            // GridNewLIm
            // 
            this.GridNewLIm.AllowUserToAddRows = false;
            this.GridNewLIm.AllowUserToDeleteRows = false;
            this.GridNewLIm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridNewLIm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridNewLIm.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridNewLIm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridNewLIm.Location = new System.Drawing.Point(13, 13);
            this.GridNewLIm.Name = "GridNewLIm";
            this.GridNewLIm.ReadOnly = true;
            this.GridNewLIm.Size = new System.Drawing.Size(646, 377);
            this.GridNewLIm.TabIndex = 0;
            this.GridNewLIm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridNewLIm_CellContentClick);
            // 
            // GuardarLimNew
            // 
            this.GuardarLimNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GuardarLimNew.Location = new System.Drawing.Point(696, 143);
            this.GuardarLimNew.Name = "GuardarLimNew";
            this.GuardarLimNew.Size = new System.Drawing.Size(75, 23);
            this.GuardarLimNew.TabIndex = 1;
            this.GuardarLimNew.Text = "Guardar";
            this.GuardarLimNew.UseVisualStyleBackColor = true;
            this.GuardarLimNew.Click += new System.EventHandler(this.GuardarLimNew_Click);
            // 
            // IDProLim
            // 
            this.IDProLim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IDProLim.Enabled = false;
            this.IDProLim.Location = new System.Drawing.Point(682, 71);
            this.IDProLim.Name = "IDProLim";
            this.IDProLim.Size = new System.Drawing.Size(100, 20);
            this.IDProLim.TabIndex = 2;
            this.IDProLim.TextChanged += new System.EventHandler(this.IDProLim_TextChanged);
            this.IDProLim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDProLim_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(679, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID Producto";
            // 
            // LimNuevo
            // 
            this.LimNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LimNuevo.Location = new System.Drawing.Point(682, 111);
            this.LimNuevo.Name = "LimNuevo";
            this.LimNuevo.Size = new System.Drawing.Size(100, 20);
            this.LimNuevo.TabIndex = 4;
            this.LimNuevo.TextChanged += new System.EventHandler(this.LimNuevo_TextChanged);
            this.LimNuevo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LimNuevo_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(679, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Límite";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(680, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID Limite";
            // 
            // IDLim
            // 
            this.IDLim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IDLim.Enabled = false;
            this.IDLim.Location = new System.Drawing.Point(682, 29);
            this.IDLim.Name = "IDLim";
            this.IDLim.Size = new System.Drawing.Size(100, 20);
            this.IDLim.TabIndex = 7;
            // 
            // NewIDLim
            // 
            this.NewIDLim.AutoSize = true;
            this.NewIDLim.Location = new System.Drawing.Point(693, 359);
            this.NewIDLim.Name = "NewIDLim";
            this.NewIDLim.Size = new System.Drawing.Size(56, 13);
            this.NewIDLim.TabIndex = 8;
            this.NewIDLim.Text = "NewIDLim";
            this.NewIDLim.Visible = false;
            // 
            // errorNewLim
            // 
            this.errorNewLim.ContainerControl = this;
            // 
            // Nuevo_Lim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NewIDLim);
            this.Controls.Add(this.IDLim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LimNuevo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDProLim);
            this.Controls.Add(this.GuardarLimNew);
            this.Controls.Add(this.GridNewLIm);
            this.Name = "Nuevo_Lim";
            this.Text = "Nuevo Límite";
            this.Load += new System.EventHandler(this.Nuevo_Lim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridNewLIm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNewLim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridNewLIm;
        private System.Windows.Forms.Button GuardarLimNew;
        private System.Windows.Forms.TextBox IDProLim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LimNuevo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IDLim;
        private System.Windows.Forms.Label NewIDLim;
        private System.Windows.Forms.ErrorProvider errorNewLim;
    }
}