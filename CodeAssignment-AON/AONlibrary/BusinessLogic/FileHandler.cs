using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AONLibrary.BusinessLogic
{
    /// <summary>
    /// Purpose is to handle file operations
    /// </summary>
    public static class FileHandler
    {
        /// <summary>
        /// validates and manipulates file operations
        /// </summary>
        /// <param name="path"></param>
        public static void ManipulateFile(string path)
        {
            string[] lines = System.IO.File.ReadAllLines(path);
            using (StreamWriter file = new StreamWriter(path))
            {
                HandleFileManipulator(file, lines);
            }

        }
        /// <summary>
        /// Reads file and does appropriate file operations
        /// </summary>
        /// <param name="file"></param>
        /// <param name="lines"></param>
        static void HandleFileManipulator(StreamWriter file, string[] lines)
        {
            foreach (string line in lines)
            {

                string[] parsedRecord = line.Split('	');
                try
                {
                    if (Convert.ToInt16(parsedRecord[0]) % Convert.ToInt16(parsedRecord[1]) == 0)
                    {
                        file.WriteLine(parsedRecord[0] + '	' + parsedRecord[1] + '	' + "Pass");
                    }
                    else if (Convert.ToInt16(parsedRecord[0]) % Convert.ToInt16(parsedRecord[1]) != 0)
                    {
                        file.WriteLine(parsedRecord[0] + '	' + parsedRecord[1] + '	' + "Fail");
                    }
                }
                catch (Exception ex)
                {
                    file.WriteLine(parsedRecord[0] + '	' + parsedRecord[1] + '	' + "Error");
                    continue;
                }
            }
        }


    }
}
