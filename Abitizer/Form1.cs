using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ML;
using Microsoft.ML.Data;
using static Abitizer.AbitizerMLModel;

namespace Abitizer
{
    public partial class Form1 : Form
    {
        private MLContext mlContext;
        private ITransformer transformer;
        private PredictionEngine<ModelInput, ModelOutput> predictionEngine;

        public Form1()
        {
            InitializeComponent();
            mlContext = new MLContext();
            transformer = mlContext.Model.Load("AbitizerMLModel.zip", out _);
            predictionEngine = mlContext.Model
                .CreatePredictionEngine<ModelInput, ModelOutput>(transformer);
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            AbitizerMLModel.ModelInput sampleData = new AbitizerMLModel.ModelInput()
            {
                Certificate = (float)schoolNUD.Value,
                Ukrainian = (float)ukrNUD.Value,
                Math = (float)mathNUD.Value,
                History = (float)histiryNUD.Value,
                Geography = (float)geographyNUD.Value,
                English = (float)englishNUD.Value,
                OtherForeignLang = (float)foreignNUD.Value,
                Physics = (float)physicsNUD.Value,
                Biology = (float)biologyNUD.Value,
                Chemistry = (float)chemestryNUD.Value,
            };

            var predictionResult = AbitizerMLModel.Predict(sampleData);

            Dictionary<string, float> scoreEntries = GetScoresWithLabelsSorted(predictionEngine.OutputSchema, "Score", predictionResult.Score);
            
            ResultsForm resultsForm = new ResultsForm(scoreEntries);
            resultsForm.Show();
        }

        private static Dictionary<string, float> GetScoresWithLabelsSorted(DataViewSchema schema, string name, float[] scores)
        {
            Dictionary<string, float> result = new Dictionary<string, float>();

            var column = schema.GetColumnOrNull(name);

            var slotNames = new VBuffer<ReadOnlyMemory<char>>();
            column.Value.GetSlotNames(ref slotNames);
            var names = new string[slotNames.Length];
            var num = 0;
            foreach (var denseValue in slotNames.DenseValues())
            {
                result.Add(denseValue.ToString(), scores[num++]);
            }

            return result.OrderByDescending(c => c.Value).ToDictionary(i => i.Key, i => i.Value);
        }
    }
}
