using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SudokuSolver.Repositories.Input.HTML.WebSudoku
{
    public class Reader : IURLReader
    {
        public int[] GetGrid(string fileName)
        {
            string html = ClientFactory.GetClient().GetHTML(fileName);

            string tableHTML = Regex.Match(html, "<TABLE .*>(.*)</TABLE>").ToString();

            var rows = Regex.Matches(tableHTML, "<TR><TD([^<]*<){27}/TR>");

            return ProcesRow(rows);
        }

        private int[] ProcesRow(MatchCollection rows)
        {
            List<int> numbers = new List<int>();

            foreach (var row in rows)
            {
                var cells = Regex.Matches(row.ToString(), "<TD([^<]*<){2}/TD>");
                foreach (var number in ProcessCells(cells))
                {
                    numbers.Add(number);
                }
                
            }

            return numbers.ToArray();
        }

        private int[] ProcessCells(MatchCollection cells)
        {
            List<int> numbers = new List<int>();

            foreach (var cell in cells)
            {
                if (!cell.ToString().ToLower().Contains("value"))
                {
                    numbers.Add(0);
                }
                else
                {
                    var value = Regex.Match(cell.ToString(), "VALUE=\"([0-9])\"");
                    var value2 = Regex.Match(value.ToString(), "[0-9]");
                    numbers.Add(int.Parse(value2.ToString()));
                }
            }

            return numbers.ToArray();
        }
    }
}
