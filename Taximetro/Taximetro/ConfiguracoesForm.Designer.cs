
namespace Taximetro
{
	partial class ConfiguracoesForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.ValorHoraTextBox = new System.Windows.Forms.TextBox();
			this.HorarioIniciadoTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.ExibirHorarioCheckBox = new System.Windows.Forms.CheckBox();
			this.SalvarButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(25, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Valor Hora:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ValorHoraTextBox
			// 
			this.ValorHoraTextBox.Location = new System.Drawing.Point(121, 29);
			this.ValorHoraTextBox.Name = "ValorHoraTextBox";
			this.ValorHoraTextBox.Size = new System.Drawing.Size(146, 20);
			this.ValorHoraTextBox.TabIndex = 1;
			// 
			// HorarioIniciadoTextBox
			// 
			this.HorarioIniciadoTextBox.Location = new System.Drawing.Point(121, 99);
			this.HorarioIniciadoTextBox.Name = "HorarioIniciadoTextBox";
			this.HorarioIniciadoTextBox.Size = new System.Drawing.Size(146, 20);
			this.HorarioIniciadoTextBox.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(25, 102);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Horario Iniciado:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ExibirHorarioCheckBox
			// 
			this.ExibirHorarioCheckBox.AutoSize = true;
			this.ExibirHorarioCheckBox.Location = new System.Drawing.Point(121, 70);
			this.ExibirHorarioCheckBox.Name = "ExibirHorarioCheckBox";
			this.ExibirHorarioCheckBox.Size = new System.Drawing.Size(88, 17);
			this.ExibirHorarioCheckBox.TabIndex = 2;
			this.ExibirHorarioCheckBox.Text = "Exibir Horário";
			this.ExibirHorarioCheckBox.UseVisualStyleBackColor = true;
			// 
			// SalvarButton
			// 
			this.SalvarButton.Location = new System.Drawing.Point(191, 148);
			this.SalvarButton.Name = "SalvarButton";
			this.SalvarButton.Size = new System.Drawing.Size(75, 23);
			this.SalvarButton.TabIndex = 4;
			this.SalvarButton.Text = "Salvar";
			this.SalvarButton.UseVisualStyleBackColor = true;
			this.SalvarButton.Click += new System.EventHandler(this.SalvarButton_Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(121, 122);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(146, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Ex.: 09:00 (5 caracteres)";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ConfiguracoesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(299, 189);
			this.ControlBox = false;
			this.Controls.Add(this.label2);
			this.Controls.Add(this.SalvarButton);
			this.Controls.Add(this.ExibirHorarioCheckBox);
			this.Controls.Add(this.HorarioIniciadoTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.ValorHoraTextBox);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximumSize = new System.Drawing.Size(315, 228);
			this.MinimumSize = new System.Drawing.Size(315, 228);
			this.Name = "ConfiguracoesForm";
			this.Text = "Configurações";
			this.Load += new System.EventHandler(this.ConfiguracoesForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox ValorHoraTextBox;
		private System.Windows.Forms.TextBox HorarioIniciadoTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox ExibirHorarioCheckBox;
		private System.Windows.Forms.Button SalvarButton;
		private System.Windows.Forms.Label label2;
	}
}