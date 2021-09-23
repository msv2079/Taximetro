using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace Taximetro
{
	public partial class TaximetroForm : Form
	{
		private double _valorHora = 0;
		private DateTime _hoje;
		private bool _exibirHorario = false;
		private DateTime _horarioIniciado = DateTime.MinValue;

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

			_exibirHorario = "1".Equals(ConfigurationManager.AppSettings["ExibirHorario"]);

			var horarioIniciado = ConfigurationManager.AppSettings["HorarioIniciado"];

			if (horarioIniciado.Contains(":"))
			{
				var splitHorario = horarioIniciado.Split(':');
				var strHora = splitHorario[0];
				var strMinuro = splitHorario[1];

				_hoje = DateTime.Now;

				if (int.TryParse(strHora, out var hora) && int.TryParse(strMinuro, out var minuto))
				{
					_horarioIniciado = new DateTime(_hoje.Year, _hoje.Month, _hoje.Day, hora, minuto, 0);
				}
			}
		}

		private void LigarTaximetroButton_Click(object sender, EventArgs e)
		{
			TaximetroTimer.Start();

			_hoje = DateTime.Now;

			if(_horarioIniciado != DateTime.MinValue)
			{
				_hoje = _horarioIniciado;
			}

			HoraInicioLabel.Text = $"Hora Início: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}";
			HoraInicioLabel.Visible = _exibirHorario;
			TempoTrabalhoLlabel.Visible = _exibirHorario;
		}

		private void TaximetroTimer_Tick(object sender, EventArgs e)
		{
			DateTime agora = DateTime.Now;

			var difH = agora.Subtract(_hoje);

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
