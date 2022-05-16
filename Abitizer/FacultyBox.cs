using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abitizer
{
    public partial class FacultyBox : UserControl
    {
        string searchQuery;
        public FacultyBox(KeyValuePair<string, float> result, int number)
        {
            InitializeComponent();
            specialityLabel.Text = Convert.ToString(result.Value);
            Location = new Point(0, (Size.Height + 10) * number);
            var strings = Regex.Split(result.Key, "(?=[0-9]{3})");
            uniNameLabel.Text = strings[0];
            specialityLabel.Text = strings[1];
            accuracyLabel.Text = $"{Math.Round(result.Value*100,2)}%";
            searchQuery = result.Key.Replace(" ", "+");
        }

        private void Label_Click(object sender, EventArgs e)
        {
            var label = (sender as Label);
            Clipboard.SetText(label.Text);
            toolTip.Show("Текст скопійовано!", label, 1000);
        }

        private void browserBox_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = $"https://www.google.com/search?q={searchQuery}&btnI=Im+Feeling+Lucky",
                UseShellExecute = true
            });
        }
    }
}
