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
            this.elipseBtnHead = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnHead = new Bunifu.Framework.UI.BunifuImageButton();
            this.elipseBtnMouse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnMouse = new Bunifu.Framework.UI.BunifuImageButton();
            this.elipseBtnTeclado = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnTeclado = new Bunifu.Framework.UI.BunifuImageButton();
            this.elipseBtnMonitor = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnMonitor = new Bunifu.Framework.UI.BunifuImageButton();
            this.bdcTop = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlTop = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblStatusHead = new System.Windows.Forms.Label();
            this.lblStatusMouse = new System.Windows.Forms.Label();
            this.lblStatusTeclado = new System.Windows.Forms.Label();
            this.lblStatusMonitor = new System.Windows.Forms.Label();
            this.lblHead = new System.Windows.Forms.Label();
            this.ttpBtn = new System.Windows.Forms.ToolTip(this.components);
            this.cmbHead = new System.Windows.Forms.ComboBox();
            this.cmbMouse = new System.Windows.Forms.ComboBox();
            this.cmbTeclado = new System.Windows.Forms.ComboBox();
            this.cmbMonitor = new System.Windows.Forms.ComboBox();
            this.bunifuSeparator4 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator5 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblMouse = new System.Windows.Forms.Label();
            this.lblTeclado = new System.Windows.Forms.Label();
            this.lblMonitor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEnviar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pnlFooter = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblFooter = new System.Windows.Forms.Label();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTeclado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMonitor)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // elipseForm
            // 
            this.elipseForm.ElipseRadius = 30;
            this.elipseForm.TargetControl = this;
            // 
            // elipseBtnHead
            // 
            this.elipseBtnHead.ElipseRadius = 20;
            this.elipseBtnHead.TargetControl = this.btnHead;
            // 
            // btnHead
            // 
            this.btnHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(176)))), ((int)(((byte)(182)))));
            this.btnHead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHead.Image = ((System.Drawing.Image)(resources.GetObject("btnHead.Image")));
            this.btnHead.ImageActive = null;
            this.btnHead.Location = new System.Drawing.Point(23, 72);
            this.btnHead.Name = "btnHead";
            this.btnHead.Size = new System.Drawing.Size(143, 143);
            this.btnHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnHead.TabIndex = 0;
            this.btnHead.TabStop = false;
            this.ttpBtn.SetToolTip(this.btnHead, "Clique para alterar o status!");
            this.btnHead.Zoom = 5;
            this.btnHead.Click += new System.EventHandler(this.BtnHead_Click);
            // 
            // elipseBtnMouse
            // 
            this.elipseBtnMouse.ElipseRadius = 20;
            this.elipseBtnMouse.TargetControl = this.btnMouse;
            // 
            // btnMouse
            // 
            this.btnMouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(176)))), ((int)(((byte)(182)))));
            this.btnMouse.Image = ((System.Drawing.Image)(resources.GetObject("btnMouse.Image")));
            this.btnMouse.ImageActive = null;
            this.btnMouse.Location = new System.Drawing.Point(23, 253);
            this.btnMouse.Name = "btnMouse";
            this.btnMouse.Size = new System.Drawing.Size(143, 143);
            this.btnMouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMouse.TabIndex = 1;
            this.btnMouse.TabStop = false;
            this.ttpBtn.SetToolTip(this.btnMouse, "Clique para alterar o status!");
            this.btnMouse.Zoom = 5;
            this.btnMouse.Click += new System.EventHandler(this.BtnMouse_Click);
            // 
            // elipseBtnTeclado
            // 
            this.elipseBtnTeclado.ElipseRadius = 20;
            this.elipseBtnTeclado.TargetControl = this.btnTeclado;
            // 
            // btnTeclado
            // 
            this.btnTeclado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(176)))), ((int)(((byte)(182)))));
            this.btnTeclado.Image = ((System.Drawing.Image)(resources.GetObject("btnTeclado.Image")));
            this.btnTeclado.ImageActive = null;
            this.btnTeclado.Location = new System.Drawing.Point(582, 72);
            this.btnTeclado.Name = "btnTeclado";
            this.btnTeclado.Size = new System.Drawing.Size(143, 143);
            this.btnTeclado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnTeclado.TabIndex = 2;
            this.btnTeclado.TabStop = false;
            this.ttpBtn.SetToolTip(this.btnTeclado, "Clique para alterar o status!");
            this.btnTeclado.Zoom = 5;
            this.btnTeclado.Click += new System.EventHandler(this.BtnTeclado_Click);
            // 
            // elipseBtnMonitor
            // 
            this.elipseBtnMonitor.ElipseRadius = 20;
            this.elipseBtnMonitor.TargetControl = this.btnMonitor;
            // 
            // btnMonitor
            // 
            this.btnMonitor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(176)))), ((int)(((byte)(182)))));
            this.btnMonitor.Image = ((System.Drawing.Image)(resources.GetObject("btnMonitor.Image")));
            this.btnMonitor.ImageActive = null;
            this.btnMonitor.Location = new System.Drawing.Point(582, 253);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Size = new System.Drawing.Size(143, 143);
            this.btnMonitor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMonitor.TabIndex = 3;
            this.btnMonitor.TabStop = false;
            this.ttpBtn.SetToolTip(this.btnMonitor, "Clique para alterar o status!");
            this.btnMonitor.Zoom = 5;
            this.btnMonitor.Click += new System.EventHandler(this.BtnMonitor_Click);
            // 
            // bdcTop
            // 
            this.bdcTop.Fixed = true;
            this.bdcTop.Horizontal = true;
            this.bdcTop.TargetControl = this.pnlTop;
            this.bdcTop.Vertical = true;
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
            this.pnlTop.Size = new System.Drawing.Size(1110, 28);
            this.pnlTop.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(437, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 23);
            this.label5.TabIndex = 27;
            this.label5.Text = "SISTEMA DE CHECKLIST";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(7, 216);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1094, 35);
            this.bunifuSeparator1.TabIndex = 5;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(7, 398);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(1094, 35);
            this.bunifuSeparator3.TabIndex = 7;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // lblStatusHead
            // 
            this.lblStatusHead.AutoSize = true;
            this.lblStatusHead.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusHead.Location = new System.Drawing.Point(181, 131);
            this.lblStatusHead.Name = "lblStatusHead";
            this.lblStatusHead.Size = new System.Drawing.Size(218, 23);
            this.lblStatusHead.TabIndex = 8;
            this.lblStatusHead.Text = "Status Equipamento: ";
            // 
            // lblStatusMouse
            // 
            this.lblStatusMouse.AutoSize = true;
            this.lblStatusMouse.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusMouse.Location = new System.Drawing.Point(181, 309);
            this.lblStatusMouse.Name = "lblStatusMouse";
            this.lblStatusMouse.Size = new System.Drawing.Size(218, 23);
            this.lblStatusMouse.TabIndex = 9;
            this.lblStatusMouse.Text = "Status Equipamento: ";
            // 
            // lblStatusTeclado
            // 
            this.lblStatusTeclado.AutoSize = true;
            this.lblStatusTeclado.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusTeclado.Location = new System.Drawing.Point(742, 131);
            this.lblStatusTeclado.Name = "lblStatusTeclado";
            this.lblStatusTeclado.Size = new System.Drawing.Size(218, 23);
            this.lblStatusTeclado.TabIndex = 10;
            this.lblStatusTeclado.Text = "Status Equipamento: ";
            // 
            // lblStatusMonitor
            // 
            this.lblStatusMonitor.AutoSize = true;
            this.lblStatusMonitor.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusMonitor.Location = new System.Drawing.Point(742, 309);
            this.lblStatusMonitor.Name = "lblStatusMonitor";
            this.lblStatusMonitor.Size = new System.Drawing.Size(218, 23);
            this.lblStatusMonitor.TabIndex = 11;
            this.lblStatusMonitor.Text = "Status Equipamento: ";
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.Location = new System.Drawing.Point(399, 131);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(31, 23);
            this.lblHead.TabIndex = 12;
            this.lblHead.Text = "...";
            // 
            // ttpBtn
            // 
            this.ttpBtn.AutomaticDelay = 200;
            this.ttpBtn.IsBalloon = true;
            // 
            // cmbHead
            // 
            this.cmbHead.DropDownHeight = 200;
            this.cmbHead.Enabled = false;
            this.cmbHead.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHead.ForeColor = System.Drawing.Color.Black;
            this.cmbHead.FormattingEnabled = true;
            this.cmbHead.IntegralHeight = false;
            this.cmbHead.Items.AddRange(new object[] {
            "MAL CONTATO",
            "NÃO FUNCIONA",
            "EQUIPAMENTO DANIFICADO"});
            this.cmbHead.Location = new System.Drawing.Point(185, 175);
            this.cmbHead.Name = "cmbHead";
            this.cmbHead.Size = new System.Drawing.Size(281, 26);
            this.cmbHead.TabIndex = 13;
            this.cmbHead.Text = "INFORME O PROBLEMA...";
            // 
            // cmbMouse
            // 
            this.cmbMouse.DropDownHeight = 200;
            this.cmbMouse.Enabled = false;
            this.cmbMouse.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMouse.ForeColor = System.Drawing.Color.Black;
            this.cmbMouse.FormattingEnabled = true;
            this.cmbMouse.IntegralHeight = false;
            this.cmbMouse.Items.AddRange(new object[] {
            "DUPLO CLIQUE",
            "SCROLL NÃO FUNCIONA",
            "BOTÃO NÃO FUNCIONA",
            "MOVIMENTAÇÃO RUIM (SETA)",
            "EQUIPAMENTO DANIFICADO"});
            this.cmbMouse.Location = new System.Drawing.Point(185, 351);
            this.cmbMouse.Name = "cmbMouse";
            this.cmbMouse.Size = new System.Drawing.Size(281, 26);
            this.cmbMouse.TabIndex = 14;
            this.cmbMouse.Text = "INFORME O PROBLEMA...";
            // 
            // cmbTeclado
            // 
            this.cmbTeclado.DropDownHeight = 200;
            this.cmbTeclado.Enabled = false;
            this.cmbTeclado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTeclado.ForeColor = System.Drawing.Color.Black;
            this.cmbTeclado.FormattingEnabled = true;
            this.cmbTeclado.IntegralHeight = false;
            this.cmbTeclado.Items.AddRange(new object[] {
            "TECLA AFUNDADA",
            "MAL CONTATO",
            "TECLADO APAGADO",
            "EQUIPAMENTO DANIFICADO"});
            this.cmbTeclado.Location = new System.Drawing.Point(746, 175);
            this.cmbTeclado.Name = "cmbTeclado";
            this.cmbTeclado.Size = new System.Drawing.Size(281, 26);
            this.cmbTeclado.TabIndex = 15;
            this.cmbTeclado.Text = "INFORME O PROBLEMA...";
            // 
            // cmbMonitor
            // 
            this.cmbMonitor.DropDownHeight = 200;
            this.cmbMonitor.Enabled = false;
            this.cmbMonitor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMonitor.ForeColor = System.Drawing.Color.Black;
            this.cmbMonitor.FormattingEnabled = true;
            this.cmbMonitor.IntegralHeight = false;
            this.cmbMonitor.Items.AddRange(new object[] {
            "IMAGEM EMBAÇADA",
            "RISCO NA TELA",
            "MAL CONTATO",
            "EQUIPAMENTO DANIFICADO"});
            this.cmbMonitor.Location = new System.Drawing.Point(746, 351);
            this.cmbMonitor.Name = "cmbMonitor";
            this.cmbMonitor.Size = new System.Drawing.Size(281, 26);
            this.cmbMonitor.TabIndex = 16;
            this.cmbMonitor.Text = "INFORME O PROBLEMA...";
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator4.LineThickness = 1;
            this.bunifuSeparator4.Location = new System.Drawing.Point(526, 72);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Size = new System.Drawing.Size(30, 161);
            this.bunifuSeparator4.TabIndex = 17;
            this.bunifuSeparator4.Transparency = 255;
            this.bunifuSeparator4.Vertical = true;
            // 
            // bunifuSeparator5
            // 
            this.bunifuSeparator5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator5.LineThickness = 1;
            this.bunifuSeparator5.Location = new System.Drawing.Point(526, 245);
            this.bunifuSeparator5.Name = "bunifuSeparator5";
            this.bunifuSeparator5.Size = new System.Drawing.Size(30, 161);
            this.bunifuSeparator5.TabIndex = 18;
            this.bunifuSeparator5.Transparency = 255;
            this.bunifuSeparator5.Vertical = true;
            // 
            // lblMouse
            // 
            this.lblMouse.AutoSize = true;
            this.lblMouse.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMouse.Location = new System.Drawing.Point(399, 309);
            this.lblMouse.Name = "lblMouse";
            this.lblMouse.Size = new System.Drawing.Size(31, 23);
            this.lblMouse.TabIndex = 19;
            this.lblMouse.Text = "...";
            // 
            // lblTeclado
            // 
            this.lblTeclado.AutoSize = true;
            this.lblTeclado.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeclado.Location = new System.Drawing.Point(966, 116);
            this.lblTeclado.Name = "lblTeclado";
            this.lblTeclado.Size = new System.Drawing.Size(31, 23);
            this.lblTeclado.TabIndex = 20;
            this.lblTeclado.Text = "...";
            // 
            // lblMonitor
            // 
            this.lblMonitor.AutoSize = true;
            this.lblMonitor.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonitor.Location = new System.Drawing.Point(966, 294);
            this.lblMonitor.Name = "lblMonitor";
            this.lblMonitor.Size = new System.Drawing.Size(31, 23);
            this.lblMonitor.TabIndex = 21;
            this.lblMonitor.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "HEADSET";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(741, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "TECLADO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(180, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "MOUSE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(741, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "MONITOR";
            // 
            // btnEnviar
            // 
            this.btnEnviar.ActiveBorderThickness = 1;
            this.btnEnviar.ActiveCornerRadius = 30;
            this.btnEnviar.ActiveFillColor = System.Drawing.Color.White;
            this.btnEnviar.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(174)))), ((int)(((byte)(180)))));
            this.btnEnviar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(174)))), ((int)(((byte)(180)))));
            this.btnEnviar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEnviar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnviar.BackgroundImage")));
            this.btnEnviar.ButtonText = "Cadastrar";
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.IdleBorderThickness = 1;
            this.btnEnviar.IdleCornerRadius = 30;
            this.btnEnviar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(174)))), ((int)(((byte)(180)))));
            this.btnEnviar.IdleForecolor = System.Drawing.Color.White;
            this.btnEnviar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(174)))), ((int)(((byte)(180)))));
            this.btnEnviar.Location = new System.Drawing.Point(426, 427);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(250, 50);
            this.btnEnviar.TabIndex = 26;
            this.btnEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
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
            this.pnlFooter.Location = new System.Drawing.Point(0, 484);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Quality = 10;
            this.pnlFooter.Size = new System.Drawing.Size(1110, 27);
            this.pnlFooter.TabIndex = 5;
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.BackColor = System.Drawing.Color.Transparent;
            this.lblFooter.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.ForeColor = System.Drawing.Color.White;
            this.lblFooter.Location = new System.Drawing.Point(435, 6);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(241, 18);
            this.lblFooter.TabIndex = 3;
            this.lblFooter.Text = "Desenvolvido por Paulo Aquino.";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(7, 47);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(1094, 35);
            this.bunifuSeparator2.TabIndex = 27;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // pcbLogo
            // 
            this.pcbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pcbLogo.Image = global::CheckList.Properties.Resources.icone_winover;
            this.pcbLogo.Location = new System.Drawing.Point(12, 7);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(33, 17);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbLogo.TabIndex = 28;
            this.pcbLogo.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(181, 34);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(68, 23);
            this.lblUsuario.TabIndex = 28;
            this.lblUsuario.Text = "label6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(505, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 23);
            this.label6.TabIndex = 29;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(863, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 23);
            this.label7.TabIndex = 30;
            this.label7.Text = "label7";
            // 
            // ChkList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 511);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMonitor);
            this.Controls.Add(this.lblTeclado);
            this.Controls.Add(this.lblMouse);
            this.Controls.Add(this.bunifuSeparator5);
            this.Controls.Add(this.cmbMonitor);
            this.Controls.Add(this.cmbTeclado);
            this.Controls.Add(this.cmbMouse);
            this.Controls.Add(this.cmbHead);
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
            this.Controls.Add(this.bunifuSeparator3);
            this.Controls.Add(this.bunifuSeparator4);
            this.Controls.Add(this.bunifuSeparator2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChkList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INFORME O PROBLEMA...";
            this.Load += new System.EventHandler(this.ChkList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTeclado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMonitor)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
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
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private System.Windows.Forms.Label lblStatusMonitor;
        private System.Windows.Forms.Label lblStatusTeclado;
        private System.Windows.Forms.Label lblStatusMouse;
        private System.Windows.Forms.Label lblStatusHead;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.ToolTip ttpBtn;
        private System.Windows.Forms.ComboBox cmbHead;
        private System.Windows.Forms.ComboBox cmbMonitor;
        private System.Windows.Forms.ComboBox cmbTeclado;
        private System.Windows.Forms.ComboBox cmbMouse;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator4;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator5;
        private System.Windows.Forms.Label lblMonitor;
        private System.Windows.Forms.Label lblTeclado;
        private System.Windows.Forms.Label lblMouse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEnviar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFooter;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox pcbLogo;
    }
}