using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace HealthTrackSystem.Models;

public class HealthRecord
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [BsonRepresentation(BsonType.ObjectId)]
    public string? PatientId { get; set; }

    public DateTime Date { get; set; }
    public int Pulse { get; set; } // Nabız
    public string? BloodPressure { get; set; } // Tansiyon Örnek: "120/80"
    public int BloodSugar { get; set; } // Kan Şekeri br: mg/dL
    public int Steps { get; set; } // Günlük adım sayısı
}
