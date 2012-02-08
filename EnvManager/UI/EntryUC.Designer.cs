namespace EnvManager.UI
{
    partial class EntryUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.deleteB = new System.Windows.Forms.Button();
            this.browseB = new System.Windows.Forms.Button();
            this.entryTB = new System.Windows.Forms.TextBox();
            this.baseTLP = new System.Windows.Forms.TableLayoutPanel();
            this.baseTLP.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleteB
            // 
            this.deleteB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteB.Image = global::EnvManager.Properties.Resources.delete_16x;
            this.deleteB.Location = new System.Drawing.Point(317, 6);
            this.deleteB.MinimumSize = new System.Drawing.Size(23, 23);
            this.deleteB.Name = "deleteB";
            this.deleteB.Size = new System.Drawing.Size(23, 23);
            this.deleteB.TabIndex = 5;
            this.deleteB.UseVisualStyleBackColor = true;
            this.deleteB.Click += new System.EventHandler(this.deleteB_Click);
            // 
            // browseB
            // 
            this.browseB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.browseB.Location = new System.Drawing.Point(281, 6);
            this.browseB.MinimumSize = new System.Drawing.Size(30, 23);
            this.browseB.Name = "browseB";
            this.browseB.Size = new System.Drawing.Size(30, 23);
            this.browseB.TabIndex = 4;
            this.browseB.Text = "...";
            this.browseB.UseVisualStyleBackColor = true;
            this.browseB.Click += new System.EventHandler(this.browseB_Click);
            // 
            // entryTB
            // 
            this.entryTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.entryTB.Location = new System.Drawing.Point(3, 6);
            this.entryTB.MinimumSize = new System.Drawing.Size(111, 20);
            this.entryTB.Name = "entryTB";
            this.entryTB.Size = new System.Drawing.Size(272, 20);
            this.entryTB.TabIndex = 3;
            this.entryTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.entryTB.TextChanged += new System.EventHandler(this.entryTB_TextChanged);
            this.entryTB.Enter += new System.EventHandler(this.entryTB_Enter);
            this.entryTB.Leave += new System.EventHandler(this.entryTB_Leave);
            // 
            // baseTLP
            // 
            this.baseTLP.ColumnCount = 3;
            this.baseTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.baseTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.baseTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.baseTLP.Controls.Add(this.deleteB, 2, 0);
            this.baseTLP.Controls.Add(this.browseB, 1, 0);
            this.baseTLP.Controls.Add(this.entryTB, 0, 0);
            this.baseTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseTLP.Location = new System.Drawing.Point(0, 0);
            this.baseTLP.Name = "baseTLP";
            this.baseTLP.RowCount = 1;
            this.baseTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.baseTLP.Size = new System.Drawing.Size(343, 32);
            this.baseTLP.TabIndex = 6;
            // 
            // EntryUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.baseTLP);
            this.MinimumSize = new System.Drawing.Size(189, 31);
            this.Name = "EntryUC";
            this.Size = new System.Drawing.Size(343, 32);
            this.baseTLP.ResumeLayout(false);
            this.baseTLP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button deleteB;
        private System.Windows.Forms.Button browseB;
        private System.Windows.Forms.TextBox entryTB;
        private System.Windows.Forms.TableLayoutPanel baseTLP;

    }
}
