using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RCRP_CLT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
            string rawNames = txtNames.Text.Replace("_", " ");
            string[] names = rawNames.Split(',');
            string[] lines = rbChatlog.Lines;

            List<string> filtered = new List<string>();
            bool shouldIncludeNextLine = false;

            foreach (string line in lines)
            {
                bool lineHasTimestamp = line.Length >= 10 && line[0] == '[' && line[9] == ']';

                if (lineHasTimestamp)
                {
                    // Check if name is in line
                    bool matchedName = false;
                    foreach (string name in names)
                    {
                        if (line.Contains(name.Trim()))
                        {
                            matchedName = true;
                            break;
                        }
                    }

                    if (matchedName)
                    {
                        string processedLine = cbTimestamp.Checked && line.Length > 11
                            ? line.Substring(11)
                            : line;

                        filtered.Add(processedLine);
                        shouldIncludeNextLine = true;
                        continue;
                    }
                }

                // Checks if cut-off line is wrapped cause of a named player.
                if (shouldIncludeNextLine)
                {
                    string processedLine = cbTimestamp.Checked && line.Length > 11
                        ? line.Substring(11)
                        : line;

                    filtered.Add(processedLine);
                    shouldIncludeNextLine = false; // Includes only 1 wrapped line.
                }
            }

            string result = string.Join(Environment.NewLine, filtered);
            Clipboard.SetText(result);
            MessageBox.Show("Filtered text copied to clipboard!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
