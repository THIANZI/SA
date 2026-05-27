using System;
using System.Windows.Forms;

namespace section_B_greetings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnGreeting_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;

            MessageBox.Show("Hello " + name + "!");
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGreeting_Click_1(object sender, EventArgs e)
        {
            string name = txtName.Text;

            MessageBox.Show("Hello " + name + "!");
        }
    }
}
