using MongoDB.Driver;
using MongoDB.Bson;
using DatabaseTest.Models;

namespace DatabaseTest
{
    public class MongoDAO
    {
        MongoClient _client;

        public MongoDAO()
        {
            _client = new MongoClient("mongodb+srv://admin:T00lCh3st@cluster0.hbwtbtx.mongodb.net/");
        }

        public string readAllDocuments()
        {
            var db = _client.GetDatabase("bookstore");
            var coll = db.GetCollection<Book>("books");

            var result = coll.Find(new BsonDocument()).First();
            return result.ToJson().ToString();
        }
    }
}
