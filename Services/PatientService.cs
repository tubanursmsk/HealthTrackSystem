using HealthTrackSystem.Utils;
using HealthTrackSystem.Models;
using HealthTrackSystem.Services;
using Microsoft.Identity.Client;
using MongoDB.Driver;
using System.Collections.Generic;

namespace HealthTrackSystem.Services;
public class PatientService
{
    private readonly IMongoCollection<Patient> _patientCollection;

    public PatientService()
    {
        var DB = new HealthTrackerDB();
        _patientCollection = DB.Patients;
    }

    // Yeni hasta ekleme
    public int AddPatient(Patient patient)
    {
        try
        {
            _patientCollection.InsertOne(patient);
            Console.WriteLine("Hasta başarıyla eklendi.");
            return 1;
        }
        catch (Exception ex)
        {
            
            Console.WriteLine($"Hasta eklenirken hata oluştu: {ex.Message}");
            return 0;
        
        }
    }

    // Tüm hastaları listeleme
    public List<Patient> GetAllPatients()
    {
        List<Patient> list = _patientCollection.Find(_ => true).ToList();
        return list;

    }

    // Hastayı ID ile bulma

    public Patient GetPatientById(string id)
    { 
        var filter = Builders<Patient>.Filter.Eq(p => p.PatientId, id);
        var patient = _patientCollection.Find(filter).FirstOrDefault();
        return patient;
    }

 // Hastayı güncelleme
    public bool UpdatePatient(Patient patient)
    {
        var filter = Builders<Patient>.Filter.Eq(item => item.PatientId, patient.PatientId);
        ReplaceOneResult replaceOneResult = _patientCollection.ReplaceOne(filter, patient);
        return replaceOneResult.ModifiedCount > 0;
    }

    // Hastayı silme
    public void DeletePatient(string id)
    {
         _patientCollection.DeleteOne(x => x.PatientId == id);
    }

    
}