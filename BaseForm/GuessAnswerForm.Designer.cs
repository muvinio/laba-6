namespace windowsForm
{
    partial class GuessAnswerForm
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
            UserAnswerField = new TextBox();
            CheckingButton = new Button();
            label4 = new Label();
            QuantityField = new TextBox();
            label3 = new Label();
            ReturnButton = new Button();
            ConsoleBox = new TextBox();
            BFieldValue = new TextBox();
            AFieldValue = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(UserAnswerField);
            panel1.Controls.Add(CheckingButton);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(QuantityField);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(ReturnButton);
            panel1.Controls.Add(ConsoleBox);
            panel1.Controls.Add(BFieldValue);
            panel1.Controls.Add(AFieldValue);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // UserAnswerField
            // 
            UserAnswerField.Location = new Point(117, 203);
            UserAnswerField.Name = "UserAnswerField";
            UserAnswerField.Size = new Size(125, 27);
            UserAnswerField.TabIndex = 15;
            // 
            // CheckingButton
            // 
            CheckingButton.Location = new Point(12, 258);
            CheckingButton.Name = "CheckingButton";
            CheckingButton.Size = new Size(94, 29);
            CheckingButton.TabIndex = 14;
            CheckingButton.Text = "Угадать";
            CheckingButton.UseVisualStyleBackColor = true;
            CheckingButton.Click += CheckingButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 210);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 13;
            label4.Text = "Ваш ответ :";
            // 
            // QuantityField
            // 
            QuantityField.Location = new Point(247, 151);
            QuantityField.Name = "QuantityField";
            QuantityField.Size = new Size(125, 27);
            QuantityField.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 158);
            label3.Name = "label3";
            label3.Size = new Size(212, 20);
            label3.TabIndex = 11;
            label3.Text = "Введите количество попыток";
            // 
            // ReturnButton
            // 
            ReturnButton.BackColor = Color.Brown;
            ReturnButton.Location = new Point(650, 401);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(138, 37);
            ReturnButton.TabIndex = 10;
            ReturnButton.Text = "Назад";
            ReturnButton.UseVisualStyleBackColor = false;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // ConsoleBox
            // 
            ConsoleBox.BackColor = Color.LightGray;
            ConsoleBox.BorderStyle = BorderStyle.None;
            ConsoleBox.Location = new Point(141, 267);
            ConsoleBox.Name = "ConsoleBox";
            ConsoleBox.Size = new Size(344, 20);
            ConsoleBox.TabIndex = 9;
            // 
            // BFieldValue
            // 
            BFieldValue.Location = new Point(517, 109);
            BFieldValue.Name = "BFieldValue";
            BFieldValue.Size = new Size(125, 27);
            BFieldValue.TabIndex = 6;
            // 
            // AFieldValue
            // 
            AFieldValue.Location = new Point(175, 109);
            AFieldValue.Name = "AFieldValue";
            AFieldValue.Size = new Size(125, 27);
            AFieldValue.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(346, 116);
            label2.Name = "label2";
            label2.Size = new Size(148, 20);
            label2.TabIndex = 3;
            label2.Text = "Введите значение b";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 116);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 2;
            label1.Text = "Введите значение a";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Снимок_экрана_2024_12_04_172122;
            pictureBox1.Location = new Point(0, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // GuessAnswerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(panel1);
            Name = "GuessAnswerForm";
            Text = "Угадайка";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        public TextBox AFieldValue;
        private Label label2;
        private Label label1;
        public TextBox BFieldValue;
        private TextBox ConsoleBox;
        private Button ReturnButton;
        private TextBox QuantityField;
        private Label label3;
        private Label label4;
        private Button CheckingButton;
        private TextBox UserAnswerField;
    }
}