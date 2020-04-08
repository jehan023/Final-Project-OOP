﻿namespace BiliPC
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public class InventoryModel
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement]
        public string Item { get; set; }

        [BsonElement]
        public int Qty { get; set; }

        [BsonElement]
        public double UnitPrice { get; set; }

        [BsonElement]
        public double Cost { get; set; }

        [BsonElement]
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime Date { get; set; }

        [BsonElement]
        public string Category { get; set; }

        [BsonElement]
        public string Supplier { get; set; }

        [BsonElement]
        public bool Status { get; set; }
    }
}
