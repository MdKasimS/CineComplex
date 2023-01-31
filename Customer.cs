namespace CineComplex
{
    public class Customer
    {
        private int ?CustomerID;
        private string ?CustomerName;
        private string ?City;

        public int? CustomerID1 { get => CustomerID; set => CustomerID = value; }
        public string? CustomerName1 { get => CustomerName; set => CustomerName = value; }

        public Customer()
        {
            Console.WriteLine("I am Customer");
        }
        public Customer(string cn, string city)
        {
            CustomerName1 = cn;
            City = city;
        }
        public void setCustomerName(string cn){
            CustomerName1 = cn;
        }
        public string ?getCustomerName(){
            return CustomerName1;
        }

        public void setCity(string city){
            City = city;
        }
        public string ?getCity(){
            return City;
        }

        public void setCustomerId(int cid){
            CustomerID1 = cid;
        }
        public int ?getCutomerId(){
            return CustomerID1;
        }

        public void DisplayCustomerDetails(){
            Console.WriteLine($"Customer ID : {getCutomerId()}");
            Console.WriteLine($"Customer Name : {getCustomerName()}"
            );
            Console.WriteLine($"City : {getCity()}");
        }
    }
}