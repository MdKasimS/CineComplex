namespace CineComplex
{
    public class Customer
    {
        private int ? _customerId;
        private string ? _customerName;
        private string ? _city;
        public Customer(string cn, string city)
        {
            CustomerName = cn;
            City = city;
        }

        public string? CustomerName { get => _customerName; set => _customerName = value; }
        public int? CustomerId { get => _customerId; set => _customerId = value; }
        public string? City { get => _city; set => _city = value; }

        public void DisplayCustomerDetails(){
            Console.WriteLine($"Customer ID : {CustomerId}");
            Console.WriteLine($"Customer Name : {CustomerName}"
            );
            Console.WriteLine($"City : {City}");
        }
    }
}