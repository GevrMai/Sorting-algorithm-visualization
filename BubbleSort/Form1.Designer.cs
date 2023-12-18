namespace BubbleSort
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
            userInput = new TextBox();
            label1 = new Label();
            acceptButton = new Button();
            errorLabel = new Label();
            pictureBox = new PictureBox();
            sortButton = new Button();
            msDelayButton = new Button();
            msDelayTextBox = new TextBox();
            delayLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // userInput
            // 
            userInput.Location = new Point(12, 49);
            userInput.MaxLength = 200;
            userInput.Name = "userInput";
            userInput.PlaceholderText = "9 8 6 7 5 4 3 1 2";
            userInput.Size = new Size(350, 27);
            userInput.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(91, 19);
            label1.TabIndex = 1;
            label1.Text = "Enter array";
            // 
            // acceptButton
            // 
            acceptButton.BackColor = Color.White;
            acceptButton.Cursor = Cursors.Hand;
            acceptButton.ForeColor = Color.Green;
            acceptButton.Location = new Point(384, 49);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new Size(98, 27);
            acceptButton.TabIndex = 2;
            acceptButton.Text = "Accept";
            acceptButton.UseVisualStyleBackColor = false;
            acceptButton.Click += inputButton_Click;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(12, 92);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(0, 19);
            errorLabel.TabIndex = 3;
            // 
            // pictureBox
            // 
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(12, 150);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(1870, 795);
            pictureBox.TabIndex = 4;
            pictureBox.TabStop = false;
            // 
            // sortButton
            // 
            sortButton.BackColor = Color.White;
            sortButton.Cursor = Cursors.Hand;
            sortButton.ForeColor = Color.DodgerBlue;
            sortButton.Location = new Point(500, 49);
            sortButton.Name = "sortButton";
            sortButton.Size = new Size(148, 27);
            sortButton.TabIndex = 5;
            sortButton.Text = "Sort";
            sortButton.UseVisualStyleBackColor = false;
            sortButton.Click += sortButton_Click;
            // 
            // msDelayButton
            // 
            msDelayButton.BackColor = Color.White;
            msDelayButton.Cursor = Cursors.Hand;
            msDelayButton.ForeColor = Color.Green;
            msDelayButton.Location = new Point(1141, 49);
            msDelayButton.Name = "msDelayButton";
            msDelayButton.Size = new Size(98, 29);
            msDelayButton.TabIndex = 7;
            msDelayButton.Text = "Accept";
            msDelayButton.UseVisualStyleBackColor = false;
            msDelayButton.Click += msDelayButton_Click;
            // 
            // msDelayTextBox
            // 
            msDelayTextBox.Location = new Point(791, 49);
            msDelayTextBox.MaxLength = 4;
            msDelayTextBox.Name = "msDelayTextBox";
            msDelayTextBox.PlaceholderText = "Render delay (500 ms as default)";
            msDelayTextBox.Size = new Size(328, 27);
            msDelayTextBox.TabIndex = 6;
            // 
            // delayLabel
            // 
            delayLabel.AutoSize = true;
            delayLabel.ForeColor = Color.WhiteSmoke;
            delayLabel.Location = new Point(791, 92);
            delayLabel.Name = "delayLabel";
            delayLabel.Size = new Size(0, 19);
            delayLabel.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1904, 1041);
            Controls.Add(delayLabel);
            Controls.Add(msDelayButton);
            Controls.Add(msDelayTextBox);
            Controls.Add(sortButton);
            Controls.Add(pictureBox);
            Controls.Add(errorLabel);
            Controls.Add(acceptButton);
            Controls.Add(label1);
            Controls.Add(userInput);
            base.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ButtonFace;
            Margin = new Padding(4);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1920, 1080);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Пузырек наглядно";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userInput;
        private Label label1;
        private Button acceptButton;
        private Label errorLabel;
        private PictureBox pictureBox;
        private Button sortButton;
        private Button msDelayButton;
        private TextBox msDelayTextBox;
        private Label delayLabel;
    }
}