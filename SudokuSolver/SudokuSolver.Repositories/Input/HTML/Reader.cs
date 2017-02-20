using System;
using System.Collections.Generic;
using System.Linq;

namespace SudokuSolver.Repositories.Input.HTML
{
    public class Reader : IInput
    {
        private IEnumerable<string> avaiableWebsites = new List<string> { "show.websudoku.com" };

        public int[] GetGrid(string stringURL)
        {
            if (string.IsNullOrWhiteSpace(stringURL))
            {
                throw new ArgumentException("URL is not valid");
            }

            Uri url = new Uri(stringURL);

            if (!avaiableWebsites.Contains(url.Host.ToLower()))
            {
                throw new ArgumentException($"{stringURL} is not supported");
            }

            return GetReader(url.Host).GetGrid(stringURL);
        }

        private IURLReader GetReader(string hostUrl)
        {
            IURLReader reader = null;
            if (hostUrl.ToLower().Equals("show.websudoku.com"))
            {
                reader = new WebSudoku.Reader();
            }

            return reader;
        }
    }
}
