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
            this.finalStandardDeviationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.finalStandardDeviationLabel = new System.Windows.Forms.Label();
            this.initialStandardDeviationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.initialStandardDeviationLabel = new System.Windows.Forms.Label();
            this.initialLearningRateCoefficientNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.initialLearningRateCoefficientLabel = new System.Windows.Forms.Label();
            this.iterationLimitNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.iterationLimitLimitLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.baseInputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finalStandardDeviationNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialStandardDeviationNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialLearningRateCoefficientNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterationLimitNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // baseInputPanel
            // 
            this.baseInputPanel.Controls.Add(this.finalStandardDeviationNumericUpDown);
            this.baseInputPanel.Controls.Add(this.finalStandardDeviationLabel);
            this.baseInputPanel.Controls.Add(this.initialStandardDeviationNumericUpDown);
            this.baseInputPanel.Controls.Add(this.initialStandardDeviationLabel);
            this.baseInputPanel.Controls.Add(this.initialLearningRateCoefficientNumericUpDown);
            this.baseInputPanel.Controls.Add(this.initialLearningRateCoefficientLabel);
            this.baseInputPanel.Controls.Add(this.iterationLimitNumericUpDown);
            this.baseInputPanel.Controls.Add(this.iterationLimitLimitLabel);
            this.baseInputPanel.Controls.Add(this.startButton);
            this.baseInputPanel.Location = new System.Drawing.Point(14, 12);
            this.baseInputPanel.Name = "baseInputPanel";
            this.baseInputPanel.Size = new System.Drawing.Size(350, 214);
            this.baseInputPanel.TabIndex = 0;
            // 
            // finalStandardDeviationNumericUpDown
            // 
            this.finalStandardDeviationNumericUpDown.DecimalPlaces = 2;
            this.finalStandardDeviationNumericUpDown.ImeMode = System.Windows.Forms.ImeMode.On;
            this.finalStandardDeviationNumericUpDown.Location = new System.Drawing.Point(216, 135);
            this.finalStandardDeviationNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.finalStandardDeviationNumericUpDown.Name = "finalStandardDeviationNumericUpDown";
            this.finalStandardDeviationNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.finalStandardDeviationNumericUpDown.TabIndex = 8;
            this.finalStandardDeviationNumericUpDown.ThousandsSeparator = true;
            this.finalStandardDeviationNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // finalStandardDeviationLabel
            // 
            this.finalStandardDeviationLabel.AutoSize = true;
            this.finalStandardDeviationLabel.Location = new System.Drawing.Point(15, 137);
            this.finalStandardDeviationLabel.Name = "finalStandardDeviationLabel";
            this.finalStandardDeviationLabel.Size = new System.Drawing.Size(163, 13);
            this.finalStandardDeviationLabel.TabIndex = 7;
            this.finalStandardDeviationLabel.Text = "Final value of standard deviation:";
            // 
            // initialStandardDeviationNumericUpDown
            // 
            this.initialStandardDeviationNumericUpDown.DecimalPlaces = 2;
            this.initialStandardDeviationNumericUpDown.ImeMode = System.Windows.Forms.ImeMode.On;
            this.initialStandardDeviationNumericUpDown.Location = new System.Drawing.Point(216, 103);
            this.initialStandardDeviationNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.initialStandardDeviationNumericUpDown.Name = "initialStandardDeviationNumericUpDown";
            this.initialStandardDeviationNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.initialStandardDeviationNumericUpDown.TabIndex = 6;
            this.initialStandardDeviationNumericUpDown.ThousandsSeparator = true;
            this.initialStandardDeviationNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // initialStandardDeviationLabel
            // 
            this.initialStandardDeviationLabel.AutoSize = true;
            this.initialStandardDeviationLabel.Location = new System.Drawing.Point(15, 105);
            this.initialStandardDeviationLabel.Name = "initialStandardDeviationLabel";
            this.initialStandardDeviationLabel.Size = new System.Drawing.Size(165, 13);
            this.initialStandardDeviationLabel.TabIndex = 5;
            this.initialStandardDeviationLabel.Text = "Initial value of standard deviation:";
            // 
            // initialLearningRateCoefficientNumericUpDown
            // 
            this.initialLearningRateCoefficientNumericUpDown.DecimalPlaces = 2;
            this.initialLearningRateCoefficientNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.initialLearningRateCoefficientNumericUpDown.Location = new System.Drawing.Point(216, 71);
            this.initialLearningRateCoefficientNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.initialLearningRateCoefficientNumericUpDown.Name = "initialLearningRateCoefficientNumericUpDown";
            this.initialLearningRateCoefficientNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.initialLearningRateCoefficientNumericUpDown.TabIndex = 4;
            this.initialLearningRateCoefficientNumericUpDown.ThousandsSeparator = true;
            this.initialLearningRateCoefficientNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // initialLearningRateCoefficientLabel
            // 
            this.initialLearningRateCoefficientLabel.AutoSize = true;
            this.initialLearningRateCoefficientLabel.Location = new System.Drawing.Point(15, 73);
            this.initialLearningRateCoefficientLabel.Name = "initialLearningRateCoefficientLabel";
            this.initialLearningRateCoefficientLabel.Size = new System.Drawing.Size(188, 13);
            this.initialLearningRateCoefficientLabel.TabIndex = 3;
            this.initialLearningRateCoefficientLabel.Text = "Initial value of learning-rate coefficient:";
            // 
            // iterationLimitNumericUpDown
            // 
            this.iterationLimitNumericUpDown.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.iterationLimitNumericUpDown.Location = new System.Drawing.Point(216, 39);
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
            // iterationLimitLimitLabel
            // 
            this.iterationLimitLimitLabel.AutoSize = true;
            this.iterationLimitLimitLabel.Location = new System.Drawing.Point(15, 41);
            this.iterationLimitLimitLabel.Name = "iterationLimitLimitLabel";
            this.iterationLimitLimitLabel.Size = new System.Drawing.Size(129, 13);
            this.iterationLimitLimitLabel.TabIndex = 1;
            this.iterationLimitLimitLabel.Text = "Total number of iterations:";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(138, 176);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 239);
            this.Controls.Add(this.baseInputPanel);
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Self-Organizing Map";
            this.baseInputPanel.ResumeLayout(false);
            this.baseInputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finalStandardDeviationNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialStandardDeviationNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialLearningRateCoefficientNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterationLimitNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel baseInputPanel;
        protected System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label iterationLimitLimitLabel;
        protected System.Windows.Forms.NumericUpDown iterationLimitNumericUpDown;
        private System.Windows.Forms.Label initialLearningRateCoefficientLabel;
        protected System.Windows.Forms.NumericUpDown initialLearningRateCoefficientNumericUpDown;
        private System.Windows.Forms.Label initialStandardDeviationLabel;
        protected System.Windows.Forms.NumericUpDown finalStandardDeviationNumericUpDown;
        private System.Windows.Forms.Label finalStandardDeviationLabel;
        protected System.Windows.Forms.NumericUpDown initialStandardDeviationNumericUpDown;
    }
}