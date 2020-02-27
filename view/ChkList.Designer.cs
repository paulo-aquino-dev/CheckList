namespace CheckList.view
{
    partial class ChkList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChkList));
            this.elipseForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnHead = new Bunifu.Framework.UI.BunifuImageButton();
            this.elipseBtnHead = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnMouse = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnTeclado = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMonitor = new Bunifu.Framework.UI.BunifuImageButton();
            this.elipseBtnMouse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elipseBtnTeclado = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elipseBtnMonitor = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlTop = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bdcTop = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pnlFooter = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblStatusHead = new System.Windows.Forms.Label();
            this.lblStatusMouse = new System.Windows.Forms.Label();
            this.lblStatusTeclado = new System.Windows.Forms.Label();
            this.lblStatusMonitor = new System.Windows.Forms.Label();
            this.lblHead = new System.Windows.Forms.Label();
            this.ttpBtn = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            ((System.ComponentModel.ISupportInitialize)(this.btnHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTeclado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMonitor)).BeginInit();
            this.SuspendLayout();
            // 
            // elipseForm
            // 
            this.elipseForm.ElipseRadius = 5;
            this.elipseForm.TargetControl = this;
            // 
            // btnHead
            // 
            this.btnHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(176)))), ((int)(((byte)(182)))));
            this.btnHead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHead.Image = ((System.Drawing.Image)(resources.GetObject("btnHead.Image")));
            this.btnHead.ImageActive = null;
            this.btnHead.Location = new System.Drawing.Point(33, 51);
            this.btnHead.Name = "btnHead";
            this.btnHead.Size = new System.Drawing.Size(143, 143);
            this.btnHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnHead.TabIndex = 0;
            this.btnHead.TabStop = false;
            this.ttpBtn.SetToolTip(this.btnHead, "Clique para alterar o status!");
            this.btnHead.Zoom = 5;
            this.btnHead.Click += new System.EventHandler(this.BtnHead_Click);
            // 
            // elipseBtnHead
            // 
            this.elipseBtnHead.ElipseRadius = 20;
            this.elipseBtnHead.TargetControl = this.btnHead;
            // 
            // btnMouse
            // 
            this.btnMouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(176)))), ((int)(((byte)(182)))));
            this.btnMouse.Image = ((System.Drawing.Image)(resources.GetObject("btnMouse.Image")));
            this.btnMouse.ImageActive = null;
            this.btnMouse.Location = new System.Drawing.Point(33, 232);
            this.btnMouse.Name = "btnMouse";
            this.btnMouse.Size = new System.Drawing.Size(143, 143);
            this.btnMouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMouse.TabIndex = 1;
            this.btnMouse.TabStop = false;
            this.ttpBtn.SetToolTip(this.btnMouse, "Clique para alterar o status!");
            this.btnMouse.Zoom = 5;
            // 
            // btnTeclado
            // 
            this.btnTeclado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(176)))), ((int)(((byte)(182)))));
            this.btnTeclado.Image = ((System.Drawing.Image)(resources.GetObject("btnTeclado.Image")));
            this.btnTeclado.ImageActive = null;
            this.btnTeclado.Location = new System.Drawing.Point(33, 414);
            this.btnTeclado.Name = "btnTeclado";
            this.btnTeclado.Size = new System.Drawing.Size(143, 143);
            this.btnTeclado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnTeclado.TabIndex = 2;
            this.btnTeclado.TabStop = false;
            this.ttpBtn.SetToolTip(this.btnTeclado, "Clique para alterar o status!");
            this.btnTeclado.Zoom = 5;
            // 
            // btnMonitor
            // 
            this.btnMonitor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(176)))), ((int)(((byte)(182)))));
            this.btnMonitor.Image = ((System.Drawing.Image)(resources.GetObject("btnMonitor.Image")));
            this.btnMonitor.ImageActive = null;
            this.btnMonitor.Location = new System.Drawing.Point(33, 595);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Size = new System.Drawing.Size(143, 143);
            this.btnMonitor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMonitor.TabIndex = 3;
            this.btnMonitor.TabStop = false;
            this.ttpBtn.SetToolTip(this.btnMonitor, "Clique para alterar o status!");
            this.btnMonitor.Zoom = 5;
            // 
            // elipseBtnMouse
            // 
            this.elipseBtnMouse.ElipseRadius = 20;
            this.elipseBtnMouse.TargetControl = this.btnMouse;
            // 
            // elipseBtnTeclado
            // 
            this.elipseBtnTeclado.ElipseRadius = 20;
            this.elipseBtnTeclado.TargetControl = this.btnTeclado;
            // 
            // elipseBtnMonitor
            // 
            this.elipseBtnMonitor.ElipseRadius = 20;
            this.elipseBtnMonitor.TargetControl = this.btnMonitor;
            // 
            // pnlTop
            // 
            this.pnlTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTop.BackgroundImage")));
            this.pnlTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.pnlTop.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(63)))));
            this.pnlTop.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.pnlTop.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Quality = 10;
            this.pnlTop.Size = new System.Drawing.Size(1000, 32);
            this.pnlTop.TabIndex = 4;
            // 
            // bdcTop
            // 
            this.bdcTop.Fixed = true;
            this.bdcTop.Horizontal = true;
            this.bdcTop.TargetControl = this.pnlTop;
            this.bdcTop.Vertical = true;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.DimGray;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 195);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1000, 35);
            this.bunifuSeparator1.TabIndex = 5;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFooter.BackgroundImage")));
            this.pnlFooter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.pnlFooter.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(63)))));
            this.pnlFooter.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.pnlFooter.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.pnlFooter.Location = new System.Drawing.Point(0, 790);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Quality = 10;
            this.pnlFooter.Size = new System.Drawing.Size(1000, 10);
            this.pnlFooter.TabIndex = 5;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(0, 559);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(1000, 35);
            this.bunifuSeparator2.TabIndex = 6;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(0, 377);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(1000, 35);
            this.bunifuSeparator3.TabIndex = 7;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // lblStatusHead
            // 
            this.lblStatusHead.AutoSize = true;
            this.lblStatusHead.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusHead.Location = new System.Drawing.Point(207, 78);
            this.lblStatusHead.Name = "lblStatusHead";
            this.lblStatusHead.Size = new System.Drawing.Size(218, 23);
            this.lblStatusHead.TabIndex = 8;
            this.lblStatusHead.Text = "Status Equipamento: ";
            // 
            // lblStatusMouse
            // 
            this.lblStatusMouse.AutoSize = true;
            this.lblStatusMouse.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblStatusMouse.Location = new System.Drawing.Point(208, 243);
            this.lblStatusMouse.Name = "lblStatusMouse";
            this.lblStatusMouse.Size = new System.Drawing.Size(187, 18);
            this.lblStatusMouse.TabIndex = 9;
            this.lblStatusMouse.Text = "Status Equipamento: ";
            // 
            // lblStatusTeclado
            // 
            this.lblStatusTeclado.AutoSize = true;
            this.lblStatusTeclado.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblStatusTeclado.Location = new System.Drawing.Point(208, 427);
            this.lblStatusTeclado.Name = "lblStatusTeclado";
            this.lblStatusTeclado.Size = new System.Drawing.Size(187, 18);
            this.lblStatusTeclado.TabIndex = 10;
            this.lblStatusTeclado.Text = "Status Equipamento: ";
            // 
            // lblStatusMonitor
            // 
            this.lblStatusMonitor.AutoSize = true;
            this.lblStatusMonitor.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblStatusMonitor.Location = new System.Drawing.Point(208, 607);
            this.lblStatusMonitor.Name = "lblStatusMonitor";
            this.lblStatusMonitor.Size = new System.Drawing.Size(187, 18);
            this.lblStatusMonitor.TabIndex = 11;
            this.lblStatusMonitor.Text = "Status Equipamento: ";
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.Location = new System.Drawing.Point(425, 78);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(0, 23);
            this.lblHead.TabIndex = 12;
            // 
            // ttpBtn
            // 
            this.ttpBtn.AutomaticDelay = 200;
            this.ttpBtn.IsBalloon = true;
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown1.BorderRadius = 3;
            this.bunifuDropdown1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown1.Items = new string[] {
        "gigi"};
            this.bunifuDropdown1.Location = new System.Drawing.Point(211, 133);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuDropdown1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuDropdown1.selectedIndex = -1;
            this.bunifuDropdown1.Size = new System.Drawing.Size(217, 35);
            this.bunifuDropdown1.TabIndex = 13;
            // 
            // ChkList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.bunifuDropdown1);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.lblStatusMonitor);
            this.Controls.Add(this.lblStatusTeclado);
            this.Controls.Add(this.lblStatusMouse);
            this.Controls.Add(this.lblStatusHead);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.btnMonitor);
            this.Controls.Add(this.btnTeclado);
            this.Controls.Add(this.btnMouse);
            this.Controls.Add(this.btnHead);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.bunifuSeparator3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChkList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChkList";
            ((System.ComponentModel.ISupportInitialize)(this.btnHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTeclado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMonitor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse elipseForm;
        private Bunifu.Framework.UI.BunifuImageButton btnHead;
        private Bunifu.Framework.UI.BunifuElipse elipseBtnHead;
        private Bunifu.Framework.UI.BunifuImageButton btnMonitor;
        private Bunifu.Framework.UI.BunifuImageButton btnTeclado;
        private Bunifu.Framework.UI.BunifuImageButton btnMouse;
        private Bunifu.Framework.UI.BunifuElipse elipseBtnMouse;
        private Bunifu.Framework.UI.BunifuElipse elipseBtnTeclado;
        private Bunifu.Framework.UI.BunifuElipse elipseBtnMonitor;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlTop;
        private Bunifu.Framework.UI.BunifuDragControl bdcTop;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlFooter;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private System.Windows.Forms.Label lblStatusMonitor;
        private System.Windows.Forms.Label lblStatusTeclado;
        private System.Windows.Forms.Label lblStatusMouse;
        private System.Windows.Forms.Label lblStatusHead;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.ToolTip ttpBtn;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown1;
    }
}