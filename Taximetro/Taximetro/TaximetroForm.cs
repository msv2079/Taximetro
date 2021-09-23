using System;
using System.IO;
using System.Windows.Forms;

namespace Taximetro
{
	public partial class TaximetroForm : Form
	{
		public string _arqConfig = Path.Combine(Environment.CurrentDirectory, "config.txt");
		DateTime _dataHoraInicio = DateTime.MinValue;

		public TaximetroForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			if (!File.Exists(_arqConfig))
			{
				File.Create(_arqConfig).Close();
				File.AppendAllText(_arqConfig, $"5¿1¿09:00");
			}
		}

		private void LigarTaximetroButton_Click(object sender, EventArgs e)
		{
			TaximetroTimer.Start();

			_dataHoraInicio = DateTime.Now;
		}

		private void TaximetroTimer_Tick(object sender, EventArgs e)
		{
			var hoje = DateTime.Now;

			var arquivo = File.ReadAllText(_arqConfig);

			var valorHora = 0d;
			var exibirHorario = true;
			var horarioInicio = "09:00";

			var splitDados = arquivo.Split('¿');

			if (splitDados.Length == 3)
			{
				var strValorHora = splitDados[0];
				var strExibirHorario = splitDados[1];
				var strHorarioInicio = splitDados[2];

				if (!double.TryParse(strValorHora, out valorHora))
				{
					valorHora = 5;
				}

				exibirHorario = "1".Equals(strExibirHorario);

				if (strHorarioInicio == "agora")
				{
					hoje = _dataHoraInicio;
				}
				else if (strHorarioInicio.Length == 5 && strHorarioInicio.Contains(":"))
				{
					horarioInicio = strHorarioInicio;

					var splitHora = horarioInicio.Split(':');
					var strHora = splitHora[0];
					var strMinuro = splitHora[1];
					var hora = 9;
					var minuto = 0;

					if (int.TryParse(strHora, out hora) && int.TryParse(strMinuro, out minuto))
					{
						hoje = new DateTime(hoje.Year, hoje.Month, hoje.Day, hora, minuto, 0);
					}
				}
			}

			HoraInicioLabel.Text = hoje.ToString("HH:mm:ss");

			DateTime agora = DateTime.Now;

			var difH = agora.Subtract(hoje);

			TempoTrabalhoLlabel.Text = $"Tempo Trabalho:{new DateTime(difH.Ticks).ToString("HH:mm:ss")}";

			double valorSegundo = valorHora / 3600;

			var totalS = difH.TotalSeconds;

			var valorTotal = totalS * valorSegundo;

			TaximetroLabel.Text = valorTotal.ToString("C2");

			HoraInicioLabel.Visible = exibirHorario;
			TempoTrabalhoLlabel.Visible = exibirHorario;
		}

		private void StopButton_Click(object sender, EventArgs e)
		{
			TaximetroTimer.Stop();
		}

		private void configToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TaximetroTimer.Stop();

			var left = this.DesktopLocation.X;
			var top = this.DesktopLocation.Y;

			var formConfig = new ConfiguracoesForm();
			formConfig.StartPosition = FormStartPosition.Manual;
			formConfig.Left = left;
			formConfig.Top = top - this.Height;
			formConfig.TopMost = true;
			formConfig.ShowDialog();

			TaximetroTimer.Start();
		}

		private void helpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Desenvolvido por: Murilo Siqueira");
		}
	}
}
