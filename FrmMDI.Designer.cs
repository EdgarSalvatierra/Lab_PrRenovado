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
            this.tpFacturacion = new System.Windows.Forms.TabPage();
            this.tpCompras = new System.Windows.Forms.TabPage();
            this.tpreservaciondecitas = new System.Windows.Forms.TabPage();
            this.tpgestiondeexamenes = new System.Windows.Forms.TabPage();
            this.tpconfiguracion = new System.Windows.Forms.TabPage();
            this.materialTabControl1.SuspendLayout();
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
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1154, 531);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tpHome
            // 
            this.tpHome.ImageKey = "house-fill.png";
            this.tpHome.Location = new System.Drawing.Point(4, 25);
            this.tpHome.Name = "tpHome";
            this.tpHome.Padding = new System.Windows.Forms.Padding(3);
            this.tpHome.Size = new System.Drawing.Size(1146, 502);
            this.tpHome.TabIndex = 0;
            this.tpHome.Text = "Home";
            this.tpHome.UseVisualStyleBackColor = true;
            // 
            // tbUsuarios
            // 
            this.tbUsuarios.ImageKey = "people-fill.png";
            this.tbUsuarios.Location = new System.Drawing.Point(4, 25);
            this.tbUsuarios.Name = "tbUsuarios";
            this.tbUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tbUsuarios.Size = new System.Drawing.Size(1146, 502);
            this.tbUsuarios.TabIndex = 1;
            this.tbUsuarios.Text = "Usuarios";
            this.tbUsuarios.UseVisualStyleBackColor = true;
            // 
            // tpFacturacion
            // 
            this.tpFacturacion.ImageKey = "receipt.png";
            this.tpFacturacion.Location = new System.Drawing.Point(4, 25);
            this.tpFacturacion.Name = "tpFacturacion";
            this.tpFacturacion.Padding = new System.Windows.Forms.Padding(3);
            this.tpFacturacion.Size = new System.Drawing.Size(1146, 502);
            this.tpFacturacion.TabIndex = 2;
            this.tpFacturacion.Text = "Facturacion";
            this.tpFacturacion.UseVisualStyleBackColor = true;
            // 
            // tpCompras
            // 
            this.tpCompras.ImageKey = "receipt-cutoff.png";
            this.tpCompras.Location = new System.Drawing.Point(4, 25);
            this.tpCompras.Name = "tpCompras";
            this.tpCompras.Padding = new System.Windows.Forms.Padding(3);
            this.tpCompras.Size = new System.Drawing.Size(1146, 502);
            this.tpCompras.TabIndex = 3;
            this.tpCompras.Text = " Compras";
            this.tpCompras.UseVisualStyleBackColor = true;
            // 
            // tpreservaciondecitas
            // 
            this.tpreservaciondecitas.ImageKey = "journal-medical (1).png";
            this.tpreservaciondecitas.Location = new System.Drawing.Point(4, 25);
            this.tpreservaciondecitas.Name = "tpreservaciondecitas";
            this.tpreservaciondecitas.Padding = new System.Windows.Forms.Padding(3);
            this.tpreservaciondecitas.Size = new System.Drawing.Size(1146, 502);
            this.tpreservaciondecitas.TabIndex = 4;
            this.tpreservaciondecitas.Text = " Citas";
            this.tpreservaciondecitas.UseVisualStyleBackColor = true;
            // 
            // tpgestiondeexamenes
            // 
            this.tpgestiondeexamenes.ImageKey = "file-medical-fill.png";
            this.tpgestiondeexamenes.Location = new System.Drawing.Point(4, 25);
            this.tpgestiondeexamenes.Name = "tpgestiondeexamenes";
            this.tpgestiondeexamenes.Padding = new System.Windows.Forms.Padding(3);
            this.tpgestiondeexamenes.Size = new System.Drawing.Size(1146, 502);
            this.tpgestiondeexamenes.TabIndex = 5;
            this.tpgestiondeexamenes.Text = "Examenes";
            this.tpgestiondeexamenes.UseVisualStyleBackColor = true;
            // 
            // tpconfiguracion
            // 
            this.tpconfiguracion.ImageKey = "gear-fill.png";
            this.tpconfiguracion.Location = new System.Drawing.Point(4, 25);
            this.tpconfiguracion.Name = "tpconfiguracion";
            this.tpconfiguracion.Padding = new System.Windows.Forms.Padding(3);
            this.tpconfiguracion.Size = new System.Drawing.Size(1090, 502);
            this.tpconfiguracion.TabIndex = 6;
            this.tpconfiguracion.Text = "Configuracion";
            this.tpconfiguracion.UseVisualStyleBackColor = true;
            // 
            // FrmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 598);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "FrmMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.FrmMDI_Load);
            this.materialTabControl1.ResumeLayout(false);
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
    }
}