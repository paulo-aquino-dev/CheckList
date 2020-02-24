namespace CheckList.view
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.winoverDataSet = new CheckList.winoverDataSet();
            this.funcionariosTableAdapter = new CheckList.winoverDataSetTableAdapters.funcionariosTableAdapter();
            this.pnlFill = new System.Windows.Forms.Panel();
            this.btnVerSenha = new Bunifu.Framework.UI.BunifuImageButton();
            this.pcbUser = new System.Windows.Forms.PictureBox();
            this.btnLogar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtSenha = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtLogin = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pnlLeft = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.lblFooter = new System.Windows.Forms.Label();
            this.pcbChecklist = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winoverDataSet)).BeginInit();
            this.pnlFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVerSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser)).BeginInit();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbChecklist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // elipse
            // 
            this.elipse.ElipseRadius = 20;
            this.elipse.TargetControl = this;
            // 
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataMember = "funcionarios";
            this.funcionariosBindingSource.DataSource = this.winoverDataSet;
            // 
            // winoverDataSet
            // 
            this.winoverDataSet.DataSetName = "winoverDataSet";
            this.winoverDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionariosTableAdapter
            // 
            this.funcionariosTableAdapter.ClearBeforeFill = true;
            // 
            // pnlFill
            // 
            this.pnlFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(63)))));
            this.pnlFill.Controls.Add(this.btnVerSenha);
            this.pnlFill.Controls.Add(this.pcbUser);
            this.pnlFill.Controls.Add(this.btnLogar);
            this.pnlFill.Controls.Add(this.txtSenha);
            this.pnlFill.Controls.Add(this.txtLogin);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(350, 0);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(412, 448);
            this.pnlFill.TabIndex = 1;
            // 
            // btnVerSenha
            // 
            this.btnVerSenha.BackColor = System.Drawing.Color.Transparent;
            this.btnVerSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVerSenha.Image = global::CheckList.Properties.Resources.icone_unhide;
            this.btnVerSenha.ImageActive = null;
            this.btnVerSenha.Location = new System.Drawing.Point(349, 313);
            this.btnVerSenha.Name = "btnVerSenha";
            this.btnVerSenha.Size = new System.Drawing.Size(32, 32);
            this.btnVerSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnVerSenha.TabIndex = 6;
            this.btnVerSenha.TabStop = false;
            this.btnVerSenha.Zoom = 0;
            this.btnVerSenha.MouseHover += new System.EventHandler(this.BtnVerSenha_MouseHover);
            // 
            // pcbUser
            // 
            this.pcbUser.BackColor = System.Drawing.Color.Transparent;
            this.pcbUser.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pcbUser.Image = global::CheckList.Properties.Resources.icone_user;
            this.pcbUser.Location = new System.Drawing.Point(149, 69);
            this.pcbUser.Name = "pcbUser";
            this.pcbUser.Size = new System.Drawing.Size(128, 128);
            this.pcbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbUser.TabIndex = 3;
            this.pcbUser.TabStop = false;
            // 
            // btnLogar
            // 
            this.btnLogar.ActiveBorderThickness = 1;
            this.btnLogar.ActiveCornerRadius = 30;
            this.btnLogar.ActiveFillColor = System.Drawing.Color.White;
            this.btnLogar.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(174)))), ((int)(((byte)(180)))));
            this.btnLogar.ActiveLineColor = System.Drawing.Color.White;
            this.btnLogar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(63)))));
            this.btnLogar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogar.BackgroundImage")));
            this.btnLogar.ButtonText = "Logar";
            this.btnLogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogar.ForeColor = System.Drawing.Color.White;
            this.btnLogar.IdleBorderThickness = 1;
            this.btnLogar.IdleCornerRadius = 30;
            this.btnLogar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(174)))), ((int)(((byte)(180)))));
            this.btnLogar.IdleForecolor = System.Drawing.Color.White;
            this.btnLogar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(174)))), ((int)(((byte)(180)))));
            this.btnLogar.Location = new System.Drawing.Point(122, 377);
            this.btnLogar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(172, 44);
            this.btnLogar.TabIndex = 5;
            this.btnLogar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSenha
            // 
            this.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSenha.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.White;
            this.txtSenha.HintForeColor = System.Drawing.Color.White;
            this.txtSenha.HintText = "Senha";
            this.txtSenha.isPassword = false;
            this.txtSenha.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(174)))), ((int)(((byte)(180)))));
            this.txtSenha.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSenha.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.txtSenha.LineThickness = 3;
            this.txtSenha.Location = new System.Drawing.Point(38, 313);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(343, 35);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSenha.Enter += new System.EventHandler(this.TxtSenha_Enter);
            // 
            // txtLogin
            // 
            this.txtLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLogin.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.ForeColor = System.Drawing.Color.White;
            this.txtLogin.HintForeColor = System.Drawing.Color.White;
            this.txtLogin.HintText = "Login";
            this.txtLogin.isPassword = false;
            this.txtLogin.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(174)))), ((int)(((byte)(180)))));
            this.txtLogin.LineIdleColor = System.Drawing.Color.Gray;
            this.txtLogin.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.txtLogin.LineThickness = 3;
            this.txtLogin.Location = new System.Drawing.Point(38, 228);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(343, 35);
            this.txtLogin.TabIndex = 2;
            this.txtLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLeft.BackgroundImage")));
            this.pnlLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLeft.Controls.Add(this.pcbLogo);
            this.pnlLeft.Controls.Add(this.lblFooter);
            this.pnlLeft.Controls.Add(this.pcbChecklist);
            this.pnlLeft.Controls.Add(this.lblTitulo);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.pnlLeft.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(63)))));
            this.pnlLeft.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.pnlLeft.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Quality = 10;
            this.pnlLeft.Size = new System.Drawing.Size(350, 448);
            this.pnlLeft.TabIndex = 0;
            this.pnlLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlLeft_Paint);
            // 
            // pcbLogo
            // 
            this.pcbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pcbLogo.Image = global::CheckList.Properties.Resources.icone_winover;
            this.pcbLogo.Location = new System.Drawing.Point(4, 4);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(33, 17);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbLogo.TabIndex = 3;
            this.pcbLogo.TabStop = false;
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.BackColor = System.Drawing.Color.Transparent;
            this.lblFooter.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.ForeColor = System.Drawing.Color.White;
            this.lblFooter.Location = new System.Drawing.Point(57, 403);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(241, 18);
            this.lblFooter.TabIndex = 2;
            this.lblFooter.Text = "Desenvolvido por Paulo Aquino.";
            // 
            // pcbChecklist
            // 
            this.pcbChecklist.BackColor = System.Drawing.Color.Transparent;
            this.pcbChecklist.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pcbChecklist.Image = global::CheckList.Properties.Resources.icone_checklist;
            this.pcbChecklist.Location = new System.Drawing.Point(74, 129);
            this.pcbChecklist.Name = "pcbChecklist";
            this.pcbChecklist.Size = new System.Drawing.Size(192, 192);
            this.pcbChecklist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbChecklist.TabIndex = 1;
            this.pcbChecklist.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 69);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(318, 35);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Sistema de Checklist";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 448);
            this.Controls.Add(this.pnlFill);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winoverDataSet)).EndInit();
            this.pnlFill.ResumeLayout(false);
            this.pnlFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVerSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbChecklist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse elipse;
        private System.Windows.Forms.BindingSource bindingSource1;
        private winoverDataSet winoverDataSet;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private winoverDataSetTableAdapters.funcionariosTableAdapter funcionariosTableAdapter;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlLeft;
        private System.Windows.Forms.Panel pnlFill;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTitulo;
        private System.Windows.Forms.PictureBox pcbChecklist;
        private System.Windows.Forms.Label lblFooter;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtLogin;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSenha;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLogar;
        private System.Windows.Forms.PictureBox pcbUser;
        private Bunifu.Framework.UI.BunifuImageButton btnVerSenha;
        private System.Windows.Forms.PictureBox pcbLogo;
    }
}