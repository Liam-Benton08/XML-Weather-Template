namespace XMLWeather
{
    partial class SearchScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cityInput = new System.Windows.Forms.TextBox();
            this.cityOutput = new System.Windows.Forms.Label();
            this.addCityButton = new System.Windows.Forms.Button();
            this.backLabel = new System.Windows.Forms.Label();
            this.countryInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "City:";
            // 
            // cityInput
            // 
            this.cityInput.BackColor = System.Drawing.Color.Black;
            this.cityInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityInput.ForeColor = System.Drawing.Color.White;
            this.cityInput.Location = new System.Drawing.Point(54, 105);
            this.cityInput.Margin = new System.Windows.Forms.Padding(2);
            this.cityInput.Name = "cityInput";
            this.cityInput.Size = new System.Drawing.Size(136, 26);
            this.cityInput.TabIndex = 2;
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Black;
            this.cityOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.White;
            this.cityOutput.Location = new System.Drawing.Point(41, 26);
            this.cityOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(174, 26);
            this.cityOutput.TabIndex = 3;
            this.cityOutput.Text = "Search Results";
            // 
            // addCityButton
            // 
            this.addCityButton.BackColor = System.Drawing.Color.Black;
            this.addCityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCityButton.ForeColor = System.Drawing.Color.White;
            this.addCityButton.Location = new System.Drawing.Point(139, 356);
            this.addCityButton.Name = "addCityButton";
            this.addCityButton.Size = new System.Drawing.Size(107, 36);
            this.addCityButton.TabIndex = 4;
            this.addCityButton.Text = "Add City";
            this.addCityButton.UseVisualStyleBackColor = false;
            this.addCityButton.Click += new System.EventHandler(this.addCityButton_Click);
            // 
            // backLabel
            // 
            this.backLabel.AutoSize = true;
            this.backLabel.BackColor = System.Drawing.Color.Transparent;
            this.backLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backLabel.ForeColor = System.Drawing.Color.White;
            this.backLabel.Location = new System.Drawing.Point(31, 360);
            this.backLabel.Name = "backLabel";
            this.backLabel.Size = new System.Drawing.Size(66, 29);
            this.backLabel.TabIndex = 64;
            this.backLabel.Text = "Back";
            this.backLabel.Click += new System.EventHandler(this.backLabel_Click);
            // 
            // countryInput
            // 
            this.countryInput.BackColor = System.Drawing.Color.Black;
            this.countryInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryInput.ForeColor = System.Drawing.Color.White;
            this.countryInput.Location = new System.Drawing.Point(142, 148);
            this.countryInput.Margin = new System.Windows.Forms.Padding(2);
            this.countryInput.Name = "countryInput";
            this.countryInput.Size = new System.Drawing.Size(73, 26);
            this.countryInput.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 37);
            this.label2.TabIndex = 66;
            this.label2.Text = "Country Initials:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 67;
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageLabel.ForeColor = System.Drawing.Color.White;
            this.errorMessageLabel.Location = new System.Drawing.Point(2, 258);
            this.errorMessageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(260, 26);
            this.errorMessageLabel.TabIndex = 68;
            this.errorMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::XMLWeather.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.errorMessageLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.countryInput);
            this.Controls.Add(this.backLabel);
            this.Controls.Add(this.addCityButton);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.cityInput);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SearchScreen";
            this.Size = new System.Drawing.Size(262, 406);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cityInput;
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Button addCityButton;
        private System.Windows.Forms.Label backLabel;
        private System.Windows.Forms.TextBox countryInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label errorMessageLabel;
    }
}
