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
            this.btnHead.BackColor = System.Drawing.Color.SeaGreen;
            this.btnHead.Image = ((System.Drawing.Image)(resources.GetObject("btnHead.Image")));
            this.btnHead.ImageActive = null;
            this.btnHead.Location = new System.Drawing.Point(33, 47);
            this.btnHead.Name = "btnHead";
            this.btnHead.Size = new System.Drawing.Size(175, 158);
            this.btnHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHead.TabIndex = 0;
            this.btnHead.TabStop = false;
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
            this.btnMouse.BackColor = System.Drawing.Color.SeaGreen;
            this.btnMouse.Image = ((System.Drawing.Image)(resources.GetObject("btnMouse.Image")));
            this.btnMouse.ImageActive = null;
            this.btnMouse.Location = new System.Drawing.Point(33, 225);
            this.btnMouse.Name = "btnMouse";
            this.btnMouse.Size = new System.Drawing.Size(175, 158);
            this.btnMouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMouse.TabIndex = 1;
            this.btnMouse.TabStop = false;
            this.btnMouse.Zoom = 5;
            // 
            // btnTeclado
            // 
            this.btnTeclado.BackColor = System.Drawing.Color.SeaGreen;
            this.btnTeclado.Image = ((System.Drawing.Image)(resources.GetObject("btnTeclado.Image")));
            this.btnTeclado.ImageActive = null;
            this.btnTeclado.Location = new System.Drawing.Point(33, 411);
            this.btnTeclado.Name = "btnTeclado";
            this.btnTeclado.Size = new System.Drawing.Size(175, 158);
            this.btnTeclado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnTeclado.TabIndex = 2;
            this.btnTeclado.TabStop = false;
            this.btnTeclado.Zoom = 5;
            // 
            // btnMonitor
            // 
            this.btnMonitor.BackColor = System.Drawing.Color.SeaGreen;
            this.btnMonitor.Image = ((System.Drawing.Image)(resources.GetObject("btnMonitor.Image")));
            this.btnMonitor.ImageActive = null;
            this.btnMonitor.Location = new System.Drawing.Point(33, 605);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Size = new System.Drawing.Size(175, 158);
            this.btnMonitor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMonitor.TabIndex = 3;
            this.btnMonitor.TabStop = false;
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
            // ChkList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.btnMonitor);
            this.Controls.Add(this.btnTeclado);
            this.Controls.Add(this.btnMouse);
            this.Controls.Add(this.btnHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChkList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChkList";
            ((System.ComponentModel.ISupportInitialize)(this.btnHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTeclado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMonitor)).EndInit();
            this.ResumeLayout(false);

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
    }
}