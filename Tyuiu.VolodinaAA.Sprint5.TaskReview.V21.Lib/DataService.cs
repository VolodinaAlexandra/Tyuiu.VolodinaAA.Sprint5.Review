using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.VolodinaAA.Sprint5.TaskReview.V21.Lib
{
    public class DataService : ISprint5Task7V21
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = @"C:\DataSprint5\OutPutDataFileTask7V21.txt";

            FileInfo fileInfo = new FileInfo(pathSaveFile);  
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            string res = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string punctuationMarks = ",.;:*|/!?-_()";
                    foreach (char letter in line)
                    {
                        if (!punctuationMarks.Contains(letter.ToString()))
                        {
                            res += letter;
                        }
                    }
                    File.AppendAllText(pathSaveFile, res + Environment.NewLine);
                    res = "";
                }
            }
            return pathSaveFile;
        }
    }
}
