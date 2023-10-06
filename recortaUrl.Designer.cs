namespace QR_Generator
{
    partial class recortaUrl
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTextoLargo = new DevExpress.XtraEditors.TextEdit();
            this.txtTextoCorto = new DevExpress.XtraEditors.TextEdit();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtTextoLargo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTextoCorto.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(12, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(141, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Ingrese texto largo";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(12, 115);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(141, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Texto corto";
            // 
            // txtTextoLargo
            // 
            this.txtTextoLargo.Location = new System.Drawing.Point(13, 45);
            this.txtTextoLargo.Name = "txtTextoLargo";
            this.txtTextoLargo.Size = new System.Drawing.Size(461, 22);
            this.txtTextoLargo.TabIndex = 2;
            // 
            // txtTextoCorto
            // 
            this.txtTextoCorto.Location = new System.Drawing.Point(13, 138);
            this.txtTextoCorto.Name = "txtTextoCorto";
            this.txtTextoCorto.Size = new System.Drawing.Size(461, 22);
            this.txtTextoCorto.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(502, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 117);
            this.button1.TabIndex = 4;
            this.button1.Text = "Recortar URL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // recortaUrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(671, 212);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTextoCorto);
            this.Controls.Add(this.txtTextoLargo);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "recortaUrl";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recorta URL";
            ((System.ComponentModel.ISupportInitialize)(this.txtTextoLargo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTextoCorto.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTextoLargo;
        private DevExpress.XtraEditors.TextEdit txtTextoCorto;
        private System.Windows.Forms.Button button1;
    }
}