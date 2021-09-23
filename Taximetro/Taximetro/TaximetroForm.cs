using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace Taximetro
{
	public partial class TaximetroForm : Form
	{
		private double _valorHora = 0;
		private DateTime _dataHoraInicio;

		public TaximetroForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			var valorHora = ConfigurationManager.AppSettings["ValorHora"];

			double.TryParse(valorHora, out _valorHora);
			
			if(_valorHora <= 0)
			{
				_valorHora = 1;
			}
		}

		private void LigarTaximetroButton_Click(object sender, EventArgs e)
		{
			TaximetroTimer.Start();

			_dataHoraInicio = DateTime.Now;

			HoraInicioLabel.Text = $"Hora Início: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}";
		}

		private void TaximetroTimer_Tick(object sender, EventArgs e)
		{
			DateTime agora = DateTime.Now;

			var difH = agora.Subtract(_dataHoraInicio);

			TempoTrabalhoLlabel.Text = $"Tempo Trabalho:{new DateTime(difH.Ticks).ToString("HH:mm:ss")}";

			double valorSegundo = _valorHora / 3600;

			var totalS = difH.TotalSeconds;

			var valorHora = totalS * valorSegundo;

			TaximetroLabel.Text = valorHora.ToString("C2");
		}

		private void StopButton_Click(object sender, EventArgs e)
		{
			TaximetroTimer.Stop();
		}
	}
}
