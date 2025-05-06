# 🩺 HealthTrackSystem

**HealthTrackSystem**, C# dili ve MongoDB veritabanı kullanılarak geliştirilen bir konsol tabanlı sağlık takip sistemidir. Hasta bilgileri, sağlık verileri (adım sayısı, nabız, kan şekeri) kaydedilir ve gelişmiş sorgularla analiz edilir.

---

## 🚀 Özellikler

- 👤 Hasta & Doktor yönetimi
- 📅 Günlük sağlık verisi kaydı (adım sayısı, nabız, şeker)
- 📈 Son 7 günlük adım analizi
- ⚠ Anormal sağlık verisi tespiti (yüksek/düşük nabız & şeker)
- 📤 CSV formatında dışa aktarma
- 🔎 İleri seviye MongoDB sorguları
- 🔁 Katmanlı mimari: `Entities`, `DataAccess`, `Business`, `Presentation`

---

## 🧱 Katman Yapısı

HealthTrackSystem/
│
├── Entities/ # Veri modelleri
├── DataAccess/ # MongoDB bağlantıları ve CRUD işlemleri
├── Business/ # Servis katmanı (iş kuralları)
├── Presentation/ # Program.cs (konsol arayüzü)
├── README.md

---

## 💻 Kullanım

1. MongoDB kurulu olmalı (lokal ya da MongoDB Atlas)
2. Projeyi klonlayın:

```indir
git clone https://github.com/tubanursmsk/HealthTrackSystem.git
cd HealthTrackSystem

3.MongoDBSettings.cs içinde bağlantı bilgilerini güncelleyin.

4.Uygulamayı çalıştırın:
dotnet build
dotnet run

---

## 🧪 Örnek Fonksiyonlar

✅ Hasta ekleme

✅ Günlük sağlık verisi girişi

✅ En aktif hasta analizi

✅ Adım ortalaması, maksimum & minimum değerler

✅ CSV dışa aktarma (patients.csv)

✅ Anormal sağlık kayıtlarının listelenmesi

---

📷 Konsol Görüntüsü (örnek)

12. Hastanın Son 7 Günlük Adım Analizini Göster
Hasta ID'si: 6650b77e524a88cb457adb3e

📊 Son 7 Günlük Adım Analizi:
2025-05-01: 3480 adım
2025-05-02: 7520 adım
...

Günlük Ortalama: 5010 adım
En Çok Adım: 7520 (2025-05-02)
En Az Adım: 3480 (2025-05-01)


---


📦 Teknolojiler

C# (.NET 9)
MongoDB (NoSQL)
ADO.NET
MongoDB Driver
Visual Studio Code











