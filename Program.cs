using System;
using HealthTrackSystem.Models;
using HealthTrackSystem.Services;
using HealthTrackSystem.Utils;
using MongoDB.Bson;
using MongoDB.Driver;


namespace HealthTrackSystem
{

    class Program
    {
        static PatientService patientService = new PatientService();
        static HealthRecordService healthService = new HealthRecordService();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== SAĞLIK TAKİP SİSTEMİ ===");
                Console.WriteLine("1. Hasta Ekle");
                Console.WriteLine("2. Tüm Hastaları Listele");
                Console.WriteLine("3. Sağlık Verisi Ekle");
                Console.WriteLine("4. Hastanın Sağlık Verilerini Listele");
                Console.WriteLine("5. Hastanın Son 7 Günlük Ortalama Nabzı");
                Console.WriteLine("6. Doktor Ekle");
                Console.WriteLine("7. Doktorları Listele");
                Console.WriteLine("8. Riskli Hastaları Listele");
                Console.WriteLine("9. Son 7 Günün En Aktif Hastası");
                Console.WriteLine("10. Doktora Ait Hastaların Sağlık Özeti");
                Console.WriteLine("11. Hasta Verilerini CSV Olarak Dışa Aktar");
                Console.WriteLine("12. Hastanın Son 7 Günlük Adım Analizini Göster");
                Console.WriteLine("13. Hastanın Anormal Sağlık Verilerini Göster");
                Console.WriteLine("0. Çıkış");
                Console.Write("Seçiminiz: ");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddPatient();
                        break;
                    case "2":
                        ListPatients();
                        break;
                    case "3":
                        AddHealthRecord();
                        break;
                    case "4":
                        ListHealthRecords();
                        break;
                    case "5":
                        ShowAveragePulse();
                        break;
                    case "6":
                        AddDoctor();
                        break;
                    case "7":
                        ListDoctors();
                        break;
                    case "8":
                        ShowHighRiskPatients();
                        break;
                    case "9":
                        ShowMostActivePatient();
                        break;
                    case "10":
                        ShowDoctorHealthSummary();
                        break;
                    case "11":
                        ExportPatientsToCsv();
                        break;
                    case "12":
                        ShowWeeklyStepAnalysis();
                        break;
                    case "13":
                        ShowAbnormalHealthRecords();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Geçersiz seçim!");
                        break;
                }

                Console.WriteLine("\nDevam etmek için bir tuşa basın...");
                Console.ReadKey();
            }
        }


        // Hasta ekleme ve listeleme işlemleri için metotlar

        static void AddPatient()
        {
            Console.Write("Ad: ");
            string? name = Console.ReadLine();
            Console.Write("Soyad: ");
            string? surname = Console.ReadLine();
            Console.Write("Doğum Tarihi (yyyy-mm-dd): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Cinsiyet: ");
            string? gender = Console.ReadLine();
            Console.Write("Doktor Id: ");
            string? doctorId = Console.ReadLine();

            var patient = new Patient
            {
                Name = name,
                Surname = surname,
                BirthDate = birthDate,
                Gender = gender,
                DoctorId = doctorId,
                RegisteredDate = DateTime.Now
            };

            patientService.AddPatient(patient);
            Console.WriteLine("Hasta başarıyla eklendi.");
        }

        static void ListPatients()
        {
            var patients = patientService.GetAllPatients();
            foreach (var p in patients)
            {
                Console.WriteLine($"{p.PatientId} - {p.Name} {p.Surname}");
            }
        }


        // Sağlık verisi ekleme işlemleri için metotlar

        static void AddHealthRecord()
        {
            Console.Write("Hasta Id: ");
            string? patientId = Console.ReadLine();
            Console.Write("Nabız: ");
            int pulse = int.Parse(Console.ReadLine());
            Console.Write("Tansiyon (örnek: 120/80): ");
            string? bloodPressure = Console.ReadLine();
            Console.Write("Şeker: ");
            int sugar = int.Parse(Console.ReadLine());
            Console.Write("Adım Sayısı: ");
            int steps = int.Parse(Console.ReadLine());

            var record = new HealthRecord
            {
                PatientId = patientId,
                Date = DateTime.Now,
                Pulse = pulse,
                BloodPressure = bloodPressure,
                BloodSugar = sugar,
                Steps = steps
            };

            healthService.AddRecord(record);
            Console.WriteLine("Sağlık verisi başarıyla eklendi.");
        }


        // Sağlık verilerini listeleme işlemleri için metotlar

        static void ListHealthRecords()
        {
            Console.Write("Hasta Id: ");
            string? patientId = Console.ReadLine();
            var records = healthService.GetAllRecords(patientId);

            foreach (var r in records)
            {
                Console.WriteLine($"{r.Date:dd.MM.yyyy HH:mm} - Nabız: {r.Pulse}, Tansiyon: {r.BloodPressure}, Şeker: {r.BloodSugar}, Adım: {r.Steps}");
            }
        }

        static void ShowAveragePulse()
        {
            Console.Write("Hasta Id: ");
            string? patientId = Console.ReadLine();
            var avg = healthService.GetAveragePulseLast7Days(patientId);
            Console.WriteLine($"Son 7 günlük ortalama nabız: {avg:F2}");
        }


        // Doktor ekleme ve listeleme işlemleri için metotlar

        static DoctorService doctorService = new DoctorService();

        static void AddDoctor()
        {
            Console.Write("Ad: ");
            string? name = Console.ReadLine();
            Console.Write("Uzmanlık: ");
            string? specialization = Console.ReadLine();
            Console.Write("Telefon: ");
            string? phone = Console.ReadLine();
            Console.Write("Email: ");
            string? email = Console.ReadLine();

            var doctor = new Doctor
            {
                Name = name,
                Specialization = specialization,
                Phone = phone,
                Email = email
            };

            doctorService.Add(doctor);
            Console.WriteLine("Doktor eklendi.");
        }

        static void ListDoctors()
        {
            var doctors = doctorService.GetAll();
            foreach (var d in doctors)
            {
                Console.WriteLine($"{d.DoctorId} - {d.Name} ({d.Specialization})");
            }
        }


        // Riskli hastaları gösteren metot

        static void ShowHighRiskPatients()
        {
            var riskPatientIds = healthService.GetHighRiskPatients();
            if (riskPatientIds.Count == 0)
            {
                Console.WriteLine("Riskli hasta bulunamadı.");
                return;
            }

            Console.WriteLine("Riskli Hastalar:");
            foreach (var id in riskPatientIds)
            {
                var patient = patientService.GetPatientById(id);
                Console.WriteLine($"{patient.Name} {patient.Surname} - ID: {patient.PatientId}");
            }
        }

        // Son 7 günün en aktif hastasını gösteren metot
        static void ShowMostActivePatient()
        {
            var patientId = healthService.GetMostActivePatientLast7Days();

            if (string.IsNullOrEmpty(patientId))
            {
                Console.WriteLine("Son 7 günde adım verisi bulunamadı.");
                return;
            }

            var patient = patientService.GetPatientById(patientId);
            Console.WriteLine($"En aktif hasta: {patient.Name} {patient.Surname} (ID: {patient.PatientId})");
        }


        // Doktora ait hastaların sağlık özetini gösteren metot
        static void ShowDoctorHealthSummary()
        {
            Console.Write("Doktor Id: ");
            string? doctorId = Console.ReadLine();

            var summary = healthService.GetDoctorHealthSummary(doctorId);

            if (summary.avgPulse == 0 && summary.avgSugar == 0 && summary.avgSteps == 0)
            {
                Console.WriteLine("Bu doktora ait hasta ya da sağlık verisi bulunamadı.");
                return;
            }

            Console.WriteLine($"Doktorun hastaları için sağlık özeti:");
            Console.WriteLine($"Ortalama Nabız: {summary.avgPulse:F2}");
            Console.WriteLine($"Ortalama Kan Şekeri: {summary.avgSugar:F2}");
            Console.WriteLine($"Ortalama Adım: {summary.avgSteps:F2}");
        }


        // Hastaların verilerini CSV dosyasına dışa aktaran metot
        static void ExportPatientsToCsv()
        {
            var patients = patientService.GetAllPatients(); // Bütün hastaları alıyoruz
            Console.Write("CSV dosya adı: ");
            string? fileName = Console.ReadLine();
            ExportHelper.ExportPatientsToCsv(patients, fileName);
        }



        // Son 7 günün adım analizini gösteren metot

        static void ShowWeeklyStepAnalysis()
        {
            Console.Write("Hasta ID'si: ");
            string? patientId = Console.ReadLine();

            var records = healthService.GetAllRecords(patientId)
                .Where(r => r.Date >= DateTime.Now.AddDays(-7))
                .OrderBy(r => r.Date)
                .ToList();

            if (!records.Any())
            {
                Console.WriteLine("Son 7 güne ait adım verisi bulunamadı.");
                return;
            }

            Console.WriteLine("\n📊 Son 7 Günlük Adım Analizi:");
            foreach (var record in records)
            {
                Console.WriteLine($"{record.Date:yyyy-MM-dd}: {record.Steps} adım");
            }

            var average = records.Average(r => r.Steps);
            var max = records.OrderByDescending(r => r.Steps).First();
            var min = records.OrderBy(r => r.Steps).First();

            Console.WriteLine($"\nGünlük Ortalama: {average:F0} adım");
            Console.WriteLine($"En Çok Adım: {max.Steps} ({max.Date:yyyy-MM-dd})");
            Console.WriteLine($"En Az Adım: {min.Steps} ({min.Date:yyyy-MM-dd})");
        }



        // Anormal sağlık kayıtlarını gösteren metot

        static void ShowAbnormalHealthRecords()
        {
            Console.Write("Hasta ID'si: ");
            string? patientId = Console.ReadLine();

            var records = healthService.GetAllRecords(patientId);

            var abnormalRecords = records.Where(r =>
                r.Pulse < 50 || r.Pulse > 120 ||
                r.BloodSugar < 70 || r.BloodSugar > 180
            ).OrderBy(r => r.Date).ToList();

            if (!abnormalRecords.Any())
            {
                Console.WriteLine("Anormal sağlık verisi bulunamadı.");
                return;
            }

            Console.WriteLine("\n🚨 Anormal Sağlık Kayıtları:");
            foreach (var r in abnormalRecords)
            {
                Console.WriteLine($"{r.Date:yyyy-MM-dd} | Nabız: {r.Pulse} | Şeker: {r.BloodSugar} | Adım: {r.Steps}");
            }
        }

    }

}




