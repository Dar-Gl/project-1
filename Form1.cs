namespace CloneCustomer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Customer customer = null!;

        private void Form1_Load(object sender, EventArgs e)
        {
            customer = new("John", "Mendez", "jmendez@msysco.com");
            lblCustomer.Text = customer.GetDisplayText();
            txtCopies.Tag = "Copies";
        }

        private CustomList<IDisplayable> MakeCopiesForDisplay(
            ICloneable cloneable, int copies)
        {
            CustomList<IDisplayable> displayables = new();

            for (int i = 0; i < copies; i++)
            {
                object copy = cloneable.Clone();
                if (copy is IDisplayable displayable)
                    displayables.Add(displayable);
            }

            return displayables;
        }

        private void btnClone_Click(object sender, EventArgs e)
        {
            if (Validator.IsInt32(txtCopies))
            {
                int copies = Convert.ToInt32(txtCopies.Text);
                CustomList<IDisplayable> customers =
                    MakeCopiesForDisplay(customer, copies);

                lstCustomers.Items.Clear();
                foreach (IDisplayable item in customers)
                {
                    lstCustomers.Items.Add(item.GetDisplayText());
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
