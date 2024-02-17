namespace CurrencyConverter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            inputDollars = new TextBox();
            dollarAndEqualSigns = new Label();
            result = new Label();
            selectingСurrencies = new ComboBox();
            convertButton = new Button();
            SuspendLayout();
            // 
            // inputDollars
            // 
            inputDollars.Font = new Font("Segoe UI", 15F);
            inputDollars.Location = new Point(12, 41);
            inputDollars.Name = "inputDollars";
            inputDollars.Size = new Size(125, 41);
            inputDollars.TabIndex = 0;
            inputDollars.TextChanged += inputDollars_TextChanged;
            // 
            // dollarAndEqualSigns
            // 
            dollarAndEqualSigns.AutoSize = true;
            dollarAndEqualSigns.Font = new Font("Segoe UI", 15F);
            dollarAndEqualSigns.Location = new Point(143, 44);
            dollarAndEqualSigns.Name = "dollarAndEqualSigns";
            dollarAndEqualSigns.Size = new Size(59, 35);
            dollarAndEqualSigns.TabIndex = 1;
            dollarAndEqualSigns.Text = "$ = ";
            // 
            // result
            // 
            result.AutoSize = true;
            result.Font = new Font("Segoe UI", 15F);
            result.Location = new Point(188, 44);
            result.Name = "result";
            result.Size = new Size(28, 35);
            result.TabIndex = 2;
            result.Text = "0";
            // 
            // selectingСurrencies
            // 
            selectingСurrencies.Font = new Font("Segoe UI", 15F);
            selectingСurrencies.FormattingEnabled = true;
            selectingСurrencies.Items.AddRange(new object[] { "EUR", "UAH" });
            selectingСurrencies.Location = new Point(295, 41);
            selectingСurrencies.Name = "selectingСurrencies";
            selectingСurrencies.Size = new Size(92, 43);
            selectingСurrencies.TabIndex = 3;
            // 
            // convertButton
            // 
            convertButton.Font = new Font("Segoe UI", 15F);
            convertButton.Location = new Point(143, 142);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(146, 52);
            convertButton.TabIndex = 4;
            convertButton.Text = "Convert";
            convertButton.UseVisualStyleBackColor = true;
            convertButton.Click += convertButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 225);
            Controls.Add(convertButton);
            Controls.Add(selectingСurrencies);
            Controls.Add(result);
            Controls.Add(dollarAndEqualSigns);
            Controls.Add(inputDollars);
            Name = "Form1";
            Text = "Currency Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputDollars;
        private Label dollarAndEqualSigns;
        private Label result;
        private ComboBox selectingСurrencies;
        private Button convertButton;
    }
}
