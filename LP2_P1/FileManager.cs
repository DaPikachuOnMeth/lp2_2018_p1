using System.IO;
using System;

namespace LP2_P1
{
    /// <summary>
    /// Handles reading the file.
    /// </summary>
    class FileManager
    {
        string path;
        internal string[] list;

        public FileManager(string path)
        {
            if (path.Length == 0)
            {
                path = "Games.csv";
            }
            else { this.path = path; }

            list = File.ReadAllLines(path);
        }

        public string[] SplitLine(string str)
        {
            string[] data = str.Split(','); //splits string
            return data;
        }
    }
}