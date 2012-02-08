using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EnvManager.Domain;
using EnvManager.Extensions;

namespace EnvManager.UI
{
    public partial class MainForm : Form
    {
        EnvVar envVar;
        Action entryAdder;
 
        public MainForm()
        {
            InitializeComponent();
            varTargetCB.SelectedIndex = 1;
        }

        private void loadB_Click(object sender, EventArgs e)
        {
            entriesFLP.Controls.Clear();
            saveB.Enabled = false;

            EnvironmentVariableTarget varTarget =
                varTargetCB.Text == "User"
                    ? EnvironmentVariableTarget.User
                    : EnvironmentVariableTarget.Machine;

            envVar = new EnvVar(varNameTB.Text, varTarget);

            var entries = envVar.GetEntries();

            if (entries == null) return;

            var niceWidth = (int) CreateGraphics().MeasureString(
                entries.MaxBy(s => s.Length),
                (System.Drawing.Font)new TextBox().Font
            )
                .Width;
            
            entryAdder = () =>
            {
                var newEntryUC = new EntryUC() { EntryWidth = niceWidth };
                newEntryUC.TextChanged += (_s, _e) => saveB.Enabled = true;
                newEntryUC.Delete += (_s, _e) => {
                    entriesFLP.Controls.Remove(newEntryUC);
                    saveB.Enabled = true;
                };
                entriesFLP.Controls.Add(newEntryUC);
            };

            var entryUCs = 
                entries.Select(s =>
                    new EntryUC()
                    {
                        Text = s,                        
                        EntryWidth = niceWidth                        
                    });

            foreach (var entryUC in entryUCs)
            {                
                entriesFLP.Controls.Add(entryUC);
                entryUC.TextChanged += (_s, _e) => saveB.Enabled = true;

                var closure = entryUC;
                entryUC.Delete += (_s, _e) => {
                    entriesFLP.Controls.Remove(closure);
                    saveB.Enabled = true;
                };
            }
        }

        private void saveB_Click(object sender, EventArgs e)
        {
            envVar.SetEntries(
                entriesFLP.Controls
                    .OfType<EntryUC>()
                    .Select(c => c.Text)
            );
        }

        private void exitB_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
                Hide();
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void addB_Click(object sender, EventArgs e)
        {
            if (entryAdder == null)
            {
                MessageBox.Show("Load environment variable first!");
                return;                
            }

            entryAdder();
        }
    }
}
