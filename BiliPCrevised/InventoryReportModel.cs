namespace BiliPC
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public class InventoryReportModel
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement]
        public string Item { get; set; }

        [BsonElement]
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime DateModified { get; set; }

        [BsonElement]
        public string Category { get; set; }

        [BsonElement]
        public string Status { get; set; }

        [BsonElement]
        public double Cost { get; set; }

        [BsonElement]
        public double RetailAmount { get; set; }

        [BsonElement]
        public string Supplier { get; set; }
    }
}
