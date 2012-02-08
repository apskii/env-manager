using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnvManager.UI
{
    public partial class EntryUC : UserControl
    {
        public EntryUC()
        {
            InitializeComponent();
            Delete += (s, e) => { };
        }

        public new string Text
        {
            get { return entryTB.Text; }
            set { entryTB.Text = value; }
        }

        public int EntryWidth
        {
            get { return entryTB.Width; }
            set
            {
                var diff = (int)value - entryTB.Width;
                Width += diff;
                entryTB.Width = value;
            }
        }

        public event EventHandler Delete;

        private void deleteB_Click(object sender, EventArgs e)
        {
            Delete(this, e);
        }

        private void entryTB_Enter(object sender, EventArgs e)
        {
            entryTB.BackColor = Color.LightGreen;
        }

        private void entryTB_Leave(object sender, EventArgs e)
        {
            entryTB.BackColor = Color.White;
        }

        private void entryTB_TextChanged(object sender, EventArgs e)
        {
            OnTextChanged(e);
        }

        private void browseB_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog() { SelectedPath = entryTB.Text };
            
            if (fbd.ShowDialog() == DialogResult.OK)
                entryTB.Text = fbd.SelectedPath;
        }
    }
}
