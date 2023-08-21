using System.Collections.Generic;

namespace DisplayRecs
{
    public static class Helper
    {
        public static string[] ReadFileIntoArray(string filePath)
        {
            if (System.IO.File.Exists(filePath))
            {
                return System.IO.File.ReadAllLines(filePath);
            }
            else
            {
                throw new System.IO.FileNotFoundException($"File not found: {filePath}");
            }
        }

        public static List<string> ConvertArrayToList(string[] array)
        {
            return new List<string>(array);
        }
    }
}
