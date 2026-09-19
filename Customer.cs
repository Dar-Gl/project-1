namespace CloneCustomer
{
    public class Customer : ICloneable, IDisplayable
    {
        public Customer() { }

        public Customer(string firstName, string lastName, string email) =>
            (FirstName, LastName, Email) = (firstName, lastName, email);

        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Email { get; set; } = "";

        public object Clone() => MemberwiseClone();

        public string GetDisplayText() => $"{FirstName} {LastName}, {Email}";
    }
}
