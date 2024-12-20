namespace windowsForm
{
    partial class MagicSquareForm
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
            panel2 = new Panel();
            CheckButton = new Button();
            ConsoleBox = new TextBox();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            ReturnButton = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Info;
            panel2.Controls.Add(CheckButton);
            panel2.Controls.Add(ConsoleBox);
            panel2.Controls.Add(dataGridView2);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(ReturnButton);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 450);
            panel2.TabIndex = 1;
            // 
            // CheckButton
            // 
            CheckButton.Location = new Point(90, 323);
            CheckButton.Name = "CheckButton";
            CheckButton.Size = new Size(94, 29);
            CheckButton.TabIndex = 6;
            CheckButton.Text = "button1";
            CheckButton.UseVisualStyleBackColor = true;
            CheckButton.Click += CheckButton_Click;
            // 
            // ConsoleBox
            // 
            ConsoleBox.Location = new Point(67, 234);
            ConsoleBox.Name = "ConsoleBox";
            ConsoleBox.Size = new Size(248, 27);
            ConsoleBox.TabIndex = 5;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.BackgroundColor = SystemColors.Info;
            dataGridView2.ColumnHeadersHeight = 29;
            dataGridView2.ColumnHeadersVisible = false;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1 });
            dataGridView2.Location = new Point(299, 63);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(51, 90);
            dataGridView2.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "1";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = SystemColors.Info;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(356, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(379, 118);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "1";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Resizable = DataGridViewTriState.False;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "2";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Resizable = DataGridViewTriState.False;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "3";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Resizable = DataGridViewTriState.False;
            Column3.Width = 125;
            // 
            // ReturnButton
            // 
            ReturnButton.BackColor = Color.IndianRed;
            ReturnButton.Location = new Point(639, 369);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(149, 69);
            ReturnButton.TabIndex = 2;
            ReturnButton.Text = "Назад";
            ReturnButton.UseVisualStyleBackColor = false;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // MagicSquareForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MagicSquareForm";
            Text = "Магический квадрат";
            Load += MagicSquareForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        public DataGridView dataGridView1;
        private Button ReturnButton;
        public DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button CheckButton;
        private TextBox ConsoleBox;
    }
}