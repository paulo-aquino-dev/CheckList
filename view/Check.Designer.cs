namespace CheckList.view
{
    partial class Check
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Check));
            this.elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnHead = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMonitor = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnTeclado = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMouse = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMonitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTeclado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMouse)).BeginInit();
            this.SuspendLayout();
            // 
            // elipse
            // 
            this.elipse.ElipseRadius = 20;
            this.elipse.TargetControl = this;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this.btnHead;
            // 
            // btnHead
            // 
            this.btnHead.BackColor = System.Drawing.Color.Wheat;
            this.btnHead.ImageActive = null;
            this.btnHead.Location = new System.Drawing.Point(45, 69);
            this.btnHead.Name = "btnHead";
            this.btnHead.Size = new System.Drawing.Size(168, 170);
            this.btnHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnHead.TabIndex = 1;
            this.btnHead.TabStop = false;
            this.btnHead.Zoom = 5;
            this.btnHead.Click += new System.EventHandler(this.BtnHead_Click);
            // 
            // btnMonitor
            // 
            this.btnMonitor.BackColor = System.Drawing.Color.Wheat;
            this.btnMonitor.ImageActive = null;
            this.btnMonitor.Location = new System.Drawing.Point(45, 267);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Size = new System.Drawing.Size(168, 170);
            this.btnMonitor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMonitor.TabIndex = 2;
            this.btnMonitor.TabStop = false;
            this.btnMonitor.Zoom = 5;
            // 
            // btnTeclado
            // 
            this.btnTeclado.BackColor = System.Drawing.Color.Wheat;
            this.btnTeclado.Image = ((System.Drawing.Image)(resources.GetObject("btnTeclado.Image")));
            this.btnTeclado.ImageActive = null;
            this.btnTeclado.Location = new System.Drawing.Point(397, 267);
            this.btnTeclado.Name = "btnTeclado";
            this.btnTeclado.Size = new System.Drawing.Size(168, 170);
            this.btnTeclado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnTeclado.TabIndex = 3;
            this.btnTeclado.TabStop = false;
            this.btnTeclado.Zoom = 5;
            // 
            // btnMouse
            // 
            this.btnMouse.BackColor = System.Drawing.Color.Wheat;
            this.btnMouse.ImageActive = null;
            this.btnMouse.Location = new System.Drawing.Point(397, 69);
            this.btnMouse.Name = "btnMouse";
            this.btnMouse.Size = new System.Drawing.Size(168, 170);
            this.btnMouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMouse.TabIndex = 4;
            this.btnMouse.TabStop = false;
            this.btnMouse.Zoom = 5;
            // 
            // Check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.btnMouse);
            this.Controls.Add(this.btnTeclado);
            this.Controls.Add(this.btnMonitor);
            this.Controls.Add(this.btnHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Check";
            this.Text = "checkList";
            ((System.ComponentModel.ISupportInitialize)(this.btnHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMonitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTeclado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMouse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse elipse;
        private Bunifu.Framework.UI.BunifuImageButton btnHead;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton btnMouse;
        private Bunifu.Framework.UI.BunifuImageButton btnTeclado;
        private Bunifu.Framework.UI.BunifuImageButton btnMonitor;
    }
}