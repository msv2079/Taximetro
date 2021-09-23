using System;
using System.IO;
using System.Windows.Forms;

namespace Taximetro
{
	public partial class ConfiguracoesForm : Form
	{
		public ConfiguracoesForm()
		{
			InitializeComponent();
		}

		public string _arqConfig = Path.Combine(Environment.CurrentDirectory, "config.txt");

		private void SalvarButton_Click(object sender, EventArgs e)
		{
			var valorHora = 0d;

			if (!double.TryParse(ValorHoraTextBox.Text, out valorHora))
			{
				valorHora = 5;
			}

			var exibirHorario = ExibirHorarioCheckBox.Checked ? "1" : "0";
			var horarioInicio = "09:00";

			var txtHora = HorarioIniciadoTextBox.Text;

			if (txtHora == "agora")
			{
				horarioInicio = txtHora;
			}
			else if (txtHora.Length == 5 && txtHora.Contains(":"))
			{
				var splitHora = txtHora.Split(':');
				var strHora = splitHora[0];
				var strMinuto = splitHora[1];

				if (int.TryParse(strHora, out var hora) && int.TryParse(strMinuto, out var minuto))
				{
					horarioInicio = txtHora;
				}
			}

			if (File.Exists(_arqConfig))
			{
				File.Delete(_arqConfig);
			}

			File.Create(_arqConfig).Close();
			File.AppendAllText(_arqConfig, $"{valorHora.ToString()}¿{exibirHorario}¿{horarioInicio}");

			this.Close();
		}

		private void ConfiguracoesForm_Load(object sender, EventArgs e)
		{
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
					horarioInicio = strHorarioInicio;
				}
				else if (strHorarioInicio.Length == 5 && strHorarioInicio.Contains(":"))
				{
					var splitHora = strHorarioInicio.Split(':');
					var strHora = splitHora[0];
					var strMinuto = splitHora[1];

					if (int.TryParse(strHora, out var hora) && int.TryParse(strMinuto, out var minuto))
					{
						horarioInicio = strHorarioInicio;
					}
				}
			}

			ValorHoraTextBox.Text = valorHora.ToString();
			ExibirHorarioCheckBox.Checked = exibirHorario;
			HorarioIniciadoTextBox.Text = horarioInicio;
		}
	}
}
