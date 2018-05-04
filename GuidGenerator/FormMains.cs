using System;
using System.Windows.Forms;

namespace GuidGenerator
{
    public partial class FormMain : Form
    {
        #region Constructor

        public FormMain()
        {
            InitializeComponent();
            InitializeFormats();
            RefreshGuiState();
        }

        #endregion

        #region Helper

        private void InitializeFormats()
        {
            cbxFormat.DisplayMember = "Item1";

            cbxFormat.Items.Add(new Tuple<string, string>("32 digits", "N"));
            cbxFormat.Items.Add(new Tuple<string, string>("32 digits - separated by hyphens", "D"));

            cbxFormat.Items.Add(new Tuple<string, string>("32 digits - separated by hyphens, enclosed in braces", "B"));
            cbxFormat.SelectedIndex = 2;

            cbxFormat.Items.Add(new Tuple<string, string>("32 digits - separated by hyphens, enclosed in parentheses", "P"));
            cbxFormat.Items.Add(new Tuple<string, string>("Four hexadecimal values enclosed in braces, where the fourth value is a subset of eight hexadecimal values that is also enclosed in braces", "X"));
        }

        private void RefreshGuiState()
        {
            btnCopy.Enabled = lbxGuids.SelectedIndices.Count > 0;
        }

        private void CopyToClipboard()
        {
            if (lbxGuids.SelectedIndex == -1)
                return;

            Clipboard.SetText(lbxGuids.SelectedItem.ToString());

            if (chbRemoveCopied.Checked)
                lbxGuids.Items.RemoveAt(lbxGuids.SelectedIndex);

            RefreshGuiState();

            MessageBox.Show("The selected guid was copied to the clipboard.", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Control events

        private void btnCreate_Click(object sender, EventArgs e)
        {
            lbxGuids.BeginUpdate();
            lbxGuids.Items.Clear();

            var count = (int)nudCount.Value;
            for (int i = 0; i < count; i++)
            {
                var guid = Guid.NewGuid();
                var guidText = guid.ToString(((Tuple<string, string>)cbxFormat.SelectedItem).Item2);

                lbxGuids.Items.Add(guidText);
            }

            lbxGuids.SelectedIndex = 0;
            lbxGuids.EndUpdate();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            CopyToClipboard();
        }

        private void lbxGuids_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CopyToClipboard();
        }

        private void lbxGuids_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGuiState();
        }

        #endregion
    }
}