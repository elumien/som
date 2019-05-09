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
            this.label1 = new System.Windows.Forms.Label();
            this.baseInputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iterationLimitNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialLearningRateCoefficientNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalStandardDeviationNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialStandardDeviationNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // baseInputPanel
            // 
            this.baseInputPanel.Location = new System.Drawing.Point(17, 176);
            // 
            // startButton
            // 
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.Location = new System.Drawing.Point(13, 91);
            // 
            // flowerNeuralNetworkControl
            // 
            this.flowerNeuralNetworkControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowerNeuralNetworkControl.FlowerInputDataSet = null;
            this.flowerNeuralNetworkControl.Location = new System.Drawing.Point(409, 26);
            this.flowerNeuralNetworkControl.Name = "flowerNeuralNetworkControl";
            this.flowerNeuralNetworkControl.NeuralNetwork = null;
            this.flowerNeuralNetworkControl.Size = new System.Drawing.Size(364, 364);
            this.flowerNeuralNetworkControl.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Iris Flower Clustering";
            // 
            // FlowerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 402);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowerNeuralNetworkControl);
            this.Name = "FlowerForm";
            this.Text = "Flower Self-Organizing Map";
            this.Controls.SetChildIndex(this.timeLabel, 0);
            this.Controls.SetChildIndex(this.baseInputPanel, 0);
            this.Controls.SetChildIndex(this.flowerNeuralNetworkControl, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.baseInputPanel.ResumeLayout(false);
            this.baseInputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iterationLimitNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialLearningRateCoefficientNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalStandardDeviationNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialStandardDeviationNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Control.FlowerNeuralNetworkControl flowerNeuralNetworkControl;
        private System.Windows.Forms.Label label1;
    }
}