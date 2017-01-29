using System;
using System.Collections.Generic;
using System.Linq;

namespace SudokuSolver.Models
{
    public class Cell
    {
        private ICollection<int> availableOptions = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        private int? entry = null;

        /// <summary>
        /// A cell which holds its own entry value and available options for entries.
        /// </summary>
        /// <param name="entry">The entry for the cell. Optional</param>
        /// <param name="availableOptions">The available options for the cell. Optional</param>
        public Cell(int? entry = null, ICollection<int> availableOptions = default(List<int>))
        {
            Entry = entry;
            AvailableOptions = availableOptions ?? new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        }

        /// <summary>
        /// Removes the option from the cell
        /// </summary>
        /// <param name="option">The option to remove</param>
        public void RemoveOption(int option)
        {
            AvailableOptions.Remove(option);
        }

        #region Properties

        /// <summary>
        /// The available options for the cell
        /// </summary>
        public ICollection<int> AvailableOptions
        {
            get
            {
                return availableOptions;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Available Options can not be null");
                }
                if (value.Count > 9)
                {
                    throw new ArgumentException("Available Options can not have more than 9 options");
                }

                if (value.Where(ao => ao > 9 || ao < 1).Any())
                {
                    throw new ArgumentException("Available Options values have to be in the range of 1 to 9");
                }

                availableOptions = value;
            }
        }

        /// <summary>
        /// The entry for the cell
        /// </summary>
        public int? Entry
        {
            get
            {
                return entry;
            }
            set
            {
                if (value > 9)
                {
                    throw new ArgumentException("Entry can not be greater than 9");
                }
                if (value < 1)
                {
                    throw new ArgumentException("Entry can not be less than 1");
                }

                entry = value;
            }
        }

        #endregion Properties
    }
}