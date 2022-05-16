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

        public ResultsForm(Dictionary<string, float> resultsDictionary)
        {
            InitializeComponent();
            scoreEntries = resultsDictionary;
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int universitiesAmountToShow = 5;
            int j = 0;
            foreach (var scoreEntry in scoreEntries)
            {
                if (j == universitiesAmountToShow)
                {
                    break;
                }
                else
                {
                    listBox1.Items.Add($"Напрям: {scoreEntry.Key} Точність: {scoreEntry.Value * 100}%");
                    j++;
                }
            }
        }
    }
}
