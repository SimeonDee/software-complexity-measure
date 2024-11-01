using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

/*
    Cyclomatic Complexity Metrics:

    1. Cyclomatic Complexity: Measures complexity based on conditional statements, loops, and logical operators.
    2. Essential Complexity: Simplifies cyclomatic complexity by removing redundant conditional statements.
    3. Cognitive Complexity: Considers nesting, recursion, and complexity of conditional statements for a more accurate measure.

    Additional Considerations:

    - Handle different programming languages and syntax.
    - Integrate with code analysis tools and IDEs.
    - Use thresholds to identify complex code regions:
        - Low complexity: 1-5
        - Moderate complexity: 6-10
        - High complexity: 11-20
        - Very high complexity: 21+
    - Correlate complexity with testing efforts and maintenance costs.

    Note: This implementation provides a basic cyclomatic complexity calculation.
 
 */

namespace AutoSoftwareComplexityMeasurementApp
{
    class CyclomaticComplexityMetrics
    {
        private string code;

        public CyclomaticComplexityMetrics(string code)
        {
            this.code = code;
        }

        // Cyclomatic Complexity Calculations

        public int CalculateCyclomaticComplexity()
        {
            int complexity = 1; // Base complexity

            // Conditional statements
            complexity += Regex.Matches(code, @"\b(if|else if|switch)\b").Count;

            // Loops
            complexity += Regex.Matches(code, @"\b(for|while|do)\b").Count;

            // Logical operators
            complexity += Regex.Matches(code, @"&&|\|\|").Count;

            // Case statements
            complexity += Regex.Matches(code, @"\b(case)\b").Count;

            return complexity;
        }

        public int CalculateEssentialComplexity()
        {
            // Remove redundant complexity from conditional statements
            string simplifiedCode = Regex.Replace(code, @"\belse if\b", "");

            return new CyclomaticComplexityMetrics(simplifiedCode).CalculateCyclomaticComplexity();
        }

        public int CalculateCognitiveComplexity()
        {
            // Consider nesting, recursion, and complexity of conditional statements
            int complexity = CalculateCyclomaticComplexity();

            // Nesting complexity
            complexity += Regex.Matches(code, @"\{").Count - 1;

            // Recursion complexity
            complexity += Regex.Matches(code, @"\b(recursive)\b").Count;

            return complexity;
        }

    }
}


