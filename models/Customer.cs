namespace CineComplex.Models
{

    public enum UserType
    {
        User,
        Admin
    }

    public class Customer
    {

        public Customer(string cn, string city)
        {
            CustomerName = cn;
            City = city;
        }

        #region Dictionaries
        public static Dictionary<int, Customer>? Customers { get ; set; }


        #endregion

        public int Id { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string City { get; set; }

        public void DisplayCustomerDetails()
        {
            Console.WriteLine($"Customer ID : {CustomerId}");
            Console.WriteLine($"Customer Name : {CustomerName}");
            Console.WriteLine($"City : {City}");
        }
    }
}