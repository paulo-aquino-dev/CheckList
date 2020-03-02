namespace CheckList.view
{
    partial class LoginPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPrincipal));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pgbLogin = new ns1.BunifuCircleProgressbar();
            this.lblVerificacao = new System.Windows.Forms.Label();
            this.timerPgb = new System.Windows.Forms.Timer(this.components);
            this.pnlTop = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlFooter = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblFooter = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pgbLogin
            // 
            this.pgbLogin.animated = false;
            this.pgbLogin.animationIterval = 5;
            this.pgbLogin.animationSpeed = 300;
            this.pgbLogin.BackColor = System.Drawing.Color.Transparent;
            this.pgbLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pgbLogin.BackgroundImage")));
            this.pgbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.pgbLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pgbLogin.LabelVisible = true;
            this.pgbLogin.LineProgressThickness = 8;
            this.pgbLogin.LineThickness = 5;
            this.pgbLogin.Location = new System.Drawing.Point(143, 62);
            this.pgbLogin.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.pgbLogin.MaxValue = 100;
            this.pgbLogin.Name = "pgbLogin";
            this.pgbLogin.ProgressBackColor = System.Drawing.Color.Black;
            this.pgbLogin.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pgbLogin.Size = new System.Drawing.Size(201, 201);
            this.pgbLogin.TabIndex = 0;
            this.pgbLogin.Value = 0;
            // 
            // lblVerificacao
            // 
            this.lblVerificacao.AutoSize = true;
            this.lblVerificacao.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerificacao.Location = new System.Drawing.Point(39, 321);
            this.lblVerificacao.Name = "lblVerificacao";
            this.lblVerificacao.Size = new System.Drawing.Size(36, 25);
            this.lblVerificacao.TabIndex = 1;
            this.lblVerificacao.Text = "...";
            // 
            // timerPgb
            // 
            this.timerPgb.Tick += new System.EventHandler(this.TimerPgb_Tick);
            // 
            // pnlTop
            // 
            this.pnlTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTop.BackgroundImage")));
            this.pnlTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTop.Controls.Add(this.pcbLogo);
            this.pnlTop.Controls.Add(this.label5);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.GradientBottomLeft = System.Drawing.Color.Black;
            this.pnlTop.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(63)))));
            this.pnlTop.GradientTopLeft = System.Drawing.Color.Black;
            this.pnlTop.GradientTopRight = System.Drawing.Color.Black;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Quality = 10;
            this.pnlTop.Size = new System.Drawing.Size(500, 31);
            this.pnlTop.TabIndex = 5;
            // 
            // pcbLogo
            // 
            this.pcbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pcbLogo.Image = global::CheckList.Properties.Resources.icone_winover;
            this.pcbLogo.Location = new System.Drawing.Point(7, 7);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(33, 17);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbLogo.TabIndex = 28;
            this.pcbLogo.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(126, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 23);
            this.label5.TabIndex = 27;
            this.label5.Text = "SISTEMA DE CHECKLIST";
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFooter.BackgroundImage")));
            this.pnlFooter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFooter.Controls.Add(this.lblFooter);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.GradientBottomLeft = System.Drawing.Color.Black;
            this.pnlFooter.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(63)))));
            this.pnlFooter.GradientTopLeft = System.Drawing.Color.Black;
            this.pnlFooter.GradientTopRight = System.Drawing.Color.Black;
            this.pnlFooter.Location = new System.Drawing.Point(0, 379);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Quality = 10;
            this.pnlFooter.Size = new System.Drawing.Size(500, 21);
            this.pnlFooter.TabIndex = 6;
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.BackColor = System.Drawing.Color.Transparent;
            this.lblFooter.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.ForeColor = System.Drawing.Color.White;
            this.lblFooter.Location = new System.Drawing.Point(127, 2);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(241, 18);
            this.lblFooter.TabIndex = 3;
            this.lblFooter.Text = "Desenvolvido por Paulo Aquino.";
            // 
            // LoginPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.lblVerificacao);
            this.Controls.Add(this.pgbLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginPrincipal";
            this.Load += new System.EventHandler(this.LoginPrincipal_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label lblVerificacao;
        private ns1.BunifuCircleProgressbar pgbLogin;
        private System.Windows.Forms.Timer timerPgb;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlTop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pcbLogo;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlFooter;
        private System.Windows.Forms.Label lblFooter;
    }
}