namespace NuGetUsageReport
{
	partial class MainForm
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
			this.dgvPackages = new System.Windows.Forms.DataGridView();
			this.lblSolution = new System.Windows.Forms.Label();
			this.txtSolution = new System.Windows.Forms.TextBox();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.btnAnalyze = new System.Windows.Forms.Button();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Version = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Projects = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvPackages)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvPackages
			// 
			this.dgvPackages.AllowUserToAddRows = false;
			this.dgvPackages.AllowUserToDeleteRows = false;
			this.dgvPackages.AllowUserToResizeRows = false;
			this.dgvPackages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvPackages.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPackages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Version,
            this.Projects});
			this.dgvPackages.Location = new System.Drawing.Point(12, 43);
			this.dgvPackages.Name = "dgvPackages";
			this.dgvPackages.ReadOnly = true;
			this.dgvPackages.RowHeadersVisible = false;
			this.dgvPackages.Size = new System.Drawing.Size(792, 452);
			this.dgvPackages.TabIndex = 0;
			// 
			// lblSolution
			// 
			this.lblSolution.AutoSize = true;
			this.lblSolution.Location = new System.Drawing.Point(12, 17);
			this.lblSolution.Name = "lblSolution";
			this.lblSolution.Size = new System.Drawing.Size(100, 13);
			this.lblSolution.TabIndex = 1;
			this.lblSolution.Text = "Select Solution File:";
			// 
			// txtSolution
			// 
			this.txtSolution.ForeColor = System.Drawing.SystemColors.ActiveBorder;
			this.txtSolution.Location = new System.Drawing.Point(118, 13);
			this.txtSolution.Name = "txtSolution";
			this.txtSolution.ReadOnly = true;
			this.txtSolution.Size = new System.Drawing.Size(337, 20);
			this.txtSolution.TabIndex = 2;
			// 
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(461, 12);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(75, 23);
			this.btnBrowse.TabIndex = 3;
			this.btnBrowse.Text = "Browse...";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// btnAnalyze
			// 
			this.btnAnalyze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAnalyze.Enabled = false;
			this.btnAnalyze.Location = new System.Drawing.Point(729, 12);
			this.btnAnalyze.Name = "btnAnalyze";
			this.btnAnalyze.Size = new System.Drawing.Size(75, 23);
			this.btnAnalyze.TabIndex = 4;
			this.btnAnalyze.Text = "Analyze";
			this.btnAnalyze.UseVisualStyleBackColor = true;
			this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
			// 
			// openFileDialog
			// 
			this.openFileDialog.Filter = "Solution Files|*.sln";
			// 
			// Id
			// 
			this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Id.DataPropertyName = "Id";
			this.Id.HeaderText = "Id";
			this.Id.Name = "Id";
			this.Id.ReadOnly = true;
			this.Id.Width = 41;
			// 
			// Version
			// 
			this.Version.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Version.DataPropertyName = "Version";
			this.Version.HeaderText = "Version";
			this.Version.Name = "Version";
			this.Version.ReadOnly = true;
			this.Version.Width = 67;
			// 
			// Projects
			// 
			this.Projects.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Projects.DataPropertyName = "Projects";
			this.Projects.HeaderText = "Projects";
			this.Projects.Name = "Projects";
			this.Projects.ReadOnly = true;
			this.Projects.Width = 70;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(816, 507);
			this.Controls.Add(this.btnAnalyze);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.txtSolution);
			this.Controls.Add(this.lblSolution);
			this.Controls.Add(this.dgvPackages);
			this.Name = "MainForm";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dgvPackages)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvPackages;
		private System.Windows.Forms.Label lblSolution;
		private System.Windows.Forms.TextBox txtSolution;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.Button btnAnalyze;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn Version;
		private System.Windows.Forms.DataGridViewTextBoxColumn Projects;
	}
}

