using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace HealthTrackSystem.Models;

public class Patient
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? PatientId { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public DateTime BirthDate { get; set; }
    public string? Gender { get; set; }

    [BsonRepresentation(BsonType.ObjectId)]
    public string? DoctorId { get; set; }

    public DateTime? RegisteredDate { get; set; }
}
