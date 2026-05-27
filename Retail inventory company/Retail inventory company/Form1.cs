namespace Retail_inventory_company
{
    public partial class Form1 : Form
    {
        Dictionary<string, (string Make, int Quantity)> phones =
            new Dictionary<string, (string, int)>();



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (txtCode.Text == "" || txtMake.Text == "" || txtQuantity.Text == "")
            {
                lblOutput.Text = "All fields are required";
                return;
            }

            int qty;

            
            if (!int.TryParse(txtQuantity.Text, out qty))
            {
                lblOutput.Text = "Quantity must be numeric";
                return;
            }

           
            phones[txtCode.Text] = (txtMake.Text, qty);

            lblOutput.Text = "Record Added";

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
            if (phones.ContainsKey(txtCode.Text))
            {
                phones.Remove(txtCode.Text);

                lblOutput.Text = "Record Deleted";
            }
            else
            {
                lblOutput.Text = "Record NOT Found";
            }

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            
            if (phones.ContainsKey(txtCode.Text))
            {
                txtMake.Text = phones[txtCode.Text].Make;
                txtQuantity.Text = phones[txtCode.Text].Quantity.ToString();

                lblOutput.Text = "Record Found";
            }
            else
            {
                lblOutput.Text = "Record NOT Found";
            }


        }
    }
}
