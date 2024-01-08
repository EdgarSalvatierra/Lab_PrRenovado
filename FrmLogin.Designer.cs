namespace Lab_Pr
{
    partial class FrmLogin
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
            this.ICNUser = new FontAwesome.Sharp.IconPictureBox();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtUser = new MaterialSkin.Controls.MaterialTextBox2();
            this.TxtContraseña = new MaterialSkin.Controls.MaterialTextBox2();
            ((System.ComponentModel.ISupportInitialize)(this.ICNUser)).BeginInit();
            this.SuspendLayout();
            // 
            // ICNUser
            // 
            this.ICNUser.BackColor = System.Drawing.SystemColors.Control;
            this.ICNUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ICNUser.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.ICNUser.IconColor = System.Drawing.SystemColors.ControlText;
            this.ICNUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ICNUser.IconSize = 125;
            this.ICNUser.Location = new System.Drawing.Point(183, 104);
            this.ICNUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ICNUser.Name = "ICNUser";
            this.ICNUser.Size = new System.Drawing.Size(125, 141);
            this.ICNUser.TabIndex = 9;
            this.ICNUser.TabStop = false;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(64)))), ((int)(((byte)(99)))));
            this.BtnIngresar.FlatAppearance.BorderSize = 0;
            this.BtnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnIngresar.Location = new System.Drawing.Point(94, 572);
            this.BtnIngresar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(346, 72);
            this.BtnIngresar.TabIndex = 14;
            this.BtnIngresar.Text = "Ingresar al Sistema";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(37, 446);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(82, 19);
            this.materialLabel3.TabIndex = 13;
            this.materialLabel3.Text = "Contraseña";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(37, 318);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(55, 19);
            this.materialLabel2.TabIndex = 12;
            this.materialLabel2.Text = "Usuario";
            // 
            // TxtUser
            // 
            this.TxtUser.AnimateReadOnly = false;
            this.TxtUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtUser.Depth = 0;
            this.TxtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtUser.HideSelection = true;
            this.TxtUser.LeadingIcon = null;
            this.TxtUser.Location = new System.Drawing.Point(141, 298);
            this.TxtUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtUser.MaxLength = 32767;
            this.TxtUser.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.PasswordChar = '\0';
            this.TxtUser.PrefixSuffixText = null;
            this.TxtUser.ReadOnly = false;
            this.TxtUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtUser.SelectedText = "";
            this.TxtUser.SelectionLength = 0;
            this.TxtUser.SelectionStart = 0;
            this.TxtUser.ShortcutsEnabled = true;
            this.TxtUser.Size = new System.Drawing.Size(286, 48);
            this.TxtUser.TabIndex = 11;
            this.TxtUser.TabStop = false;
            this.TxtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtUser.TrailingIcon = null;
            this.TxtUser.UseSystemPasswordChar = false;
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.AnimateReadOnly = false;
            this.TxtContraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtContraseña.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtContraseña.Depth = 0;
            this.TxtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtContraseña.HideSelection = true;
            this.TxtContraseña.LeadingIcon = null;
            this.TxtContraseña.Location = new System.Drawing.Point(141, 429);
            this.TxtContraseña.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtContraseña.MaxLength = 32767;
            this.TxtContraseña.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.PasswordChar = '\0';
            this.TxtContraseña.PrefixSuffixText = null;
            this.TxtContraseña.ReadOnly = false;
            this.TxtContraseña.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtContraseña.SelectedText = "";
            this.TxtContraseña.SelectionLength = 0;
            this.TxtContraseña.SelectionStart = 0;
            this.TxtContraseña.ShortcutsEnabled = true;
            this.TxtContraseña.Size = new System.Drawing.Size(286, 48);
            this.TxtContraseña.TabIndex = 10;
            this.TxtContraseña.TabStop = false;
            this.TxtContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtContraseña.TrailingIcon = null;
            this.TxtContraseña.UseSystemPasswordChar = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 682);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.ICNUser);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmLogin";
            this.Padding = new System.Windows.Forms.Padding(4, 99, 4, 5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                            Inicio Sesion";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ICNUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox ICNUser;
        private System.Windows.Forms.Button BtnIngresar;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 TxtUser;
        private MaterialSkin.Controls.MaterialTextBox2 TxtContraseña;
    }
}