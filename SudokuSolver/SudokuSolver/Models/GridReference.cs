using System;

namespace SudokuSolver.Models
{
    public class GridReference
    {
        private int row;
        private int column;
        private int block;

        public GridReference(int row, int column, int block)
        {
            Row = row;
            Column = column;
            Block = block;
        }

        public int Row
        {
            get
            {
                return row;
            }

            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Row value can not be below 1");
                }
                if (value > 9)
                {
                    throw new ArgumentException("Row value can not be greater than 9");
                }

                row = value;
            }
        }

        public int Column
        {
            get
            {
                return column;
            }

            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Column value can not be below 1");
                }
                if (value > 9)
                {
                    throw new ArgumentException("Column value can not be greater than 9");
                }

                column = value;
            }
        }

        public int Block
        {
            get
            {
                return block;
            }

            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Block value can not be below 1");
                }
                if (value > 9)
                {
                    throw new ArgumentException("Block value can not be greater than 9");
                }

                block = value;
            }
        }
    }
}