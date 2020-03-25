namespace BiliPC
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public class TransactionTempModel
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId Id { get; set; }

        [BsonElement]
        public string Item { get; set; }

        [BsonElement]
        public int Quantity { get; set; }

        [BsonElement]
        public double Cost { get; set; }

        [BsonElement]
        public double TotalUnitCost { get; set; }
    }
}
