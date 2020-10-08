namespace IACC2020
{
    partial class ManUsers
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LimDatosUser = new System.Windows.Forms.Button();
            this.newID = new System.Windows.Forms.Label();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btEli = new System.Windows.Forms.Button();
            this.BtMod = new System.Windows.Forms.Button();
            this.PassUser = new System.Windows.Forms.TextBox();
            this.NomUser = new System.Windows.Forms.TextBox();
            this.IDuser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.selecVende = new System.Windows.Forms.RadioButton();
            this.selectAdm = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BuscarUser = new System.Windows.Forms.TextBox();
            this.tbuser = new System.Windows.Forms.DataGridView();
            this.errorUser = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.LimDatosUser);
            this.panel1.Controls.Add(this.newID);
            this.panel1.Controls.Add(this.btAgregar);
            this.panel1.Controls.Add(this.btEli);
            this.panel1.Controls.Add(this.BtMod);
            this.panel1.Controls.Add(this.PassUser);
            this.panel1.Controls.Add(this.NomUser);
            this.panel1.Controls.Add(this.IDuser);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.selecVende);
            this.panel1.Controls.Add(this.selectAdm);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 426);
            this.panel1.TabIndex = 0;
            // 
            // LimDatosUser
            // 
            this.LimDatosUser.Location = new System.Drawing.Point(109, 323);
            this.LimDatosUser.Name = "LimDatosUser";
            this.LimDatosUser.Size = new System.Drawing.Size(75, 23);
            this.LimDatosUser.TabIndex = 13;
            this.LimDatosUser.Text = "Limpiar";
            this.LimDatosUser.UseVisualStyleBackColor = true;
            this.LimDatosUser.Click += new System.EventHandler(this.LimDatosUser_Click);
            // 
            // newID
            // 
            this.newID.AutoSize = true;
            this.newID.Location = new System.Drawing.Point(99, 28);
            this.newID.Name = "newID";
            this.newID.Size = new System.Drawing.Size(0, 13);
            this.newID.TabIndex = 12;
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(12, 259);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(75, 23);
            this.btAgregar.TabIndex = 11;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.BtAgregar_Click);
            // 
            // btEli
            // 
            this.btEli.Location = new System.Drawing.Point(12, 323);
            this.btEli.Name = "btEli";
            this.btEli.Size = new System.Drawing.Size(75, 23);
            this.btEli.TabIndex = 10;
            this.btEli.Text = "Eliminar";
            this.btEli.UseVisualStyleBackColor = true;
            this.btEli.Click += new System.EventHandler(this.BtEli_Click);
            // 
            // BtMod
            // 
            this.BtMod.Location = new System.Drawing.Point(109, 259);
            this.BtMod.Name = "BtMod";
            this.BtMod.Size = new System.Drawing.Size(75, 23);
            this.BtMod.TabIndex = 9;
            this.BtMod.Text = "Modificar";
            this.BtMod.UseVisualStyleBackColor = true;
            this.BtMod.Click += new System.EventHandler(this.BtMod_Click);
            // 
            // PassUser
            // 
            this.PassUser.Location = new System.Drawing.Point(109, 187);
            this.PassUser.Name = "PassUser";
            this.PassUser.PasswordChar = '*';
            this.PassUser.Size = new System.Drawing.Size(100, 20);
            this.PassUser.TabIndex = 8;
            // 
            // NomUser
            // 
            this.NomUser.Location = new System.Drawing.Point(109, 135);
            this.NomUser.Name = "NomUser";
            this.NomUser.Size = new System.Drawing.Size(100, 20);
            this.NomUser.TabIndex = 7;
            // 
            // IDuser
            // 
            this.IDuser.Location = new System.Drawing.Point(30, 28);
            this.IDuser.Name = "IDuser";
            this.IDuser.Size = new System.Drawing.Size(62, 20);
            this.IDuser.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Contraseña";
            // 
            // selecVende
            // 
            this.selecVende.AutoSize = true;
            this.selecVende.Location = new System.Drawing.Point(143, 78);
            this.selecVende.Name = "selecVende";
            this.selecVende.Size = new System.Drawing.Size(71, 17);
            this.selecVende.TabIndex = 4;
            this.selecVende.TabStop = true;
            this.selecVende.Text = "Vendedor";
            this.selecVende.UseVisualStyleBackColor = true;
            // 
            // selectAdm
            // 
            this.selectAdm.AutoSize = true;
            this.selectAdm.Location = new System.Drawing.Point(9, 78);
            this.selectAdm.Name = "selectAdm";
            this.selectAdm.Size = new System.Drawing.Size(88, 17);
            this.selectAdm.TabIndex = 3;
            this.selectAdm.TabStop = true;
            this.selectAdm.Text = "Administrador";
            this.selectAdm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.selectAdm.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos de Usuario";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Buscar";
            // 
            // BuscarUser
            // 
            this.BuscarUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BuscarUser.Location = new System.Drawing.Point(254, 43);
            this.BuscarUser.Name = "BuscarUser";
            this.BuscarUser.Size = new System.Drawing.Size(100, 20);
            this.BuscarUser.TabIndex = 2;
            this.BuscarUser.TextChanged += new System.EventHandler(this.BuscarUser_TextChanged);
            // 
            // tbuser
            // 
            this.tbuser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbuser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbuser.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tbuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbuser.Location = new System.Drawing.Point(254, 79);
            this.tbuser.Name = "tbuser";
            this.tbuser.Size = new System.Drawing.Size(421, 359);
            this.tbuser.TabIndex = 3;
            this.tbuser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tbuser_CellContentClick);
            // 
            // errorUser
            // 
            this.errorUser.ContainerControl = this;
            // 
            // ManUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(687, 450);
            this.Controls.Add(this.tbuser);
            this.Controls.Add(this.BuscarUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Name = "ManUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantención de usuarios";
            this.Load += new System.EventHandler(this.ManUsers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btEli;
        private System.Windows.Forms.Button BtMod;
        private System.Windows.Forms.TextBox PassUser;
        private System.Windows.Forms.TextBox NomUser;
        private System.Windows.Forms.TextBox IDuser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton selecVende;
        private System.Windows.Forms.RadioButton selectAdm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BuscarUser;
        private System.Windows.Forms.DataGridView tbuser;
        private System.Windows.Forms.Label newID;
        private System.Windows.Forms.ErrorProvider errorUser;
        private System.Windows.Forms.Button LimDatosUser;
    }
}