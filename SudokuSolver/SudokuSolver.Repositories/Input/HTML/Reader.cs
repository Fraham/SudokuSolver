using System;
using System.Collections.Generic;
using System.Linq;

namespace SudokuSolver.Repositories.Input.HTML
{
    public class Reader : IInput
    {
        private IEnumerable<string> avaiableWebsites = new List<string> { "" };

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

            throw new NotImplementedException();
        }
    }
}
