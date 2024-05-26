using MongoDB.Driver;
using MongoDB.Bson;
using CineComplex.Views;


internal class Program
{
    private static void Main(string[] args)
    {
        var client = new MongoClient("mongodb://localhost:27017");//hard coded API
        var database = client.GetDatabase("CineComplex");
        var collection = database.GetCollection<BsonDocument>("Customer");
        
        
        
        
        HomeView app = new HomeView();
        app.run();
        
        var docs = collection.Find(new BsonDocument()).Limit(5).ToList();
        Console.WriteLine(client.ListDatabases().ToList());
    }
}