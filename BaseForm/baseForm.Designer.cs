namespace BaseForm
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
            Background = new Panel();
            ExitButton = new Button();
            MagicSquareButton = new Button();
            SortingArraysButton = new Button();
            AuthorInfoButton = new Button();
            GuessAnswerButton = new Button();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            Background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Background
            // 
            Background.BackColor = Color.FromArgb(235, 206, 222);
            Background.Controls.Add(ExitButton);
            Background.Controls.Add(MagicSquareButton);
            Background.Controls.Add(SortingArraysButton);
            Background.Controls.Add(AuthorInfoButton);
            Background.Controls.Add(GuessAnswerButton);
            Background.Controls.Add(pictureBox5);
            Background.Controls.Add(pictureBox4);
            Background.Controls.Add(pictureBox3);
            Background.Controls.Add(pictureBox2);
            Background.Controls.Add(pictureBox1);
            Background.Dock = DockStyle.Fill;
            Background.Location = new Point(0, 0);
            Background.Name = "Background";
            Background.Size = new Size(800, 450);
            Background.TabIndex = 0;
            // 
            // ExitButton
            // 
            ExitButton.Cursor = Cursors.Hand;
            ExitButton.Location = new Point(131, 375);
            ExitButton.Margin = new Padding(15);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(190, 60);
            ExitButton.TabIndex = 14;
            ExitButton.Text = "Выход";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // MagicSquareButton
            // 
            MagicSquareButton.Cursor = Cursors.Hand;
            MagicSquareButton.Location = new Point(131, 285);
            MagicSquareButton.Margin = new Padding(15);
            MagicSquareButton.Name = "MagicSquareButton";
            MagicSquareButton.Size = new Size(190, 60);
            MagicSquareButton.TabIndex = 13;
            MagicSquareButton.Text = "Магический квадрат";
            MagicSquareButton.UseVisualStyleBackColor = true;
            MagicSquareButton.Click += MagicSquareButton_Click;
            // 
            // SortingArraysButton
            // 
            SortingArraysButton.Cursor = Cursors.Hand;
            SortingArraysButton.ForeColor = Color.Black;
            SortingArraysButton.Location = new Point(131, 195);
            SortingArraysButton.Margin = new Padding(15);
            SortingArraysButton.Name = "SortingArraysButton";
            SortingArraysButton.Size = new Size(190, 60);
            SortingArraysButton.TabIndex = 12;
            SortingArraysButton.Text = "Сортировка массивов";
            SortingArraysButton.UseVisualStyleBackColor = true;
            SortingArraysButton.Click += SortingArraysButton_Click;
            // 
            // AuthorInfoButton
            // 
            AuthorInfoButton.Cursor = Cursors.Hand;
            AuthorInfoButton.Location = new Point(131, 105);
            AuthorInfoButton.Margin = new Padding(15);
            AuthorInfoButton.Name = "AuthorInfoButton";
            AuthorInfoButton.Size = new Size(190, 60);
            AuthorInfoButton.TabIndex = 11;
            AuthorInfoButton.Text = "Об авторе";
            AuthorInfoButton.UseVisualStyleBackColor = true;
            AuthorInfoButton.Click += AuthorInfoButton_Click;
            // 
            // GuessAnswerButton
            // 
            GuessAnswerButton.Cursor = Cursors.Hand;
            GuessAnswerButton.Location = new Point(131, 15);
            GuessAnswerButton.Margin = new Padding(15);
            GuessAnswerButton.Name = "GuessAnswerButton";
            GuessAnswerButton.Size = new Size(190, 60);
            GuessAnswerButton.TabIndex = 10;
            GuessAnswerButton.Text = "Угадайка";
            GuessAnswerButton.UseVisualStyleBackColor = true;
            GuessAnswerButton.Click += GuessAnswerButton_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = windowsForm.Properties.Resources._4115235_exit_logout_sign_out_icon;
            pictureBox5.Location = new Point(36, 375);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(72, 60);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = windowsForm.Properties.Resources._9054253_bx_checkbox_square_icon;
            pictureBox4.Location = new Point(36, 285);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(72, 60);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = windowsForm.Properties.Resources._4781833_filter_filters_funnel_list_navigation_icon;
            pictureBox3.Location = new Point(36, 195);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(72, 60);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = windowsForm.Properties.Resources._1564535_customer_user_userphoto_account_person_icon;
            pictureBox2.Location = new Point(36, 105);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(72, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = windowsForm.Properties.Resources._8664833_circle_question_icon;
            pictureBox1.Location = new Point(36, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Background);
            Name = "Form1";
            Text = "Laba 6";
            Background.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Background;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Button MagicSquareButton;
        private Button SortingArraysButton;
        private Button AuthorInfoButton;
        private Button GuessAnswerButton;
        private Button ExitButton;
    }
}
