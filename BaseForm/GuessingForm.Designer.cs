namespace windowsForm
{
    partial class GuessingForm
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
            panel1 = new Panel();
            ConsoleBox = new Label();
            BBox = new TextBox();
            ABox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            ResultBox = new TextBox();
            ConsoleLabel = new Label();
            QuantityField = new TextBox();
            ReturnButton = new Button();
            ResultLabel = new Label();
            UserAnswerField = new TextBox();
            label2 = new Label();
            CheckingButton = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(ConsoleBox);
            panel1.Controls.Add(BBox);
            panel1.Controls.Add(ABox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(ResultBox);
            panel1.Controls.Add(ConsoleLabel);
            panel1.Controls.Add(QuantityField);
            panel1.Controls.Add(ReturnButton);
            panel1.Controls.Add(ResultLabel);
            panel1.Controls.Add(UserAnswerField);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(CheckingButton);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // ConsoleBox
            // 
            ConsoleBox.AutoSize = true;
            ConsoleBox.Location = new Point(26, 71);
            ConsoleBox.Name = "ConsoleBox";
            ConsoleBox.Size = new Size(0, 20);
            ConsoleBox.TabIndex = 1;
            // 
            // BBox
            // 
            BBox.Location = new Point(570, 12);
            BBox.Name = "BBox";
            BBox.Size = new Size(125, 27);
            BBox.TabIndex = 14;
            // 
            // ABox
            // 
            ABox.Location = new Point(207, 12);
            ABox.Name = "ABox";
            ABox.Size = new Size(125, 27);
            ABox.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(377, 19);
            label4.Name = "label4";
            label4.Size = new Size(176, 20);
            label4.TabIndex = 12;
            label4.Text = "Значение параметра b :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 19);
            label3.Name = "label3";
            label3.Size = new Size(175, 20);
            label3.TabIndex = 11;
            label3.Text = "Значение параметра a :";
            // 
            // ResultBox
            // 
            ResultBox.Location = new Point(154, 384);
            ResultBox.Name = "ResultBox";
            ResultBox.Size = new Size(125, 27);
            ResultBox.TabIndex = 10;
            // 
            // ConsoleLabel
            // 
            ConsoleLabel.AutoSize = true;
            ConsoleLabel.Location = new Point(468, 131);
            ConsoleLabel.Name = "ConsoleLabel";
            ConsoleLabel.Size = new Size(0, 20);
            ConsoleLabel.TabIndex = 9;
            // 
            // QuantityField
            // 
            QuantityField.Location = new Point(268, 124);
            QuantityField.Name = "QuantityField";
            QuantityField.Size = new Size(125, 27);
            QuantityField.TabIndex = 8;
            // 
            // ReturnButton
            // 
            ReturnButton.BackColor = Color.LightSalmon;
            ReturnButton.Location = new Point(645, 392);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(143, 46);
            ReturnButton.TabIndex = 7;
            ReturnButton.Text = "Назад";
            ReturnButton.UseVisualStyleBackColor = false;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.Location = new Point(315, 320);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(0, 20);
            ResultLabel.TabIndex = 6;
            // 
            // UserAnswerField
            // 
            UserAnswerField.Location = new Point(154, 225);
            UserAnswerField.Name = "UserAnswerField";
            UserAnswerField.Size = new Size(125, 27);
            UserAnswerField.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 232);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 3;
            label2.Text = "Ваш ответ :";
            // 
            // CheckingButton
            // 
            CheckingButton.BackColor = Color.LightSalmon;
            CheckingButton.Location = new Point(358, 224);
            CheckingButton.Name = "CheckingButton";
            CheckingButton.Size = new Size(94, 29);
            CheckingButton.TabIndex = 2;
            CheckingButton.Text = "Угадать";
            CheckingButton.UseVisualStyleBackColor = false;
            CheckingButton.Click += CheckingButton_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 131);
            label1.Name = "label1";
            label1.Size = new Size(219, 20);
            label1.TabIndex = 0;
            label1.Text = "Введите количество попыток :";
            // 
            // GuessingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(panel1);
            Name = "GuessingForm";
            Text = "Угадайка";
            Load += GuessingForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label ResultLabel;
        private TextBox UserAnswerField;
        private Label label2;
        private Button CheckingButton;
        private Button ReturnButton;
        private Label ConsoleLabel;
        private TextBox QuantityField;
        private TextBox ResultBox;
        private Label label4;
        private Label label3;
        public TextBox ABox;
        public TextBox BBox;
        private Label ConsoleBox;
    }
}