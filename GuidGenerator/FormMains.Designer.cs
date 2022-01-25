namespace GuidGenerator
{
    partial class FormMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreate = new System.Windows.Forms.Button();
            this.nudCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxGuids = new System.Windows.Forms.ListBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.cbxFormat = new System.Windows.Forms.ComboBox();
            this.chbRemoveCopied = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.Location = new System.Drawing.Point(798, 48);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(120, 43);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // nudCount
            // 
            this.nudCount.Location = new System.Drawing.Point(98, 18);
            this.nudCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCount.Name = "nudCount";
            this.nudCount.Size = new System.Drawing.Size(156, 26);
            this.nudCount.TabIndex = 1;
            this.nudCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Format";
            // 
            // lbxGuids
            // 
            this.lbxGuids.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxGuids.FormattingEnabled = true;
            this.lbxGuids.IntegralHeight = false;
            this.lbxGuids.ItemHeight = 20;
            this.lbxGuids.Location = new System.Drawing.Point(18, 111);
            this.lbxGuids.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbxGuids.Name = "lbxGuids";
            this.lbxGuids.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxGuids.Size = new System.Drawing.Size(898, 481);
            this.lbxGuids.TabIndex = 5;
            this.lbxGuids.SelectedIndexChanged += new System.EventHandler(this.lbxGuids_SelectedIndexChanged);
            this.lbxGuids.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbxGuids_MouseDoubleClick);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Location = new System.Drawing.Point(798, 617);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(120, 43);
            this.btnCopy.TabIndex = 6;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // cbxFormat
            // 
            this.cbxFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFormat.FormattingEnabled = true;
            this.cbxFormat.Location = new System.Drawing.Point(98, 58);
            this.cbxFormat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxFormat.Name = "cbxFormat";
            this.cbxFormat.Size = new System.Drawing.Size(658, 28);
            this.cbxFormat.TabIndex = 7;
            // 
            // chbRemoveCopied
            // 
            this.chbRemoveCopied.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chbRemoveCopied.AutoSize = true;
            this.chbRemoveCopied.Checked = true;
            this.chbRemoveCopied.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbRemoveCopied.Location = new System.Drawing.Point(18, 605);
            this.chbRemoveCopied.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbRemoveCopied.Name = "chbRemoveCopied";
            this.chbRemoveCopied.Size = new System.Drawing.Size(266, 24);
            this.chbRemoveCopied.TabIndex = 8;
            this.chbRemoveCopied.Text = "Remove selected guid after copy";
            this.chbRemoveCopied.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 678);
            this.Controls.Add(this.chbRemoveCopied);
            this.Controls.Add(this.cbxFormat);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.lbxGuids);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudCount);
            this.Controls.Add(this.btnCreate);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(949, 708);
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuidGenerator";
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.NumericUpDown nudCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbxGuids;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.ComboBox cbxFormat;
        private System.Windows.Forms.CheckBox chbRemoveCopied;
    }
}

