using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver.Repositories.Input.HTML
{
    public interface IHTMLClient
    {
        string GetHTML(string url);
    }
}
