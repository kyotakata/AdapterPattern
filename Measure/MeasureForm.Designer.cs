namespace Measure
{
    partial class MeasureForm
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
            this.MeasureButton = new System.Windows.Forms.Button();
            this.MeasureLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MeasureButton
            // 
            this.MeasureButton.Location = new System.Drawing.Point(294, 222);
            this.MeasureButton.Name = "MeasureButton";
            this.MeasureButton.Size = new System.Drawing.Size(215, 70);
            this.MeasureButton.TabIndex = 0;
            this.MeasureButton.Text = "計測";
            this.MeasureButton.UseVisualStyleBackColor = true;
            this.MeasureButton.Click += new System.EventHandler(this.MeasureButton_Click);
            // 
            // MeasureLabel
            // 
            this.MeasureLabel.AutoSize = true;
            this.MeasureLabel.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MeasureLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.MeasureLabel.Location = new System.Drawing.Point(28, 112);
            this.MeasureLabel.Name = "MeasureLabel";
            this.MeasureLabel.Size = new System.Drawing.Size(85, 60);
            this.MeasureLabel.TabIndex = 1;
            this.MeasureLabel.Text = "--";
            // 
            // MeasureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 304);
            this.Controls.Add(this.MeasureLabel);
            this.Controls.Add(this.MeasureButton);
            this.Name = "MeasureForm";
            this.Text = "MeasureForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MeasureButton;
        private System.Windows.Forms.Label MeasureLabel;
    }
}