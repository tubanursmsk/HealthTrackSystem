using MongoDB.Driver;
using System;
using System.Collections.Generic;
using HealthTrackSystem.Utils;
using HealthTrackSystem.Models;
using HealthTrackSystem.Services;
using MongoDB.Bson;
using System.Linq;

namespace HealthTrackSystem.Services;

public class HealthRecordService
{
    private readonly IMongoCollection<HealthRecord> _records;

    public HealthRecordService()
    {
        var DB = new HealthTrackerDB();
        _records = DB.HealthRecords;
    }

    public void AddRecord(HealthRecord record)
    {
        _records.InsertOne(record);
    }

// Tüm sağlık kayıtlarını listeleme
    public List<HealthRecord> GetAllRecords(string patientId)
    {
        return _records.Find(r => r.PatientId == patientId).SortByDescending(r => r.Date).ToList();
    }

    public List<HealthRecord> GetRecordsInDateRange(string patientId, DateTime startDate, DateTime endDate)
    {
        return _records.Find(r => r.PatientId == patientId && r.Date >= startDate && r.Date <= endDate).ToList();
    }

    // Son 7 günde alınan nabız ortalaması
    public double GetAveragePulseLast7Days(string PatientId)
    {
        var sevenDaysAgo = DateTime.Now.AddDays(-7);

        var pipeline = new BsonDocument[]
        {
            new BsonDocument("$match", new BsonDocument {
                { "PatientId", PatientId },
                { "Date", new BsonDocument("$gte", sevenDaysAgo) }
            }),
            new BsonDocument("$group", new BsonDocument {
                { "_id", "$PatientId" },
                { "AveragePulse", new BsonDocument("$avg", "$Pulse") }
            })
        };

        var result = _records.Aggregate<BsonDocument>(pipeline).FirstOrDefault();

        return result != null ? result["AveragePulse"].ToDouble() : 0;
    }

    public void DeleteRecord(string recordId)
    {
        _records.DeleteOne(r => r.Id == recordId);
    }

    // en riskli hasta
    public List<string> GetHighRiskPatients()
    {
        var filter = Builders<HealthRecord>.Filter.Or(
            Builders<HealthRecord>.Filter.Gt(r => r.Pulse, 100),
            Builders<HealthRecord>.Filter.Gt(r => r.BloodSugar, 150)
        );

        var riskRecords = _records.Find(filter).ToList();

        // Aynı hastanın birden fazla kaydı varsa grupla
        var grouped = riskRecords
            .GroupBy(r => r.PatientId)
            .Where(g => g.Count() >= 3)
            .Select(g => g.Key)
            .ToList();

        return grouped;
    }

    public string GetMostActivePatientLast7Days()
    {
        var sevenDaysAgo = DateTime.Now.AddDays(-7);

        var pipeline = new BsonDocument[]
        {
        new BsonDocument("$match", new BsonDocument {
            { "Date", new BsonDocument("$gte", sevenDaysAgo) }
        }),
        new BsonDocument("$group", new BsonDocument {
            { "_id", "$PatientId" },
            { "TotalSteps", new BsonDocument("$sum", "$Steps") }
        }),
        new BsonDocument("$sort", new BsonDocument("TotalSteps", -1)),
        new BsonDocument("$limit", 1)
        };

        var result = _records.Aggregate<BsonDocument>(pipeline).FirstOrDefault();
        return result != null ? result["_id"].AsString : null;
    }

    public (double avgPulse, double avgSugar, double avgSteps) GetDoctorHealthSummary(string doctorId)
{
    // Önce bu doktora ait tüm hasta ID'lerini al
    var DB = new HealthTrackerDB();
    var patientCollection = DB.Patients;
    var doctorPatients = patientCollection.Find(p => p.DoctorId == doctorId).ToList();
    var patientIds = doctorPatients.Select(p => p.PatientId).ToList();

    if (!patientIds.Any())
        return (0, 0, 0);

    var filter = Builders<HealthRecord>.Filter.In(r => r.PatientId, patientIds);

    var records = _records.Find(filter).ToList();

    if (!records.Any())
        return (0, 0, 0);

    double avgPulse = records.Average(r => r.Pulse);
    double avgSugar = records.Average(r => r.BloodSugar);
    double avgSteps = records.Average(r => r.Steps);

    return (avgPulse, avgSugar, avgSteps);
}



    



}







