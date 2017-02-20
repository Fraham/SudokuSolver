using Microsoft.VisualBasic.FileIO;
using SudokuSolver.Repositories.Input.Reader;
using System;
using System.Collections.Generic;

namespace SudokuSolver.Repositories.Input.CSV
{
    public class Reader : IInput
    {
        public int[] GetGrid(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName) || !fileName.EndsWith(".csv"))
            {
                throw new ArgumentException("File name should end with .csv");
            }

            var numbers = new List<int>();

            using (TextFieldParser parser = new TextFieldParser(ReaderFactory.GetReader().OpenFile(fileName)))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    foreach (string field in fields)
                    {
                        numbers.Add(int.Parse(field));
                    }
                }
            }

            return numbers.ToArray();
        }
    }
}
