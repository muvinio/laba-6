namespace windowsForm
{
    partial class SortingArraysForm
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
            AverageBox = new TextBox();
            MaxElementBox = new TextBox();
            MinElementBox = new TextBox();
            ColouringButton = new Button();
            SearchAverageButton = new Button();
            SearchMaxElementButton = new Button();
            SearchingMinElementButton = new Button();
            SortingButton = new Button();
            ConsoleBox = new TextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            GenerationButton = new Button();
            LengthField = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ReturnButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(ReturnButton);
            panel1.Controls.Add(AverageBox);
            panel1.Controls.Add(MaxElementBox);
            panel1.Controls.Add(MinElementBox);
            panel1.Controls.Add(ColouringButton);
            panel1.Controls.Add(SearchAverageButton);
            panel1.Controls.Add(SearchMaxElementButton);
            panel1.Controls.Add(SearchingMinElementButton);
            panel1.Controls.Add(SortingButton);
            panel1.Controls.Add(ConsoleBox);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(GenerationButton);
            panel1.Controls.Add(LengthField);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // AverageBox
            // 
            AverageBox.Location = new Point(263, 365);
            AverageBox.Name = "AverageBox";
            AverageBox.Size = new Size(125, 27);
            AverageBox.TabIndex = 13;
            // 
            // MaxElementBox
            // 
            MaxElementBox.Location = new Point(263, 318);
            MaxElementBox.Name = "MaxElementBox";
            MaxElementBox.Size = new Size(125, 27);
            MaxElementBox.TabIndex = 12;
            // 
            // MinElementBox
            // 
            MinElementBox.Location = new Point(263, 267);
            MinElementBox.Name = "MinElementBox";
            MinElementBox.Size = new Size(125, 27);
            MinElementBox.TabIndex = 11;
            // 
            // ColouringButton
            // 
            ColouringButton.Location = new Point(12, 409);
            ColouringButton.Name = "ColouringButton";
            ColouringButton.Size = new Size(204, 29);
            ColouringButton.TabIndex = 10;
            ColouringButton.Text = "Выделение цветом";
            ColouringButton.UseVisualStyleBackColor = true;
            ColouringButton.Click += ColouringButton_Click;
            // 
            // SearchAverageButton
            // 
            SearchAverageButton.Location = new Point(12, 363);
            SearchAverageButton.Name = "SearchAverageButton";
            SearchAverageButton.Size = new Size(204, 29);
            SearchAverageButton.TabIndex = 9;
            SearchAverageButton.Text = "Среднее арифметическое";
            SearchAverageButton.UseVisualStyleBackColor = true;
            SearchAverageButton.Click += SearchAverageButton_Click;
            // 
            // SearchMaxElementButton
            // 
            SearchMaxElementButton.Location = new Point(12, 318);
            SearchMaxElementButton.Name = "SearchMaxElementButton";
            SearchMaxElementButton.Size = new Size(204, 29);
            SearchMaxElementButton.TabIndex = 8;
            SearchMaxElementButton.Text = "Найти максимальный";
            SearchMaxElementButton.UseVisualStyleBackColor = true;
            SearchMaxElementButton.Click += SearchMaxElementButton_Click;
            // 
            // SearchingMinElementButton
            // 
            SearchingMinElementButton.Location = new Point(12, 267);
            SearchingMinElementButton.Name = "SearchingMinElementButton";
            SearchingMinElementButton.Size = new Size(204, 29);
            SearchingMinElementButton.TabIndex = 7;
            SearchingMinElementButton.Text = "Найти минимальный";
            SearchingMinElementButton.UseVisualStyleBackColor = true;
            SearchingMinElementButton.Click += SearchingMinElementButton_Click;
            // 
            // SortingButton
            // 
            SortingButton.Location = new Point(12, 223);
            SortingButton.Name = "SortingButton";
            SortingButton.Size = new Size(204, 29);
            SortingButton.TabIndex = 6;
            SortingButton.Text = "Сортировка";
            SortingButton.UseVisualStyleBackColor = true;
            SortingButton.Click += SortingButton_Click;
            // 
            // ConsoleBox
            // 
            ConsoleBox.Location = new Point(406, 2);
            ConsoleBox.Name = "ConsoleBox";
            ConsoleBox.Size = new Size(382, 27);
            ConsoleBox.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10 });
            dataGridView1.Location = new Point(12, 117);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 83);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Column3";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Column4";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Column5";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Column6";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Column7";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.HeaderText = "Column8";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 125;
            // 
            // Column9
            // 
            Column9.HeaderText = "Column9";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 125;
            // 
            // Column10
            // 
            Column10.HeaderText = "Column10";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.Width = 125;
            // 
            // GenerationButton
            // 
            GenerationButton.Location = new Point(232, 40);
            GenerationButton.Name = "GenerationButton";
            GenerationButton.Size = new Size(125, 29);
            GenerationButton.TabIndex = 3;
            GenerationButton.Text = "Генерация";
            GenerationButton.UseVisualStyleBackColor = true;
            GenerationButton.Click += GenerationButton_Click;
            // 
            // LengthField
            // 
            LengthField.Location = new Point(232, 3);
            LengthField.Name = "LengthField";
            LengthField.Size = new Size(125, 27);
            LengthField.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(204, 20);
            label2.TabIndex = 1;
            label2.Text = "По умолчанию (длина = 10)";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(179, 20);
            label1.TabIndex = 0;
            label1.Text = "Введите длину массива :";
            // 
            // ReturnButton
            // 
            ReturnButton.BackColor = Color.Red;
            ReturnButton.Location = new Point(636, 384);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(152, 54);
            ReturnButton.TabIndex = 14;
            ReturnButton.Text = "Назад";
            ReturnButton.UseVisualStyleBackColor = false;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // SortingArraysForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "SortingArraysForm";
            Text = "Сортировка массивов";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button GenerationButton;
        public TextBox LengthField;
        private DataGridView dataGridView1;
        public TextBox ConsoleBox;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private Button ColouringButton;
        private Button SearchAverageButton;
        private Button SearchMaxElementButton;
        private Button SearchingMinElementButton;
        private Button SortingButton;
        public TextBox MaxElementBox;
        public TextBox MinElementBox;
        public TextBox AverageBox;
        private Button ReturnButton;
    }
}