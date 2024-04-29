using CineComplex;
using MongoDB.Driver;
using MongoDB.Bson;


internal class Program
{
    private static void Main(string[] args)
    {
        var client = new MongoClient("mongodb://localhost:27017");//hard coded API
        var database = client.GetDatabase("CineComplex");
        var collection = database.GetCollection<BsonDocument>("Customer");
        
        
        
        
        Application app = new Application();
        app.run();
        
        var docs = collection.Find(new BsonDocument()).Limit(5).ToList();
        Console.WriteLine(client.ListDatabases().ToList());
    }
}