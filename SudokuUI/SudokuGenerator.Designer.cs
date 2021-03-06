﻿namespace SudokuUI
{
    partial class SudokuGenerator
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SudokuGenerator));
            this.buttonGenSolution = new System.Windows.Forms.Button();
            this.buttonGenPuzzle = new System.Windows.Forms.Button();
            this.bgW_GenSolution = new System.ComponentModel.BackgroundWorker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button_OpenInMainWindow = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxGenControls = new System.Windows.Forms.GroupBox();
            this.button_ExportImage = new System.Windows.Forms.Button();
            this.ui_grid = new SudokuUI.UIgrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBoxGenControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ui_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGenSolution
            // 
            this.buttonGenSolution.Location = new System.Drawing.Point(6, 19);
            this.buttonGenSolution.Name = "buttonGenSolution";
            this.buttonGenSolution.Size = new System.Drawing.Size(161, 23);
            this.buttonGenSolution.TabIndex = 2;
            this.buttonGenSolution.Text = "Generate a solution";
            this.buttonGenSolution.UseVisualStyleBackColor = true;
            this.buttonGenSolution.Click += new System.EventHandler(this.buttonGenSolution_Click);
            // 
            // buttonGenPuzzle
            // 
            this.buttonGenPuzzle.Enabled = false;
            this.buttonGenPuzzle.Location = new System.Drawing.Point(6, 123);
            this.buttonGenPuzzle.Name = "buttonGenPuzzle";
            this.buttonGenPuzzle.Size = new System.Drawing.Size(161, 23);
            this.buttonGenPuzzle.TabIndex = 2;
            this.buttonGenPuzzle.Text = "Generate a puzzle";
            this.buttonGenPuzzle.UseVisualStyleBackColor = true;
            this.buttonGenPuzzle.Click += new System.EventHandler(this.buttonGenPuzzle_Click);
            // 
            // bgW_GenSolution
            // 
            this.bgW_GenSolution.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgW_GenSolution_DoWork);
            this.bgW_GenSolution.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgW_GenSolution_RunWorkerCompleted);
            // 
            // listBox1
            // 
            this.listBox1.Enabled = false;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Very easy",
            "Easy",
            "Medium",
            "Hard",
            "Extreme"});
            this.listBox1.Location = new System.Drawing.Point(6, 48);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(161, 69);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(6, 19);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(155, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save this sudoku";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Enabled = false;
            this.progressBar1.Location = new System.Drawing.Point(12, 291);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(462, 28);
            this.progressBar1.TabIndex = 4;
            // 
            // button_OpenInMainWindow
            // 
            this.button_OpenInMainWindow.Enabled = false;
            this.button_OpenInMainWindow.Location = new System.Drawing.Point(6, 48);
            this.button_OpenInMainWindow.Name = "button_OpenInMainWindow";
            this.button_OpenInMainWindow.Size = new System.Drawing.Size(155, 23);
            this.button_OpenInMainWindow.TabIndex = 2;
            this.button_OpenInMainWindow.Text = "Open in main window";
            this.button_OpenInMainWindow.UseVisualStyleBackColor = true;
            this.button_OpenInMainWindow.Click += new System.EventHandler(this.button_OpenInMainWindow_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_ExportImage);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.button_OpenInMainWindow);
            this.groupBox1.Location = new System.Drawing.Point(301, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 106);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Saving and exporting";
            // 
            // groupBoxGenControls
            // 
            this.groupBoxGenControls.Controls.Add(this.buttonGenSolution);
            this.groupBoxGenControls.Controls.Add(this.buttonGenPuzzle);
            this.groupBoxGenControls.Controls.Add(this.listBox1);
            this.groupBoxGenControls.Location = new System.Drawing.Point(301, 12);
            this.groupBoxGenControls.Name = "groupBoxGenControls";
            this.groupBoxGenControls.Size = new System.Drawing.Size(173, 152);
            this.groupBoxGenControls.TabIndex = 6;
            this.groupBoxGenControls.TabStop = false;
            this.groupBoxGenControls.Text = "Generator Controls";
            // 
            // button_ExportImage
            // 
            this.button_ExportImage.Enabled = false;
            this.button_ExportImage.Location = new System.Drawing.Point(6, 77);
            this.button_ExportImage.Name = "button_ExportImage";
            this.button_ExportImage.Size = new System.Drawing.Size(155, 23);
            this.button_ExportImage.TabIndex = 3;
            this.button_ExportImage.Text = "Export as image";
            this.button_ExportImage.UseVisualStyleBackColor = true;
            this.button_ExportImage.Click += new System.EventHandler(this.button_ExportImage_Click);
            // 
            // ui_grid
            // 
            this.ui_grid.AllowUserToAddRows = false;
            this.ui_grid.AllowUserToDeleteRows = false;
            this.ui_grid.AllowUserToResizeColumns = false;
            this.ui_grid.AllowUserToResizeRows = false;
            this.ui_grid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.ui_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ui_grid.ColumnHeadersVisible = false;
            this.ui_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ui_grid.DefaultCellStyle = dataGridViewCellStyle1;
            this.ui_grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ui_grid.Font = new System.Drawing.Font("Verdana", 9F);
            this.ui_grid.GridColor = System.Drawing.Color.Black;
            this.ui_grid.Location = new System.Drawing.Point(12, 12);
            this.ui_grid.MultiSelect = false;
            this.ui_grid.Name = "ui_grid";
            this.ui_grid.ReadOnly = true;
            this.ui_grid.RowHeadersVisible = false;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
            this.ui_grid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.ui_grid.RowTemplate.Height = 30;
            this.ui_grid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ui_grid.Size = new System.Drawing.Size(273, 273);
            this.ui_grid.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "1";
            this.Column1.MinimumWidth = 30;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 30;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.HeaderText = "2";
            this.Column2.MinimumWidth = 30;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 30;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.HeaderText = "3";
            this.Column3.MinimumWidth = 30;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 30;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.HeaderText = "4";
            this.Column4.MinimumWidth = 30;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 30;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column5.HeaderText = "5";
            this.Column5.MinimumWidth = 30;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 30;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column6.HeaderText = "6";
            this.Column6.MinimumWidth = 30;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 30;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column7.HeaderText = "7";
            this.Column7.MinimumWidth = 30;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Width = 30;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column8.HeaderText = "8";
            this.Column8.MinimumWidth = 30;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column8.Width = 30;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column9.HeaderText = "9";
            this.Column9.MinimumWidth = 30;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column9.Width = 30;
            // 
            // SudokuGenerator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(486, 331);
            this.Controls.Add(this.groupBoxGenControls);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.ui_grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SudokuGenerator";
            this.Text = "Sudoku Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBoxGenControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ui_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public UIgrid ui_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button buttonGenSolution;
        private System.Windows.Forms.Button buttonGenPuzzle;
        private System.ComponentModel.BackgroundWorker bgW_GenSolution;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button_OpenInMainWindow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_ExportImage;
        private System.Windows.Forms.GroupBox groupBoxGenControls;
    }
}