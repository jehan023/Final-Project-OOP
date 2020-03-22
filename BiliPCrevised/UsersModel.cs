using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BiliPC
{
    class UsersModel
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement]
        public bool isAdmin { get; set; }
        [BsonElement]
        public string Name { get; set; }
        [BsonElement]
        public string Username { get; set; }
        [BsonElement]
        public string Password { get; set; }
        [BsonElement]
        public double Wage { get; set; }
        [BsonElement]
        public double Workhours { get; set; }
    }
}
