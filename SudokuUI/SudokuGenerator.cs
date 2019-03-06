﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Sudoku;

namespace SudokuUI
{
    public partial class SudokuGenerator : Form
    {
        public static Font font_cell_default = new Font("Verdana", 9f);
        public static Font font_cell_bold = new Font("Verdana", 9f, FontStyle.Bold);
        Difficulty selectedDifficulty;
        public Grid internal_grid = new Grid(9);
        public Grid temp_grid;
        public List<Grid> possible_solutions;
        bool filled;

        public SudokuGenerator()
        {
            InitializeComponent();

            bgW_GenSolution.WorkerReportsProgress = true;
            bgW_GenSolution.ProgressChanged += new ProgressChangedEventHandler(ProgressUpdate);

            ui_grid.Rows.Add();
            ui_grid.Rows.Add();
            ui_grid.Rows.Add();
            ui_grid.Rows.Add();
            ui_grid.Rows.Add();
            ui_grid.Rows.Add();
            ui_grid.Rows.Add();
            ui_grid.Rows.Add();
            ui_grid.Rows.Add();
            ui_grid.RowTemplate.Height = 30;

            ui_grid.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ui_grid.GridColor = Color.Black;
            ui_grid.Font = font_cell_default;
            // apply background pattern
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if ((i < 3 || i > 5) ^ (j < 3 || j > 5)) // 3x3 checkerboard pattern
                    {
                        ui_grid[i, j].Style.BackColor = Color.DarkGray;
                    }
                }
            }
        }

        public void SetCell(Coords coords, int value)
        {
            internal_grid.Set(coords, value);
            UpdateGrid();
        }

        public void UpdateGrid() // put the values of the internal grid into the UI
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (internal_grid.Get(i, j) == 0)
                    {
                        ui_grid[j, i].Value = null;
                        MarkPremade(new Coords(i, j), false);
                    }
                    else
                    {
                        if (internal_grid.Get(i, j) < 0) // if it is a "premade" cell
                        {
                            ui_grid[j, i].Value = -internal_grid.Get(i, j);
                            MarkPremade(new Coords(i, j), true);
                        }
                        else
                        {
                            ui_grid[j, i].Value = internal_grid.Get(i, j);
                            MarkPremade(new Coords(i, j), false);
                        }
                    }
                }
            }
        }

        private void MarkPremade(Coords coords, bool isPremade)
        {
            ui_grid[coords.y, coords.x].Style.Font = isPremade ? font_cell_bold : font_cell_default; //set font weight
        }

        private void SudokuViewer_Load(object sender, EventArgs e)
        {

        }

        private void buttonGenSolution_Click(object sender, EventArgs e)
        {
            if (!bgW_GenSolution.IsBusy)
            {
                bgW_GenSolution.RunWorkerAsync(true);
            }
            listBox1.Enabled = true;
        }

        private void buttonGenPuzzle_Click(object sender, EventArgs e)
        {
            if (!bgW_GenSolution.IsBusy)
            {
                bgW_GenSolution.RunWorkerAsync(false);
            }
            buttonGenPuzzle.Enabled = false;
            listBox1.Enabled = false;
        }

        private void bgW_GenSolution_DoWork(object sender, DoWorkEventArgs e)
        {
            bool solution = (bool)e.Argument;
            if (solution)
            {
                internal_grid = new Grid(9);
                UpdateGrid();
                GenerateSolutionRecursive();
                filled = true;
            }
            else
            {
                GeneratePuzzle(selectedDifficulty);
            }
        }

        public bool GenerateSolutionRecursive()
        {
            if (!internal_grid.ContainsZeros()) // if it is fully solved
            {
                return true;
            }
            else
            {
                // find the first empty cell
                Coords emptyCell = internal_grid.GetFirstEmptyCell();

                // get all possibilities for (x, y)
                List<int> possibilities = Lib.Shuffle(internal_grid.GetAllPossibilities(emptyCell));
                foreach (int item in possibilities)
                {
                    SetCell(emptyCell, item);
                    
                    if (GenerateSolutionRecursive()) // if the next method call reports that the grid is fully solved, do the same
                    {
                        return true;
                    }
                }
                //backtrack
                SetCell(emptyCell, 0);
                return false;
            }
        }

        public void GeneratePuzzle(Difficulty difficulty)
        {
            if (!filled)
            {
                MessageBox.Show("generate a solution first.");
                return;
            }
            temp_grid = internal_grid.Clone();
            List<Coords> cells = new List<Coords>();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    cells.Add(new Coords(i, j));
                }
            }
            cells = Lib.Shuffle(cells);
            while (cells.Count > 0)
            {
                UniquenessChecker uc = new UniquenessChecker();
                int removedCellvalue = temp_grid.Get(cells[0]);
                Coords removedCell = cells[0];
                //MessageBox.Show($"cell: {removedCell.x}, {removedCell.y}: {removedCellvalue}");
                temp_grid.Set(cells[0], 0);
                cells.RemoveAt(0);
                if (!uc.Check(temp_grid))
                {
                    //MessageBox.Show($"resetting {removedCell.x}, {removedCell.y}: {removedCellvalue}");
                    temp_grid.Set(removedCell, removedCellvalue);
                }
                bgW_GenSolution.ReportProgress((81 - cells.Count) * 100 / 81);
            }

            List<Coords> emptyCells = new List<Coords>();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (temp_grid.Get(i, j) == 0)
                    {
                        emptyCells.Add(new Coords(i, j));
                    }
                }
            }
            emptyCells = Lib.Shuffle(emptyCells);
            // add a number of "hint numbers" to the grid, how many depends on the chosen difficulty
            int numbers_added = 0;
            while (numbers_added < (int)difficulty)
            {
                temp_grid.Set(emptyCells[0], internal_grid.Get(emptyCells[0])); // fill in a number from the solution
                numbers_added++;
                emptyCells.RemoveAt(0);
            }

            internal_grid = temp_grid.Clone();
            UpdateGrid();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonGenPuzzle.Enabled = true;
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    selectedDifficulty = Difficulty.very_easy;
                    break;
                case 1:
                    selectedDifficulty = Difficulty.easy;
                    break;
                case 2:
                    selectedDifficulty = Difficulty.medium;
                    break;
                case 3:
                    selectedDifficulty = Difficulty.hard;
                    break;
                case 4:
                    selectedDifficulty = Difficulty.extreme;
                    break;
                default:
                    throw new Exception();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            OpenSaveDialog();
        }

        public Grid MakePremade(Grid input)
        {
            Grid output = input.Clone();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Coords coords = new Coords(i, j);
                    output.Set(coords, -Math.Abs(output.Get(coords)));
                }
            }
            return output;
        }

        public void SaveSudokuFileAsPremade(string path)
        {
            Lib.SaveSudokuFile(MakePremade(internal_grid), path);
        }

        void OpenSaveDialog()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.InitialDirectory = Application.StartupPath;
            saveFileDialog.Filter = "sudoku files (*.sudoku)|*.sudoku|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = false;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SaveSudokuFileAsPremade(saveFileDialog.FileName);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: " + e.Message, "An error has occured");
                }
            }
        }

        void ProgressUpdate(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void bgW_GenSolution_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Value = 0;
            buttonSave.Enabled = true;
        }
    }
}
