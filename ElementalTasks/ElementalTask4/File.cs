using System;
using System.IO;

namespace ElementalTask4
{
    class File
    {
        public int CountStringPatternInFile(string file, string pattern)
        {
            int countEntry = 0;
            using (StreamReader reader = new StreamReader(file))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    int startIndex = 0;
                    do
                    {
                        startIndex = line.IndexOf(pattern, startIndex);
                        if (startIndex > -1)
                        {
                            countEntry++;
                            startIndex = Math.Min(++startIndex, line.Length);
                        }
                    } while (startIndex > -1);
                }
            }
            return countEntry;
        }


        public int ReplaceStringPatternInFile(string file, string pattern, string replacement)
        {
            int countEntry = 0;
            string tempFileName = "temp.txt";

            using (StreamWriter writer = new StreamWriter(tempFileName))
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        int startIndex = 0;
                        do
                        {
                            startIndex = line.IndexOf(pattern, startIndex);
                            if (startIndex > -1)
                            {
                                countEntry++;
                                startIndex = Math.Min(++startIndex, line.Length);
                            }
                        } while (startIndex > -1);

                        line = line.Replace(pattern, replacement);
                        writer.WriteLine(line);
                    }
                }
            }

            try
            {
                if (countEntry > 0)  System.IO.File.Replace(tempFileName, file, null);
            }
            catch
            {
                Console.WriteLine("Can't save");
            }
            return countEntry;
        }
    }
}
