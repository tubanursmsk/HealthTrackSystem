using MongoDB.Driver;
using System.Collections.Generic;
using HealthTrackSystem.Models;
using HealthTrackSystem.Utils;
using HealthTrackSystem.Services;


namespace HealthTrackSystem.Services;

public class DoctorService
{
    private readonly IMongoCollection<Doctor> _doctors;

    public DoctorService()
    {
        var DB = new HealthTrackerDB();
        _doctors = DB.Doctors;
    }

    public List<Doctor> GetAll()
    {
        return _doctors.Find(d => true).ToList();
    }

    public Doctor GetById(string id)
    {
        return _doctors.Find(d => d.DoctorId == id).FirstOrDefault();
    }

    public void Add(Doctor doctor)
    {
        _doctors.InsertOne(doctor);
    }

    public void Update(string id, Doctor updated)
    {
        _doctors.ReplaceOne(d => d.DoctorId == id, updated);
    }

    public void Delete(string id)
    {
        _doctors.DeleteOne(d => d.DoctorId == id);
    }
}
