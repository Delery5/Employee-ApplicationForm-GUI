using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harrison_CourseProject_Part2
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult=DialogResult.Cancel;
            this.Hide();
        }

        private void InputForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
