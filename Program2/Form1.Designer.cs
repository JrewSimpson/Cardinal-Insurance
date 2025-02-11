namespace Program2
{
    partial class Program2
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
            this.CardinalLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SmokeNo = new System.Windows.Forms.RadioButton();
            this.SmokeYes = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AccidentNo = new System.Windows.Forms.RadioButton();
            this.AccidentYes = new System.Windows.Forms.RadioButton();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.HealthCost = new System.Windows.Forms.TextBox();
            this.CarCoverageCost = new System.Windows.Forms.Label();
            this.CarCost = new System.Windows.Forms.TextBox();
            this.TotalCostLabel = new System.Windows.Forms.Label();
            this.TotalCost = new System.Windows.Forms.TextBox();
            this.AgeInput = new System.Windows.Forms.TextBox();
            this.CarInput = new System.Windows.Forms.TextBox();
            this.HealthChoice = new System.Windows.Forms.ComboBox();
            this.CarChoice = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CardinalLabel
            // 
            this.CardinalLabel.AutoSize = true;
            this.CardinalLabel.Location = new System.Drawing.Point(123, 9);
            this.CardinalLabel.Name = "CardinalLabel";
            this.CardinalLabel.Size = new System.Drawing.Size(176, 13);
            this.CardinalLabel.TabIndex = 0;
            this.CardinalLabel.Text = "Cardinal Insurance Policy Calculator";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(74, 41);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(82, 13);
            this.AgeLabel.TabIndex = 1;
            this.AgeLabel.Text = "Enter Your Age:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Estimated Value of Car";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Health Insurance Coverage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Car Insurance Coverage";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SmokeNo);
            this.groupBox1.Controls.Add(this.SmokeYes);
            this.groupBox1.Location = new System.Drawing.Point(80, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 60);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Do You Smoke?";
            // 
            // SmokeNo
            // 
            this.SmokeNo.AutoSize = true;
            this.SmokeNo.Location = new System.Drawing.Point(167, 23);
            this.SmokeNo.Name = "SmokeNo";
            this.SmokeNo.Size = new System.Drawing.Size(39, 17);
            this.SmokeNo.TabIndex = 1;
            this.SmokeNo.TabStop = true;
            this.SmokeNo.Text = "No";
            this.SmokeNo.UseVisualStyleBackColor = true;
            // 
            // SmokeYes
            // 
            this.SmokeYes.AutoSize = true;
            this.SmokeYes.Location = new System.Drawing.Point(167, 0);
            this.SmokeYes.Name = "SmokeYes";
            this.SmokeYes.Size = new System.Drawing.Size(43, 17);
            this.SmokeYes.TabIndex = 0;
            this.SmokeYes.TabStop = true;
            this.SmokeYes.Text = "Yes";
            this.SmokeYes.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AccidentNo);
            this.groupBox2.Controls.Add(this.AccidentYes);
            this.groupBox2.Location = new System.Drawing.Point(77, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 61);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Car Accident in the Past Year?";
            // 
            // AccidentNo
            // 
            this.AccidentNo.AutoSize = true;
            this.AccidentNo.Location = new System.Drawing.Point(167, 22);
            this.AccidentNo.Name = "AccidentNo";
            this.AccidentNo.Size = new System.Drawing.Size(39, 17);
            this.AccidentNo.TabIndex = 1;
            this.AccidentNo.TabStop = true;
            this.AccidentNo.Text = "No";
            this.AccidentNo.UseVisualStyleBackColor = true;
            // 
            // AccidentYes
            // 
            this.AccidentYes.AutoSize = true;
            this.AccidentYes.Location = new System.Drawing.Point(167, -1);
            this.AccidentYes.Name = "AccidentYes";
            this.AccidentYes.Size = new System.Drawing.Size(43, 17);
            this.AccidentYes.TabIndex = 0;
            this.AccidentYes.TabStop = true;
            this.AccidentYes.Text = "Yes";
            this.AccidentYes.UseVisualStyleBackColor = true;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(111, 317);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(176, 23);
            this.CalculateButton.TabIndex = 7;
            this.CalculateButton.Text = "Calculate Policy Premiums";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Health Coverage Cost per Year:";
            // 
            // HealthCost
            // 
            this.HealthCost.Location = new System.Drawing.Point(244, 357);
            this.HealthCost.Name = "HealthCost";
            this.HealthCost.Size = new System.Drawing.Size(100, 20);
            this.HealthCost.TabIndex = 9;
            // 
            // CarCoverageCost
            // 
            this.CarCoverageCost.AutoSize = true;
            this.CarCoverageCost.Location = new System.Drawing.Point(59, 390);
            this.CarCoverageCost.Name = "CarCoverageCost";
            this.CarCoverageCost.Size = new System.Drawing.Size(142, 13);
            this.CarCoverageCost.TabIndex = 10;
            this.CarCoverageCost.Text = "Car Coverage Cost per Year:";
            // 
            // CarCost
            // 
            this.CarCost.Location = new System.Drawing.Point(244, 390);
            this.CarCost.Name = "CarCost";
            this.CarCost.Size = new System.Drawing.Size(100, 20);
            this.CarCost.TabIndex = 11;
            // 
            // TotalCostLabel
            // 
            this.TotalCostLabel.AutoSize = true;
            this.TotalCostLabel.Location = new System.Drawing.Point(59, 422);
            this.TotalCostLabel.Name = "TotalCostLabel";
            this.TotalCostLabel.Size = new System.Drawing.Size(132, 13);
            this.TotalCostLabel.TabIndex = 12;
            this.TotalCostLabel.Text = "Total Policy Cost per Year:";
            // 
            // TotalCost
            // 
            this.TotalCost.Location = new System.Drawing.Point(244, 422);
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.Size = new System.Drawing.Size(100, 20);
            this.TotalCost.TabIndex = 13;
            // 
            // AgeInput
            // 
            this.AgeInput.Location = new System.Drawing.Point(219, 41);
            this.AgeInput.Name = "AgeInput";
            this.AgeInput.Size = new System.Drawing.Size(100, 20);
            this.AgeInput.TabIndex = 14;
            // 
            // CarInput
            // 
            this.CarInput.Location = new System.Drawing.Point(219, 73);
            this.CarInput.Name = "CarInput";
            this.CarInput.Size = new System.Drawing.Size(100, 20);
            this.CarInput.TabIndex = 15;
            // 
            // HealthChoice
            // 
            this.HealthChoice.FormattingEnabled = true;
            this.HealthChoice.Items.AddRange(new object[] {
            "Medical",
            "Dental",
            "Vision",
            "None"});
            this.HealthChoice.Location = new System.Drawing.Point(219, 105);
            this.HealthChoice.Name = "HealthChoice";
            this.HealthChoice.Size = new System.Drawing.Size(121, 21);
            this.HealthChoice.TabIndex = 16;
            // 
            // CarChoice
            // 
            this.CarChoice.FormattingEnabled = true;
            this.CarChoice.Items.AddRange(new object[] {
            "Full",
            "Liability",
            "None"});
            this.CarChoice.Location = new System.Drawing.Point(219, 134);
            this.CarChoice.Name = "CarChoice";
            this.CarChoice.Size = new System.Drawing.Size(121, 21);
            this.CarChoice.TabIndex = 17;
            // 
            // Program2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 490);
            this.Controls.Add(this.CarChoice);
            this.Controls.Add(this.HealthChoice);
            this.Controls.Add(this.CarInput);
            this.Controls.Add(this.AgeInput);
            this.Controls.Add(this.TotalCost);
            this.Controls.Add(this.TotalCostLabel);
            this.Controls.Add(this.CarCost);
            this.Controls.Add(this.CarCoverageCost);
            this.Controls.Add(this.HealthCost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.CardinalLabel);
            this.Name = "Program2";
            this.Text = "Program2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CardinalLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton SmokeNo;
        private System.Windows.Forms.RadioButton SmokeYes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton AccidentNo;
        private System.Windows.Forms.RadioButton AccidentYes;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox HealthCost;
        private System.Windows.Forms.Label CarCoverageCost;
        private System.Windows.Forms.TextBox CarCost;
        private System.Windows.Forms.Label TotalCostLabel;
        private System.Windows.Forms.TextBox TotalCost;
        private System.Windows.Forms.TextBox AgeInput;
        private System.Windows.Forms.TextBox CarInput;
        private System.Windows.Forms.ComboBox HealthChoice;
        private System.Windows.Forms.ComboBox CarChoice;
    }
}

