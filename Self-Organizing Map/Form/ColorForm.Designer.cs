namespace Self_Organizing_Map
{
    partial class ColorForm
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
            this.neuralNetworkControl = new Self_Organizing_Map.Control.NeuralNetworkControl();
            this.baseInputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iterationLimitNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialLearningRateCoefficientNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalStandardDeviationNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialStandardDeviationNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // baseInputPanel
            // 
            this.baseInputPanel.Location = new System.Drawing.Point(14, 172);
            // 
            // startButton
            // 
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // neuralNetworkControl
            // 
            this.neuralNetworkControl.Location = new System.Drawing.Point(394, 21);
            this.neuralNetworkControl.Name = "neuralNetworkControl";
            this.neuralNetworkControl.Size = new System.Drawing.Size(364, 364);
            this.neuralNetworkControl.TabIndex = 1;
            // 
            // ColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 402);
            this.Controls.Add(this.neuralNetworkControl);
            this.Name = "ColorForm";
            this.Text = "Color Self-Organizing Map";
            this.Controls.SetChildIndex(this.baseInputPanel, 0);
            this.Controls.SetChildIndex(this.neuralNetworkControl, 0);
            this.baseInputPanel.ResumeLayout(false);
            this.baseInputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iterationLimitNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialLearningRateCoefficientNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalStandardDeviationNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialStandardDeviationNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Control.NeuralNetworkControl neuralNetworkControl;
    }
}