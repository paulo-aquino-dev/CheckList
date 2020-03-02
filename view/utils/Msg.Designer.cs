namespace CheckList.view.utils
{
    partial class Msg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Msg));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblMsg = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTitulo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlTop = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnSair = new Bunifu.Framework.UI.BunifuImageButton();
            this.pcbMsg = new System.Windows.Forms.PictureBox();
            this.fadeMsg = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMsg)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.Location = new System.Drawing.Point(127, 106);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(48, 18);
            this.lblMsg.TabIndex = 5;
            this.lblMsg.Text = "Titulo";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(125, 60);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(71, 25);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Titulo";
            // 
            // pnlTop
            // 
            this.pnlTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTop.BackgroundImage")));
            this.pnlTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTop.Controls.Add(this.btnSair);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.GradientBottomLeft = System.Drawing.Color.Black;
            this.pnlTop.GradientBottomRight = System.Drawing.Color.Black;
            this.pnlTop.GradientTopLeft = System.Drawing.Color.Black;
            this.pnlTop.GradientTopRight = System.Drawing.Color.Black;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Quality = 10;
            this.pnlTop.Size = new System.Drawing.Size(677, 30);
            this.pnlTop.TabIndex = 6;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.Image = global::CheckList.Properties.Resources.icone_X;
            this.btnSair.ImageActive = null;
            this.btnSair.Location = new System.Drawing.Point(637, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(28, 28);
            this.btnSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSair.TabIndex = 7;
            this.btnSair.TabStop = false;
            this.btnSair.Zoom = 5;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // pcbMsg
            // 
            this.pcbMsg.Image = global::CheckList.Properties.Resources.icone_ok;
            this.pcbMsg.Location = new System.Drawing.Point(37, 60);
            this.pcbMsg.Name = "pcbMsg";
            this.pcbMsg.Size = new System.Drawing.Size(64, 64);
            this.pcbMsg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbMsg.TabIndex = 2;
            this.pcbMsg.TabStop = false;
            // 
            // fadeMsg
            // 
            this.fadeMsg.Delay = 1;
            // 
            // Msg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 160);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pcbMsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Msg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Msg";
            this.Load += new System.EventHandler(this.Msg_Load);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMsg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pcbMsg;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMsg;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTitulo;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlTop;
        private Bunifu.Framework.UI.BunifuImageButton btnSair;
        private Bunifu.Framework.UI.BunifuFormFadeTransition fadeMsg;
    }
}