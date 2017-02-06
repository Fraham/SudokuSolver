﻿using SudokuSolver.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuSolver
{
    public partial class Form1 : Form
    {
        Grid grid;
        public Form1()
        {
            InitializeComponent();

            //int[] numbers = new int[] { 4, 1, 0, 0, 8, 0, 0, 2, 5, 0, 6, 0, 2, 5, 7, 0, 4, 0, 2, 7, 0, 9, 0, 0, 3, 6, 0, 0, 0, 6, 5, 7, 0, 4, 0, 2, 5, 0, 0, 0, 0, 9, 1, 8, 6, 9, 4, 1, 8, 0, 6, 0, 0, 0, 0, 0, 4, 0, 6, 2, 8, 5, 0, 7, 5, 2, 4, 0, 0, 6, 0, 0, 0, 0, 8, 0, 9, 5, 0, 7, 4 };
            int[] numbers = new int[] { 0, 0, 0, 0, 0, 0, 9, 0, 0, 0, 9, 0, 5, 0, 0, 2, 0, 1, 0, 2, 1, 0, 7, 6, 0, 0, 0, 1, 5, 0, 4, 0, 0, 0, 0, 0, 0, 6, 0, 0, 9, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 4, 5, 0, 0, 0, 1, 2, 0, 3, 8, 0, 6, 0, 7, 0, 0, 8, 0, 9, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0 };

            var cells = new List<Cell>();

            foreach (var number in numbers)
            {
                if (number != 0)
                {
                    cells.Add(new Cell(number, new List<int>()));
                }
                else
                {
                    cells.Add(new Cell(availableOptions: new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 }));
                }
            }

            grid = new Grid(cells);

            txtDisplay.Text = grid.ToString;
        }

        private void Process()
        {
            txtDisplay.Text = grid.CompleteGrid();
        }

        private void btnReduce_Click(object sender, EventArgs e)
        {
            grid.ReduceCells();
            txtDisplay.Text = grid.ToString;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            grid.ProcessCells();
            txtDisplay.Text = grid.ToString;
        }

        private void btnBigTask_Click(object sender, EventArgs e)
        {
            grid.BigTask();
            txtDisplay.Text = grid.ToString;
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            Process();
        }
    }
}
