namespace SECTION_B_qestion_1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        // Button click event
        private void btnGreeting_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;

            MessageBox.Show("Hello " + name + "!");
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
