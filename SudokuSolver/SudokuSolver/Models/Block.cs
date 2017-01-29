﻿using SudokuSolver.Interfaces;
using System;
using System.Collections.Generic;

namespace SudokuSolver.Models
{
    public class Block : ICellCollection
    {
        private ICollection<Cell> cells = new List<Cell>();
        private int number;

        public Block(int number, ICollection<Cell> cells = default(List<Cell>))
        {
            Cells = cells ?? new List<Cell>();
            Number = number;
        }

        public ICollection<Cell> Cells
        {
            get
            {
                return cells;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Cells can not be null");
                }
                if (value.Count > 9)
                {
                    throw new ArgumentException("Can not have more than 9 cells");
                }

                cells = value;
            }
        }

        public int Number
        {
            get
            {
                return number;
            }

            set
            {
                if (value > 9)
                {
                    throw new ArgumentException("Number can not be greater than 9");
                }
                if (value < 1)
                {
                    throw new ArgumentException("Number can not be less than 1");
                }

                number = value;
            }
        }

        public void AddCell(Cell cell)
        {
            Cells.Add(cell);
        }
    }
}