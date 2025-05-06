using System.Collections.Generic;
using System.IO;
using System.Text;
using HealthTrackSystem.Models;
using HealthTrackSystem.Utils;

public static class ExportHelper
{
    public static void ExportPatientsToCsv(List<Patient> patients, string fileName)
    {
        var csvDB = new StringBuilder();
        csvDB.AppendLine("Id,Name,Surname,BirthDate,Gender,DoctorId");

        foreach (var patient in patients)
        {
            csvDB.AppendLine($"{patient.PatientId},{patient.Name},{patient.Surname},{patient.BirthDate.ToString("yyyy-MM-dd")},{patient.Gender},{patient.DoctorId}");
        }

        File.WriteAllText(fileName, csvDB.ToString());
        Console.WriteLine($"Hasta verileri başarıyla {fileName} dosyasına aktarıldı.");
    }

    
}
