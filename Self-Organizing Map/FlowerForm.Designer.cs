namespace Self_Organizing_Map
{
    partial class FlowerForm
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
            this.flowerNeuralNetworkControl = new Self_Organizing_Map.Control.FlowerNeuralNetworkControl();
            this.baseInputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iterationLimitNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialLearningRateCoefficientNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalStandardDeviationNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialStandardDeviationNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // baseInputPanel
            // 
            this.baseInputPanel.Location = new System.Drawing.Point(12, 118);
            // 
            // startButton
            // 
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // flowerNeuralNetworkControl
            // 
            this.flowerNeuralNetworkControl.Location = new System.Drawing.Point(409, 26);
            this.flowerNeuralNetworkControl.Name = "flowerNeuralNetworkControl";
            this.flowerNeuralNetworkControl.Size = new System.Drawing.Size(364, 364);
            this.flowerNeuralNetworkControl.TabIndex = 1;
            // 
            // FlowerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 402);
            this.Controls.Add(this.flowerNeuralNetworkControl);
            this.Name = "FlowerForm";
            this.Text = "Flower Self-Organizing Map";
            this.Controls.SetChildIndex(this.baseInputPanel, 0);
            this.Controls.SetChildIndex(this.flowerNeuralNetworkControl, 0);
            this.baseInputPanel.ResumeLayout(false);
            this.baseInputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iterationLimitNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialLearningRateCoefficientNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalStandardDeviationNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialStandardDeviationNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Control.FlowerNeuralNetworkControl flowerNeuralNetworkControl;
    }
}