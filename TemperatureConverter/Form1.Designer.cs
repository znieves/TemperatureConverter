namespace TemperatureConverter
{
    partial class Form1
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.inputSelectionBox = new System.Windows.Forms.ComboBox();
            this.outputSelectionBox = new System.Windows.Forms.ComboBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.negativeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(12, 40);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.ShortcutsEnabled = false;
            this.inputTextBox.Size = new System.Drawing.Size(121, 22);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
            this.inputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputTextBox_KeyPress);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Enabled = false;
            this.outputTextBox.Location = new System.Drawing.Point(139, 40);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.ShortcutsEnabled = false;
            this.outputTextBox.Size = new System.Drawing.Size(118, 22);
            this.outputTextBox.TabIndex = 1;
            this.outputTextBox.TabStop = false;
            this.outputTextBox.TextChanged += new System.EventHandler(this.outputTextBox_TextChanged);
            // 
            // inputSelectionBox
            // 
            this.inputSelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputSelectionBox.FormattingEnabled = true;
            this.inputSelectionBox.Items.AddRange(new object[] {
            "FAHRENHEIT",
            "CELSIUS",
            "KELVIN"});
            this.inputSelectionBox.Location = new System.Drawing.Point(12, 69);
            this.inputSelectionBox.Name = "inputSelectionBox";
            this.inputSelectionBox.Size = new System.Drawing.Size(121, 24);
            this.inputSelectionBox.TabIndex = 1;
            this.inputSelectionBox.SelectedIndexChanged += new System.EventHandler(this.inputSelectionBox_SelectedIndexChanged);
            // 
            // outputSelectionBox
            // 
            this.outputSelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outputSelectionBox.FormattingEnabled = true;
            this.outputSelectionBox.Items.AddRange(new object[] {
            "FAHRENHEIT",
            "CELSIUS",
            "KELVIN"});
            this.outputSelectionBox.Location = new System.Drawing.Point(139, 69);
            this.outputSelectionBox.Name = "outputSelectionBox";
            this.outputSelectionBox.Size = new System.Drawing.Size(118, 24);
            this.outputSelectionBox.TabIndex = 2;
            this.outputSelectionBox.SelectedIndexChanged += new System.EventHandler(this.outputSelectionBox_SelectedIndexChanged);
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(291, 68);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(291, 97);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(291, 125);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // negativeButton
            // 
            this.negativeButton.Location = new System.Drawing.Point(291, 40);
            this.negativeButton.Name = "negativeButton";
            this.negativeButton.Size = new System.Drawing.Size(75, 23);
            this.negativeButton.TabIndex = 3;
            this.negativeButton.Text = "+/-";
            this.negativeButton.UseVisualStyleBackColor = true;
            this.negativeButton.Click += new System.EventHandler(this.negativeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 160);
            this.Controls.Add(this.negativeButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.outputSelectionBox);
            this.Controls.Add(this.inputSelectionBox);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.inputTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "TempConverter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void InputTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.ComboBox inputSelectionBox;
        private System.Windows.Forms.ComboBox outputSelectionBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button negativeButton;
    }
}

