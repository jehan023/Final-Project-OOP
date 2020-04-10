namespace BiliPC
{
    using System;
    using System.Collections.Generic;
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

        public bool CheckExistenceByGeneric<T, TU>(string table, string element, TU specific)
        {
            var collection = this.db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq(element, specific);
            if (collection.CountDocuments(filter) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public T LoadRecordsByGenericT<T, TU>(string table, string element, TU specific)
        {
            var collection = this.db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq(element, specific);

            return collection.Find(filter).First();
        }

        public T LoadRecordByGenericSortedT<T, TU>(string table, string element, TU specific, string sortingElement)
        {
            var collection = this.db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq(element, specific);
            var builder = Builders<T>.Sort;
            var sort = builder.Descending(sortingElement);

            return collection.Find(filter).Sort(sort).First();
        }

        public List<T> LoadRecords<T>(string table)
        {
            var collection = this.db.GetCollection<T>(table);

            return collection.Find(new BsonDocument()).ToList();
        }

        public List<T> LoadRecordsByGenericList<T, TU>(string table, string element, TU specific)
        {
            var collection = this.db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq(element, specific);

            return collection.Find(filter).ToList();
        }

        public List<T> LoadRecordsByCaseInsensitive<T>(string table, string element, string specific)
        {
            var collection = this.db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Regex(element, new BsonRegularExpression(specific, "i"));

            return collection.Find(filter).ToList();
        }

        public List<T> LoadRecordsByMonthList<T>(string table, string element, int year, int month)
        {
            var collection = this.db.GetCollection<T>(table);
            int lastDay = DateTime.DaysInMonth(year, month);
            var start = new DateTime(year, month, 01, 0, 0, 0).ToUniversalTime();
            var end = new DateTime(year, month, lastDay, 23, 59, 59).ToUniversalTime();

            var filterBuilder = Builders<T>.Filter;
            var filter = filterBuilder.Gte(element, start) & filterBuilder.Lte(element, end);

            return collection.Find(filter).ToList();
        }

        public List<T> LoadRecordsByMonthList<T>(string table, string element, int year, int month, int dayStart, int dayEnd)
        {
            var collection = this.db.GetCollection<T>(table);
            var start = new DateTime(year, month, dayStart, 0, 0, 0).ToUniversalTime();
            var end = new DateTime(year, month, dayEnd, 23, 59, 59).ToUniversalTime();

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
