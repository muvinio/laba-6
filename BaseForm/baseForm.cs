using windowsForm;

namespace BaseForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void GuessAnswerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuessAnswerForm guessAnswerForm = new GuessAnswerForm();
            guessAnswerForm.Show();
        }

        private void AuthorInfoButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthorInfoForm authorInfoForm = new AuthorInfoForm();
            authorInfoForm.Show();
        }

        private void SortingArraysButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SortingArraysForm sortingArraysForm = new SortingArraysForm();
            sortingArraysForm.Show();
        }

        private void MagicSquareButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MagicSquareForm magicSquareForm = new MagicSquareForm();
            magicSquareForm.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExitButtonForm exitForm = new ExitButtonForm();
            exitForm.Show();
             
        }
    }
}
