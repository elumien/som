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
            this.colorNeuralNetworkControl = new Self_Organizing_Map.Control.ColorNeuralNetworkControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.randomColorsRadioButton = new System.Windows.Forms.RadioButton();
            this.fixColorsRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.baseInputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iterationLimitNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialLearningRateCoefficientNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalStandardDeviationNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialStandardDeviationNumericUpDown)).BeginInit();
            this.panel1.SuspendLayout();
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
            // colorNeuralNetworkControl
            // 
            this.colorNeuralNetworkControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorNeuralNetworkControl.Location = new System.Drawing.Point(394, 21);
            this.colorNeuralNetworkControl.Name = "colorNeuralNetworkControl";
            this.colorNeuralNetworkControl.Size = new System.Drawing.Size(364, 364);
            this.colorNeuralNetworkControl.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.randomColorsRadioButton);
            this.panel1.Controls.Add(this.fixColorsRadioButton);
            this.panel1.Location = new System.Drawing.Point(14, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 66);
            this.panel1.TabIndex = 2;
            // 
            // randomColorsRadioButton
            // 
            this.randomColorsRadioButton.AutoSize = true;
            this.randomColorsRadioButton.Location = new System.Drawing.Point(18, 35);
            this.randomColorsRadioButton.Name = "randomColorsRadioButton";
            this.randomColorsRadioButton.Size = new System.Drawing.Size(96, 17);
            this.randomColorsRadioButton.TabIndex = 1;
            this.randomColorsRadioButton.TabStop = true;
            this.randomColorsRadioButton.Text = "Random colors";
            this.randomColorsRadioButton.UseVisualStyleBackColor = true;
            // 
            // fixColorsRadioButton
            // 
            this.fixColorsRadioButton.AutoSize = true;
            this.fixColorsRadioButton.Checked = true;
            this.fixColorsRadioButton.Location = new System.Drawing.Point(18, 12);
            this.fixColorsRadioButton.Name = "fixColorsRadioButton";
            this.fixColorsRadioButton.Size = new System.Drawing.Size(96, 17);
            this.fixColorsRadioButton.TabIndex = 0;
            this.fixColorsRadioButton.TabStop = true;
            this.fixColorsRadioButton.Text = "Example colors";
            this.fixColorsRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Color Clustering";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "(Fixed sample data set of 8 colors)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "(Randomly generated data set of 8 colors)";
            // 
            // ColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 402);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.colorNeuralNetworkControl);
            this.Name = "ColorForm";
            this.Text = "Color Self-Organizing Map";
            this.Controls.SetChildIndex(this.colorNeuralNetworkControl, 0);
            this.Controls.SetChildIndex(this.baseInputPanel, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.baseInputPanel.ResumeLayout(false);
            this.baseInputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iterationLimitNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialLearningRateCoefficientNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalStandardDeviationNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialStandardDeviationNumericUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Control.ColorNeuralNetworkControl colorNeuralNetworkControl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton randomColorsRadioButton;
        private System.Windows.Forms.RadioButton fixColorsRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}