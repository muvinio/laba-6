namespace windowsForm
{
    partial class AuthorInfoForm
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
            ReturnButton = new Button();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(ReturnButton);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // ReturnButton
            // 
            ReturnButton.BackColor = Color.IndianRed;
            ReturnButton.Cursor = Cursors.Hand;
            ReturnButton.ForeColor = Color.Black;
            ReturnButton.Location = new Point(600, 390);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(188, 48);
            ReturnButton.TabIndex = 1;
            ReturnButton.Text = "Назад";
            ReturnButton.UseVisualStyleBackColor = false;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Bottom;
            textBox1.Location = new Point(0, 43);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(800, 407);
            textBox1.TabIndex = 0;
            textBox1.Text = "Иринин Александр Сергеевич 6106-090301";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // AuthorInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(panel1);
            Name = "AuthorInfoForm";
            Text = "Информация об авторе";
            Load += AuthorInfoForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Button ReturnButton;
    }
}