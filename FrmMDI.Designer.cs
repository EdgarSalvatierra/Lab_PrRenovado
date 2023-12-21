namespace Lab_Pr
{
    partial class FrmMDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMDI));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tpHome = new System.Windows.Forms.TabPage();
            this.tbUsuarios = new System.Windows.Forms.TabPage();
            this.cardusuarios = new MaterialSkin.Controls.MaterialCard();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tpFacturacion = new System.Windows.Forms.TabPage();
            this.tpCompras = new System.Windows.Forms.TabPage();
            this.tpreservaciondecitas = new System.Windows.Forms.TabPage();
            this.tpgestiondeexamenes = new System.Windows.Forms.TabPage();
            this.tpconfiguracion = new System.Windows.Forms.TabPage();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.materialTabControl1.SuspendLayout();
            this.tbUsuarios.SuspendLayout();
            this.cardusuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.White;
            this.imageList1.Images.SetKeyName(0, "house-fill.png");
            this.imageList1.Images.SetKeyName(1, "gear-fill.png");
            this.imageList1.Images.SetKeyName(2, "people-fill.png");
            this.imageList1.Images.SetKeyName(3, "file-medical-fill.png");
            this.imageList1.Images.SetKeyName(4, "journal-medical (1).png");
            this.imageList1.Images.SetKeyName(5, "receipt.png");
            this.imageList1.Images.SetKeyName(6, "receipt-cutoff.png");
            this.imageList1.Images.SetKeyName(7, "search.png");
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tpHome);
            this.materialTabControl1.Controls.Add(this.tbUsuarios);
            this.materialTabControl1.Controls.Add(this.tpFacturacion);
            this.materialTabControl1.Controls.Add(this.tpCompras);
            this.materialTabControl1.Controls.Add(this.tpreservaciondecitas);
            this.materialTabControl1.Controls.Add(this.tpgestiondeexamenes);
            this.materialTabControl1.Controls.Add(this.tpconfiguracion);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(2, 52);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(643, 383);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tpHome
            // 
            this.tpHome.ImageKey = "house-fill.png";
            this.tpHome.Location = new System.Drawing.Point(4, 23);
            this.tpHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpHome.Name = "tpHome";
            this.tpHome.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpHome.Size = new System.Drawing.Size(861, 356);
            this.tpHome.TabIndex = 0;
            this.tpHome.Text = "Home";
            this.tpHome.UseVisualStyleBackColor = true;
            // 
            // tbUsuarios
            // 
            this.tbUsuarios.Controls.Add(this.cardusuarios);
            this.tbUsuarios.ImageKey = "people-fill.png";
            this.tbUsuarios.Location = new System.Drawing.Point(4, 23);
            this.tbUsuarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbUsuarios.Name = "tbUsuarios";
            this.tbUsuarios.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbUsuarios.Size = new System.Drawing.Size(635, 356);
            this.tbUsuarios.TabIndex = 1;
            this.tbUsuarios.Text = "Usuarios";
            this.tbUsuarios.UseVisualStyleBackColor = true;
            // 
            // cardusuarios
            // 
            this.cardusuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardusuarios.Controls.Add(this.BtnBuscar);
            this.cardusuarios.Controls.Add(this.textBox1);
            this.cardusuarios.Controls.Add(this.iconPictureBox1);
            this.cardusuarios.Controls.Add(this.materialLabel1);
            this.cardusuarios.Depth = 0;
            this.cardusuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardusuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardusuarios.Location = new System.Drawing.Point(2, 2);
            this.cardusuarios.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.cardusuarios.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardusuarios.Name = "cardusuarios";
            this.cardusuarios.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.cardusuarios.Size = new System.Drawing.Size(631, 352);
            this.cardusuarios.TabIndex = 0;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.White;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnBuscar.IconColor = System.Drawing.Color.White;
            this.BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBuscar.ImageKey = "search.png";
            this.BtnBuscar.ImageList = this.imageList1;
            this.BtnBuscar.Location = new System.Drawing.Point(551, 28);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(37, 32);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(50, 36);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(123, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Lista de Usuarios";
            // 
            // tpFacturacion
            // 
            this.tpFacturacion.ImageKey = "receipt.png";
            this.tpFacturacion.Location = new System.Drawing.Point(4, 23);
            this.tpFacturacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpFacturacion.Name = "tpFacturacion";
            this.tpFacturacion.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpFacturacion.Size = new System.Drawing.Size(810, 356);
            this.tpFacturacion.TabIndex = 2;
            this.tpFacturacion.Text = "Facturacion";
            this.tpFacturacion.UseVisualStyleBackColor = true;
            // 
            // tpCompras
            // 
            this.tpCompras.ImageKey = "receipt-cutoff.png";
            this.tpCompras.Location = new System.Drawing.Point(4, 23);
            this.tpCompras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpCompras.Name = "tpCompras";
            this.tpCompras.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpCompras.Size = new System.Drawing.Size(810, 356);
            this.tpCompras.TabIndex = 3;
            this.tpCompras.Text = " Compras";
            this.tpCompras.UseVisualStyleBackColor = true;
            // 
            // tpreservaciondecitas
            // 
            this.tpreservaciondecitas.ImageKey = "journal-medical (1).png";
            this.tpreservaciondecitas.Location = new System.Drawing.Point(4, 23);
            this.tpreservaciondecitas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpreservaciondecitas.Name = "tpreservaciondecitas";
            this.tpreservaciondecitas.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpreservaciondecitas.Size = new System.Drawing.Size(810, 356);
            this.tpreservaciondecitas.TabIndex = 4;
            this.tpreservaciondecitas.Text = " Citas";
            this.tpreservaciondecitas.UseVisualStyleBackColor = true;
            // 
            // tpgestiondeexamenes
            // 
            this.tpgestiondeexamenes.ImageKey = "file-medical-fill.png";
            this.tpgestiondeexamenes.Location = new System.Drawing.Point(4, 23);
            this.tpgestiondeexamenes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpgestiondeexamenes.Name = "tpgestiondeexamenes";
            this.tpgestiondeexamenes.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpgestiondeexamenes.Size = new System.Drawing.Size(810, 356);
            this.tpgestiondeexamenes.TabIndex = 5;
            this.tpgestiondeexamenes.Text = "Examenes";
            this.tpgestiondeexamenes.UseVisualStyleBackColor = true;
            // 
            // tpconfiguracion
            // 
            this.tpconfiguracion.ImageKey = "gear-fill.png";
            this.tpconfiguracion.Location = new System.Drawing.Point(4, 23);
            this.tpconfiguracion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpconfiguracion.Name = "tpconfiguracion";
            this.tpconfiguracion.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpconfiguracion.Size = new System.Drawing.Size(810, 356);
            this.tpconfiguracion.TabIndex = 6;
            this.tpconfiguracion.Text = "Configuracion";
            this.tpconfiguracion.UseVisualStyleBackColor = true;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(13, 24);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 3;
            this.iconPictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(424, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 26);
            this.textBox1.TabIndex = 4;
            // 
            // FrmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 437);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmMDI";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.FrmMDI_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tbUsuarios.ResumeLayout(false);
            this.cardusuarios.ResumeLayout(false);
            this.cardusuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tpHome;
        private System.Windows.Forms.TabPage tbUsuarios;
        private System.Windows.Forms.TabPage tpFacturacion;
        private System.Windows.Forms.TabPage tpCompras;
        private System.Windows.Forms.TabPage tpreservaciondecitas;
        private System.Windows.Forms.TabPage tpgestiondeexamenes;
        private System.Windows.Forms.TabPage tpconfiguracion;
        private MaterialSkin.Controls.MaterialCard cardusuarios;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}