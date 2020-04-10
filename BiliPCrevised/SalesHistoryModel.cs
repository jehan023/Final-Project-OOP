namespace BiliPC
{
    using System;
    using System.Collections.Generic;
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public class SalesHistoryModel
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement]
        public string TransactionId { get; set; }

        [BsonElement]
        public string Items { get; set; }

        [BsonElement]
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime DateOfPurchase { get; set; }

        [BsonElement]
        public string Employee { get; set; }

        [BsonElement]
        public double TCIS { get; set; }

        [BsonElement]
        public double TRA { get; set; }

        [BsonElement]
        public double NetSales { get; set; }

        [BsonElement]
        public double GrossMargin { get; set; }
    }
}
