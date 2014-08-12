using System;
using System.Windows.Forms;
using NuGetPackageAnalyzer;

namespace NuGetUsageReport
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

			dgvPackages.AutoGenerateColumns = false;
			dgvPackages.Columns["Projects"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
			dgvPackages.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
			dgvPackages.Columns["Version"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				dgvPackages.DataSource = null;

				txtSolution.Text = openFileDialog.FileName;
				btnAnalyze.Enabled = true;
			}
		}

		private void btnAnalyze_Click(object sender, EventArgs e)
		{
			var analyzer = new PackageAnalyzer(txtSolution.Text);
			var results = analyzer.Analyze();
			dgvPackages.DataSource = results;
		}
	}
}
