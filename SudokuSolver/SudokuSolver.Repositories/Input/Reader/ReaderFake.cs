using System;
using System.Collections.Generic;
using System.IO;

using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver.Repositories.Input.Reader
{
    public class ReaderFake : IReader
    {
        IDictionary<string, string> stringDict = new Dictionary<string, string>();

        public ReaderFake()
        {
            stringDict.Add("file1", "file1\r\n");
            stringDict.Add("file2", "file2\r\n");
        }

        public StreamReader OpenFile(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                throw new ArgumentException("File name can't be empty");
            }

            if (!stringDict.ContainsKey(fileName))
            {
                throw new IOException("Unable to find file");
            }

            string stringStreamer = stringDict[fileName];

            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(stringStreamer);
            writer.Flush();
            stream.Position = 0;

            return new StreamReader(stream);
        }
    }
}
