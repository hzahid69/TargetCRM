using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetCRM_Automation.Helpers
{
    public class DataDrivenCSV
    {
        public static IEnumerable returnsCSVData(string csvPath)
        {
            using (StreamReader sr = new StreamReader(csvPath, System.Text.Encoding.GetEncoding(1252)))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    ArrayList result = new ArrayList();
                    result.AddRange(line.Split(';'));
                    yield return result;
                }
            }
        }

        // reads a single line passed as a reference
        public static IEnumerable returnsCSVData(string csvPath, int linha)
        {
            using (StreamReader sr = new StreamReader(csvPath, System.Text.Encoding.GetEncoding(1252)))
            {
                string line;
                int count = 1;
                while ((line = sr.ReadLine()) != null)
                {
                    if (count == linha)
                    {
                        ArrayList result = new ArrayList();
                        result.AddRange(line.Split(';'));
                        yield return result;
                    }
                    count++;
                }
            }
        }

        // reads a set of lines passed as a reference
        public static IEnumerable returnsCSVData(string csvPath, int[] linha)
        {
            using (StreamReader sr = new StreamReader(csvPath, System.Text.Encoding.GetEncoding(1252)))
            {
                string line;
                int count = 1;
                while ((line = sr.ReadLine()) != null)
                {
                    foreach (int element in linha)
                    {
                        if (count == element)
                        {
                            ArrayList result = new ArrayList();
                            result.AddRange(line.Split(';'));
                            yield return result;
                        }
                    }
                    count++;
                }
            }
        }
    }
}
