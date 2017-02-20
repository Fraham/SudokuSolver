using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver.Repositories.Input.HTML
{
    public class HTMLClient : IHTMLClient
    {
        public string GetHTML(string stringUrl)
        {
            if (string.IsNullOrWhiteSpace(stringUrl))
            {
                throw new ArgumentException("URL is not valid");
            }

            Uri url = new Uri(stringUrl);

            WebClient client = new WebClient();

            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

            Stream data = client.OpenRead(url);
            StreamReader reader = new StreamReader(data);
            return reader.ReadToEnd();
        }
    }
}
