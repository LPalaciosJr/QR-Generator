namespace QR_Generator
{
    partial class generaQr
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnRecortaUrl = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSaveSVG = new DevExpress.XtraEditors.SimpleButton();
            this.btnSavePNG = new DevExpress.XtraEditors.SimpleButton();
            this.btnGenerar = new DevExpress.XtraEditors.SimpleButton();
            this.txtContenido = new DevExpress.XtraEditors.TextEdit();
            this.pictureQR = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtContenido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureQR)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRecortaUrl,
            this.btnAcercaDe});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1130, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnRecortaUrl
            // 
            this.btnRecortaUrl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRecortaUrl.Name = "btnRecortaUrl";
            this.btnRecortaUrl.Size = new System.Drawing.Size(116, 24);
            this.btnRecortaUrl.Text = "Recortar URL";
            this.btnRecortaUrl.Click += new System.EventHandler(this.btnRecortaUrl_Click);
            // 
            // btnAcercaDe
            // 
            this.btnAcercaDe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAcercaDe.Name = "btnAcercaDe";
            this.btnAcercaDe.Size = new System.Drawing.Size(91, 24);
            this.btnAcercaDe.Text = "Acerca de";
            this.btnAcercaDe.Click += new System.EventHandler(this.btnAcercaDe_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureQR);
            this.splitContainer1.Size = new System.Drawing.Size(1130, 528);
            this.splitContainer1.SplitterDistance = 445;
            this.splitContainer1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.btnSaveSVG);
            this.groupBox1.Controls.Add(this.btnSavePNG);
            this.groupBox1.Controls.Add(this.btnGenerar);
            this.groupBox1.Controls.Add(this.txtContenido);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 499);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generador de códigos QR";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(21, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(157, 22);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Ingrese texto o URL";
            // 
            // btnSaveSVG
            // 
            this.btnSaveSVG.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnSaveSVG.Appearance.Options.UseFont = true;
            this.btnSaveSVG.Location = new System.Drawing.Point(273, 166);
            this.btnSaveSVG.Name = "btnSaveSVG";
            this.btnSaveSVG.Size = new System.Drawing.Size(138, 54);
            this.btnSaveSVG.TabIndex = 17;
            this.btnSaveSVG.Text = "Guardar SVG";
            this.btnSaveSVG.Click += new System.EventHandler(this.btnSaveSVG_Click);
            // 
            // btnSavePNG
            // 
            this.btnSavePNG.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnSavePNG.Appearance.Options.UseFont = true;
            this.btnSavePNG.Location = new System.Drawing.Point(21, 166);
            this.btnSavePNG.Name = "btnSavePNG";
            this.btnSavePNG.Size = new System.Drawing.Size(138, 54);
            this.btnSavePNG.TabIndex = 18;
            this.btnSavePNG.Text = "Guardar PNG";
            this.btnSavePNG.Click += new System.EventHandler(this.btnSavePNG_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnGenerar.Appearance.Options.UseFont = true;
            this.btnGenerar.Location = new System.Drawing.Point(317, 68);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(94, 29);
            this.btnGenerar.TabIndex = 17;
            this.btnGenerar.Text = "Generar QR";
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtContenido
            // 
            this.txtContenido.Location = new System.Drawing.Point(21, 72);
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.txtContenido.Properties.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.txtContenido.Properties.Appearance.Options.UseFont = true;
            this.txtContenido.Properties.Appearance.Options.UseForeColor = true;
            this.txtContenido.Size = new System.Drawing.Size(290, 22);
            this.txtContenido.TabIndex = 12;
            // 
            // pictureQR
            // 
            this.pictureQR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureQR.Location = new System.Drawing.Point(0, 0);
            this.pictureQR.Name = "pictureQR";
            this.pictureQR.Size = new System.Drawing.Size(681, 528);
            this.pictureQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureQR.TabIndex = 10;
            this.pictureQR.TabStop = false;
            // 
            // generaQr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1130, 556);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "generaQr";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Generator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtContenido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnAcercaDe;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureQR;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSaveSVG;
        private DevExpress.XtraEditors.SimpleButton btnSavePNG;
        private DevExpress.XtraEditors.SimpleButton btnGenerar;
        private DevExpress.XtraEditors.TextEdit txtContenido;
        private System.Windows.Forms.ToolStripMenuItem btnRecortaUrl;
    }
}

