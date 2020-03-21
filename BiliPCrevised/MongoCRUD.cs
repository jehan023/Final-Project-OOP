using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiliPC
{
    public class MongoCRUD // Create Read Update Delete
    {
        public IMongoDatabase db;

        public MongoCRUD(string database)
        {
            var client = new MongoClient();
            db = client.GetDatabase(database);
        }

        public void InsertRecord<T>(string table, T record)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(record);
        }
        public bool CheckExistence<T>(string table, string element, string username)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq(element, username);
            if (collection.CountDocuments(filter) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<T> LoadRecords<T>(string table)
        {
            var collection = db.GetCollection<T>(table);

            return collection.Find(new BsonDocument()).ToList();
        }

        public T LoadRecordById<T>(string table, ObjectId id)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);

            return collection.Find(filter).First();
        }

        public List<T> LoadRecordsBySpecific<T>(string table, string element, string specific)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq(element, specific);

            return collection.Find(filter).ToList();
        }

        public void UpsertRecord<T>(string table, ObjectId id, T record)
        {
            var collection = db.GetCollection<T>(table);
            var result = collection.ReplaceOne(
                new BsonDocument("_id", id),
                record,
                new ReplaceOptions{ IsUpsert = true });
        }

        public void DeleleRecord<T>(string table, ObjectId id)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);
            collection.DeleteOne(filter);
        }
    }
}
