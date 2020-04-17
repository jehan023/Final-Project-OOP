namespace BiliPC
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public class UsersModel
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement]
        public bool IsAdmin { get; set; }

        [BsonElement]
        public string Name { get; set; }

        [BsonElement]
        public string Username { get; set; }

        [BsonElement]
        public string Password { get; set; }

        [BsonElement]
        public string ContactNo { get; set; }

        [BsonElement]
        public double Salary { get; set; }

        [BsonElement]
        public double Workhours { get; set; }
    }
}
