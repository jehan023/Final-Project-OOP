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
        public string Items { get; set; }

        [BsonElement]
        public BsonDateTime DateOfPurchase { get; set; }

        [BsonElement]
        public string Employee { get; set; }

        [BsonElement]
        public double TCIS { get; set; }

        [BsonElement]
        public double TRA { get; set; }

        // Net sales
        // Gross Margin = Net Sales - TCIS
        // Net Profit = Gross Margin - EmployeeSalary[wage * workhours]
        // Profit Percentage ((SellingPrice - CostPrice) * 100) / CostPrice --> ((TRA - TCIS) * 100) / TCIS
    }
}
