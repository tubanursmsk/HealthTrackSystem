using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace HealthTrackSystem.Models;

public class Doctor
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? DoctorId { get; set; }

    public string? Name { get; set; }
    public string? Specialization { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
}
