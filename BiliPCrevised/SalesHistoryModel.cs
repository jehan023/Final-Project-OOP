namespace BiliPC
{
    using System.Collections.Generic;
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public class SalesHistoryModel
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement]
        public string Transaction { get; set; }

        [BsonElement]
        public List<Content> Items { get; } = new List<Content>();

        [BsonElement]
        public string TotalCost { get; set; }

        [BsonElement]
        public BsonDateTime DateOfTransaction { get; set; }
    }

#pragma warning disable SA1402 // FileMayOnlyContainASingleType
    public class Content
    {
        [BsonElement]
        public TransactionTempModel ItemsModel { get; set; }
    }
}
