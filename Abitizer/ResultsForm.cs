using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abitizer
{
    public partial class ResultsForm : Form
    {
        private Dictionary<string, float> scoreEntries;
        private int universitiesAmountToShow = 5;

        public ResultsForm(Dictionary<string, float> resultsDictionary)
        {
            InitializeComponent();
            scoreEntries = resultsDictionary;
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < universitiesAmountToShow; i++)
            {
                var result = scoreEntries.ElementAtOrDefault(i);
                resultBox.Controls.Add(new FacultyBox(result, i));
            }            
        }
    }
}
