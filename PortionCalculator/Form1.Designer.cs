namespace PortionCalculator
{
    partial class PortionCalculator
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
            this.Measurement = new System.Windows.Forms.TextBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.NewMultiplier = new System.Windows.Forms.TextBox();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.OldMultiplier = new System.Windows.Forms.TextBox();
            this.EqualsLabel = new System.Windows.Forms.Label();
            this.MeasurementLabel = new System.Windows.Forms.Label();
            this.NewMultiplierLabel = new System.Windows.Forms.Label();
            this.OldMultiplierLabel = new System.Windows.Forms.Label();
            this.TimesLabel = new System.Windows.Forms.Label();
            this.DivideLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Measurement
            // 
            this.Measurement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Measurement.Location = new System.Drawing.Point(12, 23);
            this.Measurement.Name = "Measurement";
            this.Measurement.Size = new System.Drawing.Size(68, 26);
            this.Measurement.TabIndex = 0;
            // 
            // GoButton
            // 
            this.GoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.GoButton.Location = new System.Drawing.Point(12, 55);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(306, 37);
            this.GoButton.TabIndex = 4;
            this.GoButton.Text = "Calculate";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // NewMultiplier
            // 
            this.NewMultiplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NewMultiplier.Location = new System.Drawing.Point(97, 23);
            this.NewMultiplier.Name = "NewMultiplier";
            this.NewMultiplier.Size = new System.Drawing.Size(62, 26);
            this.NewMultiplier.TabIndex = 1;
            // 
            // OutputBox
            // 
            this.OutputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.OutputBox.Location = new System.Drawing.Point(263, 23);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.Size = new System.Drawing.Size(55, 26);
            this.OutputBox.TabIndex = 5;
            // 
            // OldMultiplier
            // 
            this.OldMultiplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.OldMultiplier.Location = new System.Drawing.Point(177, 23);
            this.OldMultiplier.Name = "OldMultiplier";
            this.OldMultiplier.Size = new System.Drawing.Size(56, 26);
            this.OldMultiplier.TabIndex = 2;
            // 
            // EqualsLabel
            // 
            this.EqualsLabel.AutoSize = true;
            this.EqualsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EqualsLabel.Location = new System.Drawing.Point(239, 26);
            this.EqualsLabel.Name = "EqualsLabel";
            this.EqualsLabel.Size = new System.Drawing.Size(18, 20);
            this.EqualsLabel.TabIndex = 2;
            this.EqualsLabel.Text = "=";
            this.EqualsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MeasurementLabel
            // 
            this.MeasurementLabel.AutoSize = true;
            this.MeasurementLabel.Location = new System.Drawing.Point(12, 7);
            this.MeasurementLabel.Name = "MeasurementLabel";
            this.MeasurementLabel.Size = new System.Drawing.Size(71, 13);
            this.MeasurementLabel.TabIndex = 3;
            this.MeasurementLabel.Text = "Measurement";
            this.MeasurementLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NewMultiplierLabel
            // 
            this.NewMultiplierLabel.AutoSize = true;
            this.NewMultiplierLabel.Location = new System.Drawing.Point(94, 7);
            this.NewMultiplierLabel.Name = "NewMultiplierLabel";
            this.NewMultiplierLabel.Size = new System.Drawing.Size(65, 13);
            this.NewMultiplierLabel.TabIndex = 4;
            this.NewMultiplierLabel.Text = "New Portion";
            this.NewMultiplierLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OldMultiplierLabel
            // 
            this.OldMultiplierLabel.AutoSize = true;
            this.OldMultiplierLabel.Location = new System.Drawing.Point(174, 7);
            this.OldMultiplierLabel.Name = "OldMultiplierLabel";
            this.OldMultiplierLabel.Size = new System.Drawing.Size(59, 13);
            this.OldMultiplierLabel.TabIndex = 4;
            this.OldMultiplierLabel.Text = "Old Portion";
            this.OldMultiplierLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TimesLabel
            // 
            this.TimesLabel.AutoSize = true;
            this.TimesLabel.Location = new System.Drawing.Point(83, 28);
            this.TimesLabel.Name = "TimesLabel";
            this.TimesLabel.Size = new System.Drawing.Size(12, 13);
            this.TimesLabel.TabIndex = 5;
            this.TimesLabel.Text = "x";
            this.TimesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DivideLabel
            // 
            this.DivideLabel.AutoSize = true;
            this.DivideLabel.Location = new System.Drawing.Point(162, 28);
            this.DivideLabel.Name = "DivideLabel";
            this.DivideLabel.Size = new System.Drawing.Size(13, 13);
            this.DivideLabel.TabIndex = 6;
            this.DivideLabel.Text = "÷";
            this.DivideLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PortionCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 104);
            this.Controls.Add(this.DivideLabel);
            this.Controls.Add(this.TimesLabel);
            this.Controls.Add(this.OldMultiplierLabel);
            this.Controls.Add(this.NewMultiplierLabel);
            this.Controls.Add(this.MeasurementLabel);
            this.Controls.Add(this.EqualsLabel);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.OldMultiplier);
            this.Controls.Add(this.NewMultiplier);
            this.Controls.Add(this.Measurement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "PortionCalculator";
            this.Text = "Portion Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Measurement;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.TextBox NewMultiplier;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.TextBox OldMultiplier;
        private System.Windows.Forms.Label EqualsLabel;
        private System.Windows.Forms.Label MeasurementLabel;
        private System.Windows.Forms.Label NewMultiplierLabel;
        private System.Windows.Forms.Label OldMultiplierLabel;
        private System.Windows.Forms.Label TimesLabel;
        private System.Windows.Forms.Label DivideLabel;
    }
}

