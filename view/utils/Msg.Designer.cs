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
            this.elipseForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblMsg = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTitulo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlTop = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pcbMsg = new System.Windows.Forms.PictureBox();
            this.fadeMsg = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.btnOk = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMsg)).BeginInit();
            this.SuspendLayout();
            // 
            // elipseForm
            // 
            this.elipseForm.ElipseRadius = 15;
            this.elipseForm.TargetControl = this;
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
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.GradientBottomLeft = System.Drawing.Color.Black;
            this.pnlTop.GradientBottomRight = System.Drawing.Color.Black;
            this.pnlTop.GradientTopLeft = System.Drawing.Color.Black;
            this.pnlTop.GradientTopRight = System.Drawing.Color.Black;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Quality = 10;
            this.pnlTop.Size = new System.Drawing.Size(541, 30);
            this.pnlTop.TabIndex = 6;
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
            // btnOk
            // 
            this.btnOk.Activecolor = System.Drawing.Color.Black;
            this.btnOk.BackColor = System.Drawing.Color.Green;
            this.btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOk.BorderRadius = 0;
            this.btnOk.ButtonText = "OK";
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.DisabledColor = System.Drawing.Color.Gray;
            this.btnOk.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOk.Iconimage = null;
            this.btnOk.Iconimage_right = null;
            this.btnOk.Iconimage_right_Selected = null;
            this.btnOk.Iconimage_Selected = null;
            this.btnOk.IconMarginLeft = 0;
            this.btnOk.IconMarginRight = 0;
            this.btnOk.IconRightVisible = true;
            this.btnOk.IconRightZoom = 0D;
            this.btnOk.IconVisible = true;
            this.btnOk.IconZoom = 90D;
            this.btnOk.IsTab = false;
            this.btnOk.Location = new System.Drawing.Point(156, 146);
            this.btnOk.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Normalcolor = System.Drawing.Color.Green;
            this.btnOk.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnOk.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOk.selected = false;
            this.btnOk.Size = new System.Drawing.Size(247, 52);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "OK";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOk.Textcolor = System.Drawing.Color.White;
            this.btnOk.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // Msg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 212);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pcbMsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Msg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Msg";
            this.Load += new System.EventHandler(this.Msg_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Msg_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pcbMsg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse elipseForm;
        private System.Windows.Forms.PictureBox pcbMsg;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMsg;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTitulo;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlTop;
        private Bunifu.Framework.UI.BunifuFormFadeTransition fadeMsg;
        private Bunifu.Framework.UI.BunifuFlatButton btnOk;
    }
}