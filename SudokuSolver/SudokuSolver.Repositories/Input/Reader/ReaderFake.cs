using System;
using System.Collections.Generic;
using System.IO;

namespace SudokuSolver.Repositories.Input.Reader
{
    public class ReaderFake : IReader
    {
        private IDictionary<string, string> stringDict = new Dictionary<string,string>();

        public ReaderFake()
        {
            stringDict.Add("file1", "file1" + Environment.NewLine);
            stringDict.Add("file2", "file2" + Environment.NewLine);
            stringDict.Add("csv1.csv","0,1,2,3,4,5,6,7,8,9");
            stringDict.Add("csv2.csv","0,0,0,0,0,0,9,0,0,0,9,0,5,0,0,2,0,1,0,2,1,0,7,6,0,0,0,1,5,0,4,0,0,0,0,0,0,6,0,0,9,0,0,1,0,0,0,0,0,0,1,0,4,5,0,0,0,1,2,0,3,8,0,6,0,7,0,0,8,0,9,0,0,0,3,0,0,0,0,0,0");
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