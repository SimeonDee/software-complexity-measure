using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AutoSoftwareComplexityMeasurementApp
{
    public partial class FrmMainPage : Form
    {
        HalsteadMetrics halsteadMetrics;
        CyclomaticComplexityMetrics cyclomaticComplexityMetrics;
        SLOCMetrics slocMetrics;

        String filePath = String.Empty;
        String fileContent = String.Empty;

        public FrmMainPage()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "C Source Files (*.c) | *.c | All files (*.*) | *.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Geting filepath 
                    filePath = openFileDialog.FileName;

                    // Reading content
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                        rtbSourceCode.Text = fileContent;
                        txtFilePath.Text = filePath;
                        btnAnalyze.Enabled = true;
                    }
                }
                // DialogResult source_code_filename = openFileDialog1.ShowDialog(this);
                // Get the path of the file
            }
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            string sourceCode = rtbSourceCode.Text;
            Point defaultLocation = new Point(10, 10);
            pnlAnalysisResults.Controls.Clear();

            if (!string.IsNullOrEmpty(sourceCode)) { // if sourceCode not empty
                if (radHalsteadMetric.Checked == true)
                {
                    lblMetricResultsHeader.Text = "Halstead Complexity Results";
                    calculateHalsteadComplexities(sourceCode, location: defaultLocation);
                }
                else if (radSLOCMetric.Checked == true)
                {
                    lblMetricResultsHeader.Text = "SLOC Complexity Results";
                    calculateSLOCComplexities(sourceCode, defaultLocation);
                }
                else if (radMcCabeMetric.Checked == true)
                {
                    lblMetricResultsHeader.Text = "McCabe's Cyclomatic Complexity Results";
                    calculateCyclomaticComplexity(sourceCode, defaultLocation);
                }
                else
                {
                    lblMetricResultsHeader.Text = "All Metrics Complexity Results";
                    calculateAllComplexities(sourceCode);
                }
                
            } 
            else {
                MessageBox.Show(
                    this,
                    "No source code typed nor loaded. Please type the source codes or load a c-source code file",
                    "No Source Code",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                rtbSourceCode.Focus();
            }
        }

        public void calculateHalsteadComplexities(string sourceCode, Point location) 
        {
            halsteadMetrics = new HalsteadMetrics(sourceCode);

            int distinctOperators = halsteadMetrics.CalculateDistinctOperators();
            int totalOperators = halsteadMetrics.CalculateTotalOperators();
            int distinctOperands = halsteadMetrics.CalculateDistinctOperands();
            int totalOperands = halsteadMetrics.CalculateTotalOperands();

            double programVocabulary = halsteadMetrics.CalculateProgramVocabulary();
            double programLength = halsteadMetrics.CalculateProgramLength();
            double programVolume = halsteadMetrics.CalculateVolume();
            double programTime = halsteadMetrics.CalculateTime();
            double programBugs = halsteadMetrics.CalculateBugs();

            double effort = halsteadMetrics.CalculateEffort();
            double difficulty = halsteadMetrics.CalculateDifficulty();


            Dictionary<string, dynamic> halsteadResults = new Dictionary<string, dynamic>();
            halsteadResults.Add("Distinct Operators", distinctOperators);
            halsteadResults.Add("Distinct Operands", distinctOperands);
            halsteadResults.Add("Total Operators", totalOperators);
            halsteadResults.Add("Total Operands", totalOperands);

            halsteadResults.Add("Program Vocabulary", programVocabulary);
            halsteadResults.Add("Program Length", programLength);
            halsteadResults.Add("Program Volume", programVolume);
            halsteadResults.Add("Program Time", programTime);
            halsteadResults.Add("Program Bugs", programBugs);

            halsteadResults.Add("Effort", effort);
            halsteadResults.Add("Difficulty", difficulty);

            showResultsTable(resultProperties: halsteadResults, tableSize: new Size(400, 350), location: location);
        }

        public void calculateSLOCComplexities(string sourceCode, Point location) {
            slocMetrics = new SLOCMetrics(sourceCode);

            int totalExecutableLinesOfCode = slocMetrics.CalculateExecutableLinesOfCode();
            int totalCommentLinesOfCode = slocMetrics.CalculateCommentLinesOfCode();
            int totalBlankLinesOfCode = slocMetrics.CalculateBlankLinesOfCode();
            int totalLinesOfCode = slocMetrics.CalculateTotalLinesOfCode();
            double codeDensity = slocMetrics.CalculateCodeDensity();
            double commentDensity = slocMetrics.CalculateCommentDensity();

            Dictionary<string, dynamic> slocResults = new Dictionary<string, dynamic>();
            slocResults.Add("Total Executable Lines of Code", totalExecutableLinesOfCode);
            slocResults.Add("Total Comment Lines of Code", totalCommentLinesOfCode);
            slocResults.Add("Total Blank Lines of Code", totalBlankLinesOfCode);
            slocResults.Add("Total Lines of Code", totalLinesOfCode);
            slocResults.Add("Code Density", codeDensity);
            slocResults.Add("Comment Density", commentDensity);

            showResultsTable(resultProperties: slocResults, tableSize: new Size(400, 200), location:location);
        }

        public void calculateCyclomaticComplexity(string sourceCode, Point location) {
            cyclomaticComplexityMetrics = new CyclomaticComplexityMetrics(sourceCode);

            int essentialComplexity = cyclomaticComplexityMetrics.CalculateEssentialComplexity();
            int cognitiveComplexity = cyclomaticComplexityMetrics.CalculateCognitiveComplexity();
            int cyclomaticComplexity = cyclomaticComplexityMetrics.CalculateCyclomaticComplexity();

            Dictionary<string, dynamic> cyclomaticResults = new Dictionary<string, dynamic>();
            cyclomaticResults.Add("Essential Complexity Score", essentialComplexity);
            cyclomaticResults.Add("Cognitive Complexity Score", cognitiveComplexity);
            cyclomaticResults.Add("Cyclomatic Complexity Score", cyclomaticComplexity);

            showResultsTable(resultProperties: cyclomaticResults, tableSize: new Size(400, 100), location: location);
        }

        public void showResultsTable(Dictionary<string, dynamic> resultProperties, Size tableSize, Point location)
        {

            int totalRows = resultProperties.Count;

            // Create TableLayoutpanel
            TableLayoutPanel resultsTable = new TableLayoutPanel
            {
                Size = tableSize,
                Location = location,
                ColumnCount = 2,
                RowCount = totalRows,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Single,
                BackColor=Color.Black,
                ForeColor=Color.White
            };

            // Setting column widths
            resultsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            resultsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

            // Setting row heights
            for (int i = 0; i < totalRows; i++) {
                resultsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            }

            // Add labels i.e. result properties and values
            int rowCounter = 0;
            foreach (var result in resultProperties) {
                // Property
                resultsTable.Controls.Add(new Label { 
                    Text = result.Key, Dock = DockStyle.Fill, 
                    TextAlign=ContentAlignment.MiddleLeft,
                    Font = new Font("Arial", 15, FontStyle.Bold, GraphicsUnit.Pixel),
                    BackColor = Color.Black,
                    ForeColor = Color.White,
                }, 0, rowCounter);

                // Value
                resultsTable.Controls.Add(new Label { 
                    Text = result.Value.ToString(), Dock = DockStyle.Fill, 
                    TextAlign = ContentAlignment.MiddleLeft,
                    Font = new Font("Arial", 15, FontStyle.Bold, GraphicsUnit.Pixel),
                    BackColor=Color.Black,
                    ForeColor=Color.White,
                }, 1, rowCounter);
                
                rowCounter++;
            }

            // Adding TableLayout to panel
            pnlAnalysisResults.Controls.Add(resultsTable);

        }

        public void calculateAllComplexities(string sourceCode) {
            Point newLocation = new Point(15, 10);

            Label cycloHeaderLbl = new Label
            {
                AutoSize = false,
                Location = newLocation,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial Black", 9, FontStyle.Bold),
                Size = new Size(481, 27),
                Text = "McCabe's Cyclomatic Complexity Results"
            };
            pnlAnalysisResults.Controls.Add(cycloHeaderLbl);

            newLocation.Y = newLocation.Y + 27 + 20;
            calculateCyclomaticComplexity(sourceCode, newLocation);

            // SLOC Results
            newLocation.Y = newLocation.Y + 100 + 20;
            Label slocHeaderLbl = new Label
            {
                AutoSize = false,
                Location = newLocation,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial Black", 9, FontStyle.Bold),
                Size = new Size(481, 27),
                Text = "SLOC Complexity Results"
            };
            pnlAnalysisResults.Controls.Add(slocHeaderLbl);

            newLocation.Y = newLocation.Y + 27 + 20;
            calculateSLOCComplexities(sourceCode, newLocation);

            // Halstead Results
            newLocation.Y = newLocation.Y + 200 + 20;
            Label halsteadHeaderLbl = new Label
            {
                AutoSize = false,
                Location = newLocation,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial Black", 9, FontStyle.Bold),
                Size = new Size(481, 27),
                Text = "Halstead Complexity Results"
            };
            pnlAnalysisResults.Controls.Add(halsteadHeaderLbl);

            newLocation.Y = newLocation.Y + 27 + 20;
            calculateHalsteadComplexities(sourceCode, newLocation);
        }
    }
}
