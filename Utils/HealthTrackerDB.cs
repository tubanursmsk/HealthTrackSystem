using MongoDB.Driver;
using HealthTrackSystem.Models;
using HealthTrackSystem.Services;

namespace HealthTrackSystem.Utils
{
    public class HealthTrackerDB
    {
        private readonly string connectionString = "mongodb://localhost:27017";
        private readonly string databaseName = "HealthTrackerDB";
        private readonly IMongoDatabase _database;

        public HealthTrackerDB()
        {
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase(databaseName);
        }

        public IMongoCollection<T> GetCollection<T>(string collectionName)
        {
            return _database.GetCollection<T>(collectionName);
        }

        public IMongoCollection<Doctor> Doctors => _database.GetCollection<Doctor>("Doctors");
        public IMongoCollection<Patient> Patients => _database.GetCollection<Patient>("Patients");
        public IMongoCollection<HealthRecord> HealthRecords => _database.GetCollection<HealthRecord>("HealthRecords");
    }
}
