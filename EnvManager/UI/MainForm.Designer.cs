namespace EnvManager.UI
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.saveB = new System.Windows.Forms.Button();
            this.exitB = new System.Windows.Forms.Button();
            this.entriesFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.loadB = new System.Windows.Forms.Button();
            this.varNameTB = new System.Windows.Forms.TextBox();
            this.addB = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.varTargetCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // saveB
            // 
            this.saveB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveB.Location = new System.Drawing.Point(568, 402);
            this.saveB.Name = "saveB";
            this.saveB.Size = new System.Drawing.Size(75, 25);
            this.saveB.TabIndex = 0;
            this.saveB.Text = "Save";
            this.saveB.UseVisualStyleBackColor = true;
            this.saveB.Click += new System.EventHandler(this.saveB_Click);
            // 
            // exitB
            // 
            this.exitB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitB.Location = new System.Drawing.Point(649, 402);
            this.exitB.Name = "exitB";
            this.exitB.Size = new System.Drawing.Size(75, 25);
            this.exitB.TabIndex = 1;
            this.exitB.Text = "Exit";
            this.exitB.UseVisualStyleBackColor = true;
            this.exitB.Click += new System.EventHandler(this.exitB_Click);
            // 
            // entriesFLP
            // 
            this.entriesFLP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.entriesFLP.BackColor = System.Drawing.Color.LightBlue;
            this.entriesFLP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.entriesFLP.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.entriesFLP.Location = new System.Drawing.Point(12, 12);
            this.entriesFLP.Name = "entriesFLP";
            this.entriesFLP.Size = new System.Drawing.Size(712, 384);
            this.entriesFLP.TabIndex = 2;
            // 
            // loadB
            // 
            this.loadB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loadB.Location = new System.Drawing.Point(12, 402);
            this.loadB.Name = "loadB";
            this.loadB.Size = new System.Drawing.Size(75, 25);
            this.loadB.TabIndex = 3;
            this.loadB.Text = "Load";
            this.loadB.UseVisualStyleBackColor = true;
            this.loadB.Click += new System.EventHandler(this.loadB_Click);
            // 
            // varNameTB
            // 
            this.varNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.varNameTB.Location = new System.Drawing.Point(189, 405);
            this.varNameTB.Name = "varNameTB";
            this.varNameTB.Size = new System.Drawing.Size(120, 20);
            this.varNameTB.TabIndex = 4;
            this.varNameTB.Text = "PATH";
            this.varNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addB
            // 
            this.addB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addB.Location = new System.Drawing.Point(397, 403);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(77, 23);
            this.addB.TabIndex = 5;
            this.addB.Text = "^+^";
            this.addB.UseVisualStyleBackColor = true;
            this.addB.Click += new System.EventHandler(this.addB_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "EnvManager";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // varTargetCB
            // 
            this.varTargetCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.varTargetCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.varTargetCB.FormattingEnabled = true;
            this.varTargetCB.Items.AddRange(new object[] {
            "Machine",
            "User"});
            this.varTargetCB.Location = new System.Drawing.Point(93, 405);
            this.varTargetCB.Name = "varTargetCB";
            this.varTargetCB.Size = new System.Drawing.Size(90, 21);
            this.varTargetCB.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(736, 439);
            this.Controls.Add(this.varTargetCB);
            this.Controls.Add(this.addB);
            this.Controls.Add(this.varNameTB);
            this.Controls.Add(this.loadB);
            this.Controls.Add(this.entriesFLP);
            this.Controls.Add(this.exitB);
            this.Controls.Add(this.saveB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnvManager";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveB;
        private System.Windows.Forms.Button exitB;
        private System.Windows.Forms.FlowLayoutPanel entriesFLP;
        private System.Windows.Forms.Button loadB;
        private System.Windows.Forms.TextBox varNameTB;
        private System.Windows.Forms.Button addB;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ComboBox varTargetCB;
    }
}

