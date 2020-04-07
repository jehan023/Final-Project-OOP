namespace BiliPC
{
    using System;
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public class TrackEmployeesModel
    {
        [BsonElement]
        public ObjectId Id { get; set; }

        [BsonElement]
        public ObjectId AcctId { get; set; }

        [BsonElement]
        public string AcctName { get; set; }

        [BsonElement]
        public bool LoggedIn { get; set; }

        [BsonElement]
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime Date { get; set; }

        [BsonElement]
        public double TotalWorkHours { get; set; }

        [BsonElement]
        public double Salary { get; set; }
    }
}
