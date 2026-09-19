namespace CloneCustomer
{
    public static class Validator
    {
        public static bool IsInt32(TextBox textBox)
        {
            if (int.TryParse(textBox.Text, out _))
                return true;

            MessageBox.Show($"{textBox.Tag ?? "Copies"} must be an integer.",
                "Entry Error");
            textBox.Focus();
            return false;
        }
    }
}
