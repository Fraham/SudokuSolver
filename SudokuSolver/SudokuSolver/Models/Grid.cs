using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void ReduceCells()
        {
            foreach (var column in Columns)
            {
                column.ReduceCells();
            }

            foreach (var row in Rows)
            {
                row.ReduceCells();
            }

            foreach (var block in Blocks)
            {
                block.ReduceCells();
            }
        }

        public void BigTask()
        {
            foreach (var column in Columns)
            {
                column.ProcessSingleOptionLeftInCollection();

                ReduceCells();
            }

            foreach (var row in Rows)
            {
                row.ProcessSingleOptionLeftInCollection();

                ReduceCells();
            }

            foreach (var block in Blocks)
            {
                block.ProcessSingleOptionLeftInCollection();

                ReduceCells();
            }
        }

        public string ProcessCells()
        {
            foreach (var column in Columns)
            {
                column.ProcessCells();

                ReduceCells();
            }

            foreach (var row in Rows)
            {
                row.ProcessCells();

                ReduceCells();
            }

            foreach (var block in Blocks)
            {
                block.ProcessCells();

                ReduceCells();
            }

            return ToString;
        }

        public string AllProcesses()
        {
            foreach (var column in Columns)
            {
                column.ProcessCells();

                ReduceCells();
            }

            foreach (var row in Rows)
            {
                row.ProcessCells();

                ReduceCells();
            }

            foreach (var block in Blocks)
            {
                block.ProcessCells();

                ReduceCells();
            }

            BigTask();

            return ToString;
        }

        public string CompleteGrid()
        {
            ReduceCells();

            var repeat = Rows.Count(row => row.Cells.Count(cell => cell.AvailableOptions.Count > 0) > 0);

            var count = 0;

            while (repeat > 0 && count < 100)
            {
                AllProcesses();

                repeat = Rows.Count(row => row.Cells.Count(cell => cell.AvailableOptions.Count > 0) > 0);

                count++;
            }

            return ToString;
        }

        private void AddCellToRow(Cell cell, int index)
        {
            int rowIndex = Helper.CellFinder.GetRowNumber(index) - 1;

            Rows.ElementAt(rowIndex).AddCell(cell);
        }

        private void AddCellToColumn(Cell cell, int index)
        {
            int columnIndex = Helper.CellFinder.GetColumnNumber(index) - 1;

            Columns.ElementAt(columnIndex).AddCell(cell);
        }

        private void AddCellToBlock(Cell cell, int index)
        {
            int blockIndex = Helper.CellFinder.GetGridReference(index).Block - 1;

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

        public new string ToString
        {
            get
            {
                StringBuilder sb = new StringBuilder();

                foreach (var row in Rows)
                {
                    sb.AppendLine(row.ToString);
                }

                return sb.ToString();
            }
        }
    }
}
