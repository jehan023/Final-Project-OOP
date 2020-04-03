namespace BiliPC
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using MongoDB.Bson;
    using MongoDB.Driver;

    public class MongoCRUD // Create Read Update Delete
    {
        private readonly IMongoDatabase db;

        public MongoCRUD(string database)
        {
            var client = new MongoClient();
            this.db = client.GetDatabase(database);
        }

        public void InsertRecord<T>(string table, T record)
        {
            var collection = this.db.GetCollection<T>(table);
            collection.InsertOne(record);
        }

        public bool CheckExistenceByString<T>(string table, string element, string username)
        {
            var collection = this.db.GetCollection<T>(table);
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

        public bool CheckExistenceById<T>(string table, ObjectId id)
        {
            var collection = this.db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);
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
            var collection = this.db.GetCollection<T>(table);

            return collection.Find(new BsonDocument()).ToList();
        }

        public T LoadRecordById<T>(string table, ObjectId id)
        {
            var collection = this.db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);

            return collection.Find(filter).FirstOrDefault();
        }

        public T LoadRecordsByStringT<T>(string table, string element, string specific)
        {
            var collection = this.db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq(element, specific);

            return collection.Find(filter).First();
        }

        public List<T> LoadRecordsByStringList<T>(string table, string element, string specific)
        {
            var collection = this.db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq(element, specific);

            return collection.Find(filter).ToList();
        }

        public List<T> LoadRecordsByMonthListT<T>(string table, string element, int year, int month, int lastDay)
        {
            var collection = this.db.GetCollection<T>(table);
            var start = new DateTime(year, month, 01, 0, 0, 0).ToUniversalTime();
            var end = new DateTime(year, month, lastDay, 23, 59, 59).ToUniversalTime();

            var filterBuilder = Builders<T>.Filter;
            var filter = filterBuilder.Gte(element, start) & filterBuilder.Lte(element, end);

            return collection.Find(filter).ToList();
        }

        public void UpsertRecord<T>(string table, ObjectId id, T record)
        {
            var collection = this.db.GetCollection<T>(table);
            collection.ReplaceOne(
                new BsonDocument("_id", id),
                record,
                new ReplaceOptions { IsUpsert = true });
        }

        public void DeleleRecord<T>(string table, ObjectId id)
        {
            var collection = this.db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);
            collection.DeleteOne(filter);
        }

        public void DropCollection<T>(string table)
        {
            this.db.DropCollection(table);
        }
    }
}
