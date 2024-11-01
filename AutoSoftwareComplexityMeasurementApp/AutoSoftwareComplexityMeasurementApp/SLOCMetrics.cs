using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

/*
    SLOC Metrics:

    1. Total Lines of Code (TLOC): Total number of lines in the code.
    2. Executable Lines of Code (ELOC): Lines containing executable code.
    3. Comment Lines of Code (CLOC): Lines containing comments.
    4. Blank Lines of Code (BLOC): Empty lines.
    5. Code Density: Ratio of executable lines to total lines.
    6. Comment Density: Ratio of comment lines to total lines.
*/

// Note: This implementation assumes C#-style comments (`//` and `/* */`).

namespace AutoSoftwareComplexityMeasurementApp
{
    class SLOCMetrics
    {
        private string code;

        public SLOCMetrics(string code)
        {
            this.code = code;
        }

        // SLOC Metrics Calculations

        public int CalculateTotalLinesOfCode()
        {
            return code.Split('\n').Length;
        }

        public int CalculateExecutableLinesOfCode()
        {
            string[] lines = code.Split('\n');
            int count = 0;

            foreach (string line in lines)
            {
                if (!string.IsNullOrWhiteSpace(line) && !line.Trim().StartsWith("//") && !line.Trim().StartsWith("/*") && !line.Trim().StartsWith("*"))
                {
                    count++;
                }
            }

            return count;
        }

        public int CalculateCommentLinesOfCode()
        {
            string[] lines = code.Split('\n');
            int count = 0;

            foreach (string line in lines)
            {
                if (line.Trim().StartsWith("//") || line.Trim().StartsWith("/*") || line.Trim().StartsWith("*"))
                {
                    count++;
                }
            }

            return count;
        }

        public int CalculateBlankLinesOfCode()
        {
            string[] lines = code.Split('\n');
            int count = 0;

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    count++;
                }
            }

            return count;
        }

        public double CalculateCodeDensity()
        {
            return Math.Round((double) CalculateExecutableLinesOfCode() / CalculateTotalLinesOfCode(), 2);
        }

        public double CalculateCommentDensity()
        {
            return Math.Round((double)CalculateCommentLinesOfCode() / CalculateTotalLinesOfCode(), 2);
        }
    }
}
