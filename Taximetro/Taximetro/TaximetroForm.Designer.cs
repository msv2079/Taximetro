namespace Taximetro
{
    partial class TaximetroForm
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
			this.TaximetroLabel = new System.Windows.Forms.Label();
			this.LigarTaximetroButton = new System.Windows.Forms.Button();
			this.TaximetroTimer = new System.Windows.Forms.Timer(this.components);
			this.StopButton = new System.Windows.Forms.Button();
			this.HoraInicioLabel = new System.Windows.Forms.Label();
			this.TempoTrabalhoLlabel = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// TaximetroLabel
			// 
			this.TaximetroLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TaximetroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TaximetroLabel.Location = new System.Drawing.Point(12, 56);
			this.TaximetroLabel.Name = "TaximetroLabel";
			this.TaximetroLabel.Size = new System.Drawing.Size(325, 78);
			this.TaximetroLabel.TabIndex = 0;
			this.TaximetroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LigarTaximetroButton
			// 
			this.LigarTaximetroButton.Location = new System.Drawing.Point(12, 30);
			this.LigarTaximetroButton.Name = "LigarTaximetroButton";
			this.LigarTaximetroButton.Size = new System.Drawing.Size(40, 23);
			this.LigarTaximetroButton.TabIndex = 1;
			this.LigarTaximetroButton.Text = ">";
			this.LigarTaximetroButton.UseVisualStyleBackColor = true;
			this.LigarTaximetroButton.Click += new System.EventHandler(this.LigarTaximetroButton_Click);
			// 
			// TaximetroTimer
			// 
			this.TaximetroTimer.Interval = 1000;
			this.TaximetroTimer.Tick += new System.EventHandler(this.TaximetroTimer_Tick);
			// 
			// StopButton
			// 
			this.StopButton.Location = new System.Drawing.Point(12, 137);
			this.StopButton.Name = "StopButton";
			this.StopButton.Size = new System.Drawing.Size(40, 23);
			this.StopButton.TabIndex = 4;
			this.StopButton.Text = "||";
			this.StopButton.UseVisualStyleBackColor = true;
			this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
			// 
			// HoraInicioLabel
			// 
			this.HoraInicioLabel.Location = new System.Drawing.Point(58, 30);
			this.HoraInicioLabel.Name = "HoraInicioLabel";
			this.HoraInicioLabel.Size = new System.Drawing.Size(279, 18);
			this.HoraInicioLabel.TabIndex = 5;
			this.HoraInicioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// TempoTrabalhoLlabel
			// 
			this.TempoTrabalhoLlabel.Location = new System.Drawing.Point(58, 142);
			this.TempoTrabalhoLlabel.Name = "TempoTrabalhoLlabel";
			this.TempoTrabalhoLlabel.Size = new System.Drawing.Size(279, 18);
			this.TempoTrabalhoLlabel.TabIndex = 6;
			this.TempoTrabalhoLlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(349, 24);
			this.menuStrip1.TabIndex = 7;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// configToolStripMenuItem
			// 
			this.configToolStripMenuItem.Name = "configToolStripMenuItem";
			this.configToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.configToolStripMenuItem.Text = "&Config";
			this.configToolStripMenuItem.Click += new System.EventHandler(this.configToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
			this.helpToolStripMenuItem.Text = "&Sobre";
			this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
			// 
			// TaximetroForm
			// 
			this.AcceptButton = this.LigarTaximetroButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(349, 172);
			this.Controls.Add(this.TempoTrabalhoLlabel);
			this.Controls.Add(this.HoraInicioLabel);
			this.Controls.Add(this.StopButton);
			this.Controls.Add(this.LigarTaximetroButton);
			this.Controls.Add(this.TaximetroLabel);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(365, 211);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(365, 211);
			this.Name = "TaximetroForm";
			this.ShowIcon = false;
			this.TopMost = true;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TaximetroLabel;
        private System.Windows.Forms.Button LigarTaximetroButton;
		private System.Windows.Forms.Timer TaximetroTimer;
		private System.Windows.Forms.Button StopButton;
		private System.Windows.Forms.Label HoraInicioLabel;
		private System.Windows.Forms.Label TempoTrabalhoLlabel;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
	}
}

