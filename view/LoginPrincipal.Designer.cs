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
            this.pgbLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(49)))), ((int)(((byte)(128)))));
            this.pgbLogin.LabelVisible = true;
            this.pgbLogin.LineProgressThickness = 8;
            this.pgbLogin.LineThickness = 5;
            this.pgbLogin.Location = new System.Drawing.Point(143, 62);
            this.pgbLogin.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.pgbLogin.MaxValue = 100;
            this.pgbLogin.Name = "pgbLogin";
            this.pgbLogin.ProgressBackColor = System.Drawing.Color.Black;
            this.pgbLogin.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(49)))), ((int)(((byte)(128)))));
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
            // LoginPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.lblVerificacao);
            this.Controls.Add(this.pgbLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginPrincipal";
            this.Load += new System.EventHandler(this.LoginPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label lblVerificacao;
        private ns1.BunifuCircleProgressbar pgbLogin;
        private System.Windows.Forms.Timer timerPgb;
    }
}