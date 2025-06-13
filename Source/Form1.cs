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
            // Replace underscores with spaces
            string rawNames = txtNames.Text.Replace("_", " ");
            string[] names = rawNames.Split(',');
            string[] lines = rbChatlog.Lines;

            List<string> filtered = new List<string>();
            foreach (string line in lines)
            {
                foreach (string name in names)
                {
                    if (line.Contains(name.Trim()))
                    {
                        string processedLine = cbTimestamp.Checked && line.Length > 11
                            ? line.Substring(11)
                            : line;

                        filtered.Add(processedLine);
                        break;
                    }
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
