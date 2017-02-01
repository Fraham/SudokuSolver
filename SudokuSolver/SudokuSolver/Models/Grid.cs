using System;
using System.Collections.Generic;
using System.Linq;

namespace SudokuSolver.Models
{
    public class Grid
    {
        private ICollection<Column> columns;
        private ICollection<Row> rows;
        private ICollection<Block> blocks;

        public Grid(ICollection<Column> columns = default(List<Column>), ICollection<Row> rows = default(List<Row>), ICollection<Block> blocks = default(List<Block>))
        {
            Columns = columns ?? new List<Column>();
            Rows = rows ?? new List<Row>();
            Blocks = blocks ?? new List<Block>();
        }

        public Grid(ICollection<Cell> cells)
        {
            if (cells.Count != 81)
            {
                throw new ArgumentException("Wrong amount of cells for grid");
            }

            Columns = new List<Column> { new Column(1), new Column(2), new Column(3), new Column(4), new Column(5), new Column(6), new Column(7), new Column(8), new Column(9) };
            Rows = new List<Row> { new Row(1), new Row(2), new Row(3), new Row(4), new Row(5), new Row(6), new Row(7), new Row(8), new Row(9) };
            Blocks = new List<Block> { new Block(1), new Block(2), new Block(3), new Block(4), new Block(5), new Block(6), new Block(7), new Block(8), new Block(9) };

            for (int i = 0; i < cells.Count; i++)
            {
                AddCellToRow(cells.ElementAt(i), i);
                AddCellToColumn(cells.ElementAt(i), i);
                AddCellToBlock(cells.ElementAt(i), i);
            }
        }

        private void AddCellToRow(Cell cell, int index)
        {
            int rowIndex;
            if (index < 9)
            {
                rowIndex = 0;
            }
            else if (index < 18)
            {
                rowIndex = 1;
            }
            else if (index < 27)
            {
                rowIndex = 2;
            }
            else if (index < 36)
            {
                rowIndex = 3;
            }
            else if (index < 45)
            {
                rowIndex = 4;
            }
            else if (index < 54)
            {
                rowIndex = 5;
            }
            else if (index < 63)
            {
                rowIndex = 6;
            }
            else if (index < 72)
            {
                rowIndex = 7;
            }
            else if (index < 81)
            {
                rowIndex = 8;
            }
            else
            {
                rowIndex = 9;
            }

            Rows.ElementAt(rowIndex).AddCell(cell);
        }

        private void AddCellToColumn(Cell cell, int index)
        {
            Columns.ElementAt(index % 9).AddCell(cell);
        }

        private void AddCellToBlock(Cell cell, int index)
        {
            var rowIndex = Rows.ToList().IndexOf(Rows.First(r => r.Cells.Contains(cell)));
            var columnIndex = Columns.ToList().IndexOf(Columns.First(r => r.Cells.Contains(cell)));

            int blockIndex;

            if (rowIndex < 3)
            {
                if (columnIndex < 3)
                {
                    blockIndex = 0;
                }
                else if (columnIndex < 6)
                {
                    blockIndex = 1;
                }
                else
                {
                    blockIndex = 2;
                }
            }
            else if (rowIndex < 6)
            {
                if (columnIndex < 3)
                {
                    blockIndex = 1;
                }
                else if (columnIndex < 6)
                {
                    blockIndex = 2;
                }
                else
                {
                    blockIndex = 3;
                }
            }
            else
            {
                if (columnIndex < 3)
                {
                    blockIndex = 4;
                }
                else if (columnIndex < 6)
                {
                    blockIndex = 5;
                }
                else
                {
                    blockIndex = 6;
                }
            }

            Blocks.ElementAt(blockIndex).AddCell(cell);
        }

        public ICollection<Column> Columns
        {
            get
            {
                return columns;
            }

            set
            {
                columns = value;
            }
        }

        public ICollection<Row> Rows
        {
            get
            {
                return rows;
            }

            set
            {
                rows = value;
            }
        }

        public ICollection<Block> Blocks
        {
            get
            {
                return blocks;
            }

            set
            {
                blocks = value;
            }
        }
    }
}
