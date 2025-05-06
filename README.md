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

<img width="519" alt="app" src="https://github.com/user-attachments/assets/29ce80c6-e824-4694-8ce7-0797f220c7fb" />

<img width="517" alt="app2" src="https://github.com/user-attachments/assets/91f2a0b3-3872-4c1c-85ef-4c2cd92a4a4e" />


Tanı Robotu Yönetim Paneli


<img width="948" alt="1" src="https://github.com/user-attachments/assets/3b4f6889-96d9-4dc9-99ff-48de5658e1d4" />

<img width="947" alt="2" src="https://github.com/user-attachments/assets/e70847e8-9775-4cbc-84c0-d104c0e497cd" />

<img width="408" alt="3" src="https://github.com/user-attachments/assets/48a85e60-63d2-4925-b478-4b5c00483a73" />

<img width="409" alt="4" src="https://github.com/user-attachments/assets/13b5dc77-5416-4356-a3dc-3892dedb9599" />

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











