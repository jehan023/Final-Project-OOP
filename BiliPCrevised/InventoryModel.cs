using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiliPC
{
    class InventoryModel
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement]
        public string Item { get; set; }
        [BsonElement]
        public int Quantity { get; set; }
        [BsonElement]
        public double UnitPrice { get; set; }
        [BsonElement]
        public double Cost { get; set; }
        [BsonElement]
        public string Category { get; set; }
        [BsonElement]
        public string Supplier { get; set; }
        
    }
}
