namespace Self_Organizing_Map
{
    partial class BaseForm
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
            this.baseInputPanel = new System.Windows.Forms.Panel();
            this.startButton = new System.Windows.Forms.Button();
            this.iterationLimitLabel = new System.Windows.Forms.Label();
            this.iterationLimitNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.baseInputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iterationLimitNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // baseInputPanel
            // 
            this.baseInputPanel.Controls.Add(this.iterationLimitNumericUpDown);
            this.baseInputPanel.Controls.Add(this.iterationLimitLabel);
            this.baseInputPanel.Controls.Add(this.startButton);
            this.baseInputPanel.Location = new System.Drawing.Point(12, 188);
            this.baseInputPanel.Name = "baseInputPanel";
            this.baseInputPanel.Size = new System.Drawing.Size(350, 250);
            this.baseInputPanel.TabIndex = 0;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(138, 214);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // iterationLimitLabel
            // 
            this.iterationLimitLabel.AutoSize = true;
            this.iterationLimitLabel.Location = new System.Drawing.Point(17, 37);
            this.iterationLimitLabel.Name = "iterationLimitLabel";
            this.iterationLimitLabel.Size = new System.Drawing.Size(68, 13);
            this.iterationLimitLabel.TabIndex = 1;
            this.iterationLimitLabel.Text = "Iteration limit:";
            // 
            // iterationLimitNumericUpDown
            // 
            this.iterationLimitNumericUpDown.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.iterationLimitNumericUpDown.Location = new System.Drawing.Point(93, 35);
            this.iterationLimitNumericUpDown.Maximum = new decimal(new int[] {
            268435456,
            1042612833,
            542101086,
            0});
            this.iterationLimitNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.iterationLimitNumericUpDown.Name = "iterationLimitNumericUpDown";
            this.iterationLimitNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.iterationLimitNumericUpDown.TabIndex = 2;
            this.iterationLimitNumericUpDown.ThousandsSeparator = true;
            this.iterationLimitNumericUpDown.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.baseInputPanel);
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Self-Organizing Map";
            this.baseInputPanel.ResumeLayout(false);
            this.baseInputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iterationLimitNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel baseInputPanel;
        protected System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label iterationLimitLabel;
        protected System.Windows.Forms.NumericUpDown iterationLimitNumericUpDown;
    }
}