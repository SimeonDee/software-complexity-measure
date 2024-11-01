using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

/*
    Halstead Metrics:

    1. Distinct Operators: Unique operators in the code.
    2. Distinct Operands: Unique operands (variables, constants, literals) in the code.
    3. Total Operators: Total number of operators in the code.
    4. Total Operands: Total number of operands in the code.
    5. Program Vocabulary: Sum of distinct operators and operands.
    6. Program Length: Sum of total operators and operands.
    7. Volume: Measures program complexity.
    8. Difficulty: Measures program difficulty.
    9. Effort: Measures required effort to implement the program.
    10. Time: Estimates required time to implement the program.
    11. Bugs: Estimates potential bugs in the program.

    Note: This implementation uses regular expressions to extract operators and operands.

 */

namespace AutoSoftwareComplexityMeasurementApp
{
    class HalsteadMetrics
    {
        private string code;

        public HalsteadMetrics(string code)
        {
            this.code = code;
        }

        // Halstead Metrics Calculations

        public string[] loadCOperators() {
            // Define C operators as regular expressions
            string[] operators = new string[]
                    {
                        @"\+",      // Addition
                        @"\-",      // Subtraction
                        @"\*",      // Multiplication
                        @"\/",      // Division
                        @"%",      // Modulus
                        @"=",      // Assignment
                        @"==",     // Equality
                        @"!=",     // Inequality
                        @">",      // Greater than
                        @"<",      // Less than
                        @">=",     // Greater than or equal
                        @"<=",     // Less than or equal
                        @"!",      // Logical NOT
                        @"&&",     // Logical AND
                        @"\|\|",   // Logical OR
                        @"&",      // Bitwise AND
                        @"\^",     // Bitwise XOR
                        @"|",      // Bitwise OR
                        @"~",      // Bitwise NOT
                        @"<<",     // Left shift
                        @">>",     // Right shift
                        @"\?",     // Ternary operator
                        @":",      // Colon
                        @"\.",     // Dot
                        @"->",     // Arrow
                        @"\[",     // Left square bracket
                        @"\]",     // Right square bracket
                        @"\(",     // Left parenthesis
                        @"\)",     // Right parenthesis
                        @"\{",     // Left curly bracket
                        @"\}",     // Right curly bracket
                        @",",      // Comma
                        @";",      // Semicolon
                    };

            return operators;
        }

        public string[] loadCOperandPatterns() { 
            // Regular expression patterns to match valid C operands
            string keywordPattern = @"\b(auto|break|case|char|const|continue|default|do|double|
                                        else|enum|extern|float|for|goto|if|int|long|register|return|
                                        short|signed|sizeof|static|struct|switch|typedef|union|unsigned|
                                        void|volatile|while)\b";
            string identifierPattern = @"\b[a-zA-Z_][a-zA-Z0-9_]*\b";
            string integerConstantPattern = @"\b[0-9]+(u|U|l|L|ul|UL|lu|LU)?\b";
            string characterConstantPattern = @"'[^']*'";
            string stringLiteralPattern = @"""[^""]*""";
            string floatingPointConstantPattern = @"\b[0-9]+(\.[0-9]+)?(e[+-]?[0-9]+)?(f|F|l|L)?\b";

            string[] patterns = { keywordPattern, identifierPattern, 
                                    integerConstantPattern, characterConstantPattern, 
                                    stringLiteralPattern, floatingPointConstantPattern };

            return patterns;
        }
        
        public int CalculateDistinctOperators()
        {
            string[] operators = loadCOperators();
            int distinctOperators = operators.Count(op => Regex.Matches(code, op).Count != 0);

            return distinctOperators;
        }

        public int CalculateDistinctOperands()
        {
            // Operands: variables, constants, literals
            string[] operandPatterns = loadCOperandPatterns();

            var matches = new System.Collections.Generic.List<string>();
            foreach (string pattern in operandPatterns)
            {
                matches.AddRange(Regex.Matches(code, pattern).Cast<Match>().Select(m => m.Value));
            }

            return matches.Distinct().Count();

        }

        public int CalculateTotalOperators()
        {
            string[] operators = loadCOperators();
            int count = 0;

            // Iterating over each operator
            foreach (string op in operators)
            {
                // Using Regex to count occurrences of the operator
                count += Regex.Matches(code, op).Count;
            }

            return count;
            
        }

        public int CalculateTotalOperands()
        {
            string[] operandPatterns = loadCOperandPatterns();

            int count = 0;
            foreach (string pattern in operandPatterns)
            {
                count += Regex.Matches(code, pattern).Count;
            }

            return count;
        }

        public double CalculateProgramVocabulary()
        {
            return Math.Round((double) CalculateDistinctOperators() + CalculateDistinctOperands(), 2);
        }

        public double CalculateProgramLength()
        {
            return Math.Round((double) CalculateTotalOperators() + CalculateTotalOperands(), 2);
        }

        public double CalculateVolume()
        {
            return Math.Round(CalculateProgramLength() * Math.Log(CalculateProgramVocabulary(), 2), 2);
        }

        public double CalculateDifficulty()
        {
            return Math.Round((CalculateDistinctOperators() / 2.0) * (CalculateTotalOperands() / (double) CalculateDistinctOperands()), 2);
        }

        public double CalculateEffort()
        {
            return Math.Round(CalculateDifficulty() * CalculateVolume(), 2);
        }

        public double CalculateTime()
        {
            return Math.Round(CalculateEffort() / 18.0, 2);
        }

        public double CalculateBugs()
        {
            return Math.Round(Math.Pow(CalculateVolume(), 2.0 / 3.0) / 3000.0, 2);
        }

    }
}
