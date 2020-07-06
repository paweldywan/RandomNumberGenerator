namespace RandomNumberGenerator
{
    partial class RandomNumberGenerratorForm
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
            this.FromLabel = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.OptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.CopyButton = new System.Windows.Forms.Button();
            this.AmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ToNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FromNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.ResultListBox = new System.Windows.Forms.ListBox();
            this.OptionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Location = new System.Drawing.Point(9, 25);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(21, 13);
            this.FromLabel.TabIndex = 0;
            this.FromLabel.Text = "Od";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(9, 53);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(21, 13);
            this.ToLabel.TabIndex = 2;
            this.ToLabel.Text = "Do";
            // 
            // OptionsGroupBox
            // 
            this.OptionsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OptionsGroupBox.Controls.Add(this.CopyButton);
            this.OptionsGroupBox.Controls.Add(this.AmountNumericUpDown);
            this.OptionsGroupBox.Controls.Add(this.ToNumericUpDown);
            this.OptionsGroupBox.Controls.Add(this.FromNumericUpDown);
            this.OptionsGroupBox.Controls.Add(this.GenerateButton);
            this.OptionsGroupBox.Controls.Add(this.AmountLabel);
            this.OptionsGroupBox.Controls.Add(this.FromLabel);
            this.OptionsGroupBox.Controls.Add(this.ToLabel);
            this.OptionsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.OptionsGroupBox.Name = "OptionsGroupBox";
            this.OptionsGroupBox.Size = new System.Drawing.Size(232, 147);
            this.OptionsGroupBox.TabIndex = 4;
            this.OptionsGroupBox.TabStop = false;
            this.OptionsGroupBox.Text = "Ustawienia";
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(147, 112);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(75, 23);
            this.CopyButton.TabIndex = 10;
            this.CopyButton.Text = "Kopiuj";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // AmountNumericUpDown
            // 
            this.AmountNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountNumericUpDown.Location = new System.Drawing.Point(44, 77);
            this.AmountNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AmountNumericUpDown.Name = "AmountNumericUpDown";
            this.AmountNumericUpDown.Size = new System.Drawing.Size(178, 20);
            this.AmountNumericUpDown.TabIndex = 9;
            this.AmountNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ToNumericUpDown
            // 
            this.ToNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ToNumericUpDown.Location = new System.Drawing.Point(44, 51);
            this.ToNumericUpDown.Name = "ToNumericUpDown";
            this.ToNumericUpDown.Size = new System.Drawing.Size(178, 20);
            this.ToNumericUpDown.TabIndex = 8;
            this.ToNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FromNumericUpDown
            // 
            this.FromNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FromNumericUpDown.Location = new System.Drawing.Point(44, 23);
            this.FromNumericUpDown.Name = "FromNumericUpDown";
            this.FromNumericUpDown.Size = new System.Drawing.Size(178, 20);
            this.FromNumericUpDown.TabIndex = 7;
            this.FromNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(44, 112);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(75, 23);
            this.GenerateButton.TabIndex = 6;
            this.GenerateButton.Text = "Generuj";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(9, 79);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(29, 13);
            this.AmountLabel.TabIndex = 4;
            this.AmountLabel.Text = "Ilość";
            // 
            // ResultListBox
            // 
            this.ResultListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultListBox.FormattingEnabled = true;
            this.ResultListBox.Location = new System.Drawing.Point(12, 169);
            this.ResultListBox.Name = "ResultListBox";
            this.ResultListBox.Size = new System.Drawing.Size(232, 264);
            this.ResultListBox.TabIndex = 5;
            // 
            // RandomNumberGenerratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 446);
            this.Controls.Add(this.ResultListBox);
            this.Controls.Add(this.OptionsGroupBox);
            this.MinimumSize = new System.Drawing.Size(272, 485);
            this.Name = "RandomNumberGenerratorForm";
            this.Text = "Generator liczb losowych";
            this.OptionsGroupBox.ResumeLayout(false);
            this.OptionsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.GroupBox OptionsGroupBox;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.ListBox ResultListBox;
        private System.Windows.Forms.NumericUpDown AmountNumericUpDown;
        private System.Windows.Forms.NumericUpDown ToNumericUpDown;
        private System.Windows.Forms.NumericUpDown FromNumericUpDown;
        private System.Windows.Forms.Button CopyButton;
    }
}

