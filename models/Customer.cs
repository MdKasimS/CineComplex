namespace CineComplex.Models
{

    public enum UserType
    {
        User,
        Admin
    }

    public class Customer
    {
        private int id;
        private string? _customerId;
        private string? _customerName;
        private string? _city;
        private static Dictionary<int, Customer>? _customers;

        public Customer(string cn, string city)
        {
            CustomerName = cn;
            City = city;
        }

        #region Dictionaries
        public static Dictionary<int, Customer>? Customers { get => _customers; set => _customers = value; }


        #endregion

        public int Id { get => id; set => id = value; }
        public string? CustomerId { get => _customerId; set => _customerId = value; }
        public string? CustomerName { get => _customerName; set => _customerName = value; }
        public string? City { get => _city; set => _city = value; }

        public void DisplayCustomerDetails()
        {
            Console.WriteLine($"Customer ID : {CustomerId}");
            Console.WriteLine($"Customer Name : {CustomerName}");
            Console.WriteLine($"City : {City}");
        }
    }
}