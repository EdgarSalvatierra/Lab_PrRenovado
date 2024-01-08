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
            this.tpFacturacion = new System.Windows.Forms.TabPage();
            this.tpCompras = new System.Windows.Forms.TabPage();
            this.tpreservaciondecitas = new System.Windows.Forms.TabPage();
            this.tpgestiondeexamenes = new System.Windows.Forms.TabPage();
            this.tpconfiguracion = new System.Windows.Forms.TabPage();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialTabControl1.SuspendLayout();
            this.tbUsuarios.SuspendLayout();
            this.cardusuarios.SuspendLayout();
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
            this.materialTabControl1.Location = new System.Drawing.Point(0, 98);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(967, 571);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tpHome
            // 
            this.tpHome.ImageKey = "house-fill.png";
            this.tpHome.Location = new System.Drawing.Point(4, 29);
            this.tpHome.Name = "tpHome";
            this.tpHome.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpHome.Size = new System.Drawing.Size(959, 538);
            this.tpHome.TabIndex = 0;
            this.tpHome.Text = "Home";
            this.tpHome.UseVisualStyleBackColor = true;
            // 
            // tbUsuarios
            // 
            this.tbUsuarios.Controls.Add(this.cardusuarios);
            this.tbUsuarios.ImageKey = "people-fill.png";
            this.tbUsuarios.Location = new System.Drawing.Point(4, 29);
            this.tbUsuarios.Name = "tbUsuarios";
            this.tbUsuarios.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tbUsuarios.Size = new System.Drawing.Size(959, 538);
            this.tbUsuarios.TabIndex = 1;
            this.tbUsuarios.Text = "Usuarios";
            this.tbUsuarios.UseVisualStyleBackColor = true;
            // 
            // cardusuarios
            // 
            this.cardusuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardusuarios.Controls.Add(this.materialButton1);
            this.cardusuarios.Depth = 0;
            this.cardusuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardusuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardusuarios.Location = new System.Drawing.Point(3, 3);
            this.cardusuarios.Margin = new System.Windows.Forms.Padding(15, 17, 15, 17);
            this.cardusuarios.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardusuarios.Name = "cardusuarios";
            this.cardusuarios.Padding = new System.Windows.Forms.Padding(15, 17, 15, 17);
            this.cardusuarios.Size = new System.Drawing.Size(953, 532);
            this.cardusuarios.TabIndex = 0;
            // 
            // tpFacturacion
            // 
            this.tpFacturacion.ImageKey = "receipt.png";
            this.tpFacturacion.Location = new System.Drawing.Point(4, 29);
            this.tpFacturacion.Name = "tpFacturacion";
            this.tpFacturacion.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpFacturacion.Size = new System.Drawing.Size(959, 538);
            this.tpFacturacion.TabIndex = 2;
            this.tpFacturacion.Text = "Facturacion";
            this.tpFacturacion.UseVisualStyleBackColor = true;
            // 
            // tpCompras
            // 
            this.tpCompras.ImageKey = "receipt-cutoff.png";
            this.tpCompras.Location = new System.Drawing.Point(4, 29);
            this.tpCompras.Name = "tpCompras";
            this.tpCompras.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpCompras.Size = new System.Drawing.Size(959, 538);
            this.tpCompras.TabIndex = 3;
            this.tpCompras.Text = " Compras";
            this.tpCompras.UseVisualStyleBackColor = true;
            // 
            // tpreservaciondecitas
            // 
            this.tpreservaciondecitas.ImageKey = "journal-medical (1).png";
            this.tpreservaciondecitas.Location = new System.Drawing.Point(4, 29);
            this.tpreservaciondecitas.Name = "tpreservaciondecitas";
            this.tpreservaciondecitas.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpreservaciondecitas.Size = new System.Drawing.Size(959, 538);
            this.tpreservaciondecitas.TabIndex = 4;
            this.tpreservaciondecitas.Text = " Citas";
            this.tpreservaciondecitas.UseVisualStyleBackColor = true;
            // 
            // tpgestiondeexamenes
            // 
            this.tpgestiondeexamenes.ImageKey = "file-medical-fill.png";
            this.tpgestiondeexamenes.Location = new System.Drawing.Point(4, 29);
            this.tpgestiondeexamenes.Name = "tpgestiondeexamenes";
            this.tpgestiondeexamenes.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpgestiondeexamenes.Size = new System.Drawing.Size(959, 538);
            this.tpgestiondeexamenes.TabIndex = 5;
            this.tpgestiondeexamenes.Text = "Examenes";
            this.tpgestiondeexamenes.UseVisualStyleBackColor = true;
            // 
            // tpconfiguracion
            // 
            this.tpconfiguracion.ImageKey = "gear-fill.png";
            this.tpconfiguracion.Location = new System.Drawing.Point(4, 29);
            this.tpconfiguracion.Name = "tpconfiguracion";
            this.tpconfiguracion.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpconfiguracion.Size = new System.Drawing.Size(959, 538);
            this.tpconfiguracion.TabIndex = 6;
            this.tpconfiguracion.Text = "Configuracion";
            this.tpconfiguracion.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(191, 175);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(158, 36);
            this.materialButton1.TabIndex = 0;
            this.materialButton1.Text = "materialButton1";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // FrmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 672);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "FrmMDI";
            this.Padding = new System.Windows.Forms.Padding(0, 98, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.FrmMDI_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tbUsuarios.ResumeLayout(false);
            this.cardusuarios.ResumeLayout(false);
            this.cardusuarios.PerformLayout();
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
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}