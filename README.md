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

---


## 🧠 Akademik Arka Plan

Bu proje, **"Yapay Zekâ Teknolojileri ile Hastalık Tanısı Koyma"** başlıklı bitirme tezimin devamı niteliğindedir. 
[Yapay Zekâ Teknolojileri İle Hastalık Tanısı Koyma  .docx](https://github.com/user-attachments/files/20069211/Yapay.Zeka.Teknolojileri.Ile.Hastalik.Tanisi.Koyma.docx)


Tez kapsamında geliştirdiğim:

🌐 **Tanı Robotu**:
Veri kütüphanesinin olduğu uygulama programlama arayüzü ve doktorlar için yönetim panelinden oluşmaktadır. Uygulamayı tasarlarken Php, JavaScript, Html ve CSS ile tasarladığım, kullanıcıların semptomlarını girerek olası hastalıklar hakkında doktorların bilgi alabildiği bir web uygulamasıdır.


🔗 Tanı Robotu Web Sitesi ():
Tanı Robotu Uygulama Ön Yüzü


![image](https://github.com/user-attachments/assets/790e5e7b-63de-4a62-8075-f1c323caa685)

![image](https://github.com/user-attachments/assets/c3a4fc83-85ed-41eb-80a1-3cd97157849e)


Tanı Robotu Yönetim Paneli


![image](https://github.com/user-attachments/assets/32fae6df-265c-4228-b4f0-0a9d1ec66fad)


---

## 🔗 Entegrasyon

HealthTrackSystem, Tanı Robotu projesine konsol tarafında sağlık verisi takibi ve analiz altyapısı kazandırmak amacıyla geliştirilmiştir.

🔁 **Nasıl entegre edildi?**

- Web tabanlı tanı sistemi semptomları toplar.
- Kullanıcıya özgü sağlık verileri `HealthTrackSystem` üzerinden MongoDB'de takip edilir.
- Gelişmiş sorgular ile tanı sonrası sağlık durumu analiz edilir.

---

## 🎯 Akademik Katkı

Bu proje hem bir mühendislik uygulaması hem de yapay zekâ destekli karar verme sistemlerine örnek bir prototip sunmaktadır. Akademik olarak:

- Makine öğrenmesi öncesi veri hazırlama (veri temizleme ve analiz)
- Gerçek zamanlı kullanıcı verisi takibi
- Simülasyon ortamı için veri üretimi











