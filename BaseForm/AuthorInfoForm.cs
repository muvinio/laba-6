using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseForm;

namespace windowsForm
{
    public partial class AuthorInfoForm : Form
    {
        public AuthorInfoForm()
        {
            InitializeComponent();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void AuthorInfoForm_Load(object sender, EventArgs e)
        {

        }
    }

}
