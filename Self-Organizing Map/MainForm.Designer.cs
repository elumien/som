namespace Self_Organizing_Map
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
            this.colorButton = new System.Windows.Forms.Button();
            this.flowerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(48, 34);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(148, 23);
            this.colorButton.TabIndex = 0;
            this.colorButton.Text = "Color Clustering  SOM";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // flowerButton
            // 
            this.flowerButton.Location = new System.Drawing.Point(48, 73);
            this.flowerButton.Name = "flowerButton";
            this.flowerButton.Size = new System.Drawing.Size(148, 23);
            this.flowerButton.TabIndex = 1;
            this.flowerButton.Text = "Iris Flower SOM";
            this.flowerButton.UseVisualStyleBackColor = true;
            this.flowerButton.Click += new System.EventHandler(this.FlowerButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 131);
            this.Controls.Add(this.flowerButton);
            this.Controls.Add(this.colorButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SOM";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Button flowerButton;
    }
}

