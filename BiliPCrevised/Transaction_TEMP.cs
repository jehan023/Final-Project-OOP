using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiliPC
{
    public class Transaction_TEMP
    {
    [BsonId]
    public ObjectId Id { get; set; }

    [BsonElement]
    public string Transaction { get; set; }

    [BsonElement]
    public BsonArray Items { get; set; }

    //[BsonElement]
    //public Object Items { get; set; }

    }
}
