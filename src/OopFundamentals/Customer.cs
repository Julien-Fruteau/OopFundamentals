namespace OopFundamentals
{
    public class Customer
    {
        public static int CustomerId { get; private set; }
        public string FirstName { get; set; }
        private string _lastName;
        public string LastName
        {
            get => _lastName;
            set
                {
                    if (!Validate(value))
                        _lastName = value;
                    else
                        _lastName = "Doe";
                }
        }
        public string FullName { get => $"{FirstName} {LastName}"; }

        public Customer(string firstName, string lastName)
        {
            CustomerId++;
            FirstName = firstName;
            LastName = lastName;
        }

        public bool Validate(string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }
    }
}