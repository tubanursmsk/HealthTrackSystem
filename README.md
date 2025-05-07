## 🩺 HealthTrackSystem

**HealthTrackSystem**, C# ve MongoDB kullanılarak geliştirilen, katmanlı mimari yapısına sahip bir **sağlık takip sistemidir**.  
Proje, **günlük sağlık verilerini kayıt altına alma**, **analiz etme** ve **riskli durumları tespit etme** amacıyla gerçek dünya senaryosuna uygun olarak tasarlanmıştır.
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


# 🧱 Katman Yapısı

HealthTrackSystem/
---
├── Entities/         # Veri modelleri
---
├── DataAccess/       # MongoDB bağlantıları ve CRUD işlemleri
---
├── Business/         # Servis katmanı (iş kuralları)
---
├── Presentation/     # Program.cs (konsol arayüzü)
---
└── README.md
---


---

## 💻 Kullanım

1. MongoDB kurulu olmalı (lokal ya da MongoDB Atlas)
2. Projeyi klonlayın:

```indir
git clone https://github.com/tubanursmsk/HealthTrackSystem.git
```
```
cd HealthTrackSystem
```


3.HealthTrack.cs içinde bağlantı bilgilerini güncelleyin.
4.Uygulamayı çalıştırın:
```
dotnet build
```

```
dotnet run
```

### 🔗 VSCode terminalinde bunlardan birini eklemeyi unutma: 

```
dotnet add package MongoDB.Driver
```
- MongoDB.Driver: MongoDB veritabanıyla çalışmak için gerekli .NET kütüphanesidir.

```
dotnet add package MongoDB.Driver --version 3.4.0
```
- -version 3.4.0: Belirli bir sürümü yükler, ama bu sürüm güncel değilse hata alabilir ya da bazı yeni özellikleri kullanamazsın.


---

## 🧪 Örnek Fonksiyonlar

✅ Hasta ekleme

✅ Günlük sağlık verisi girişi

✅ En aktif hasta analizi

✅ Adım ortalaması, maksimum & minimum değerler

✅ CSV dışa aktarma (patients.csv)

✅ Anormal sağlık kayıtlarının listelenmesi

---

📷 Konsol Görüntüleri

1. Hasta Ekle

<img width="164" alt="hastaekle" src="https://github.com/user-attachments/assets/772966e8-5c44-4c02-90bb-e394aa2321c9" />


2. Tüm Hastaları Listele

<img width="160" alt="tümhastaları listele" src="https://github.com/user-attachments/assets/64d2814b-c43b-448c-9c98-e095bba50ec7" />


3. Sağlık Verisi Ekle

<img width="179" alt="sağlıkverisiekle" src="https://github.com/user-attachments/assets/33a8ae30-b592-43f3-8ae9-b439afa83882" />

4. Hastanın Sağlık Verilerini Listele

<img width="253" alt="hastasağlıkverisilistele" src="https://github.com/user-attachments/assets/7141702f-d3e2-4ab7-bc35-c611088721f2" />

5. Hastanın Son 7 Günlük Ortalama Nabzı

<img width="200" alt="hastanın7günort" src="https://github.com/user-attachments/assets/4b018168-6d5d-4335-b110-db995f9c648e" />

6. Doktor Ekle

<img width="278" alt="doktorekle" src="https://github.com/user-attachments/assets/7585e982-9873-4b20-bedc-23646d7b209c" />

7. Doktorları Listele

<img width="237" alt="doktorlistele" src="https://github.com/user-attachments/assets/bd5c70cf-0843-4eb5-9744-82b9a1a50aa1" />

8. Riskli Hastaları Listele

<img width="433" alt="image" src="https://github.com/user-attachments/assets/ebc84d4c-ffd0-42eb-9e53-cd7b1dd51a0a" />

9. Son 7 Günün En Aktif Hastası
10. Doktora Ait Hastaların Sağlık Özeti

11. Hasta Verilerini CSV Olarak Dışa Aktar

<img width="566" alt="hasta verilerinicvs olarak dışarı aktar" src="https://github.com/user-attachments/assets/e219c881-56cf-42dd-bb6b-31d4c98b1665" />

12. Hastanın Son 7 Günlük Adım 📊 Analizini Göster

<img width="287" alt="Hastanın Son 7 Günlük Adım Analizini Göster" src="https://github.com/user-attachments/assets/61e28e02-cf39-41c0-949a-05d7a213d58c" />

13. Hastanın Anormal Sağlık Verilerini Göster

<img width="253" alt="Hastanın Anormal Sağlık Verilerini Göster" src="https://github.com/user-attachments/assets/a924876e-5d20-4bd6-b6d6-06e880f5c4d3" />
    
0. Çıkış

<img width="245" alt="cıkış" src="https://github.com/user-attachments/assets/f0775fe4-4f67-460c-932e-10e58748929f" />


---

## 📊 🔁 📊 MongoDB Kullanımı

<img width="959" alt="image" src="https://github.com/user-attachments/assets/ab4176bf-b33c-45da-adba-96edde2d8553" />


<img width="960" alt="image" src="https://github.com/user-attachments/assets/1a8c785d-7978-4acf-9818-2ae11cc0c94a" />


<img width="960" alt="image" src="https://github.com/user-attachments/assets/807a1b33-2930-4683-80b8-243987954d5c" />


---

## 📦 Teknolojiler

- C# (.NET 9)
- MongoDB (NoSQL)
- ADO.NET
- MongoDB Driver
- Visual Studio Code

---


## 🧠 Akademik Arka Plan

Bu proje, lisans bitirme tez çalışmam olan  
**"Yapay Zekâ Teknolojileri ile Hastalık Tanısı Koyma"** başlıklı çalışmanın bir devamı ve teknik uygulamasıdır.
📄 [Tez Raporunu Görüntüle (.docx)](Yapay Zekâ Teknolojileri İle Hastalık Tanısı Koyma.docx)


### 🌐 Tezde geliştirdiğim **Tanı Robotu** adlı web uygulaması:

- PHP, JavaScript, HTML ve CSS kullanılarak geliştirilmiştir.
- Semptom tabanlı sorgulama yaparak olası hastalıkları tespit etmeye yönelik çalışır.
- Doktorlar için özel bir yönetim paneli içermektedir.

---


## 🔗 Tanı Robotu Uygulama Ön Yüzü

<img width="519" alt="app" src="https://github.com/user-attachments/assets/29ce80c6-e824-4694-8ce7-0797f220c7fb" />

---

<img width="517" alt="app2" src="https://github.com/user-attachments/assets/91f2a0b3-3872-4c1c-85ef-4c2cd92a4a4e" />


---


## 🔗 Tanı Robotu Yönetim Paneli


<img width="948" alt="1" src="https://github.com/user-attachments/assets/3b4f6889-96d9-4dc9-99ff-48de5658e1d4" />

---

<img width="947" alt="2" src="https://github.com/user-attachments/assets/e70847e8-9775-4cbc-84c0-d104c0e497cd" />

---

<img width="408" alt="3" src="https://github.com/user-attachments/assets/48a85e60-63d2-4925-b478-4b5c00483a73" />


<img width="409" alt="4" src="https://github.com/user-attachments/assets/13b5dc77-5416-4356-a3dc-3892dedb9599" />


---


## 🔗 Entegrasyon

HealthTrackSystem, Tanı Robotu projesine konsol tarafında sağlık verisi takibi ve analiz altyapısı kazandırmak amacıyla geliştirilmiştir.

🔁 **Nasıl entegre edildi?**

- HealthTrackSystem, Tanı Robotu ile entegre edilerek, web üzerinden girilen semptom verilerinin arka planda günlük sağlık verileriyle bağdaştırılmasını ve 
   ileri analizlerin yapılmasını sağlar.
- Web tabanlı tanı sistemi semptomları toplar.
- Kullanıcıya özgü sağlık verileri `HealthTrackSystem` üzerinden MongoDB'de takip edilir.
- Gelişmiş sorgular ile tanı sonrası sağlık durumu analiz edilir.


---


## 🎯 Akademik Katkı

Bu proje hem bir mühendislik uygulaması hem de yapay zekâ destekli karar verme sistemlerine örnek bir prototip sunmaktadır. Akademik olarak:

- Makine öğrenmesi öncesi veri hazırlama (veri temizleme ve analiz)
- Gerçek zamanlı kullanıcı verisi takibi
- Simülasyon ortamı için veri üretimi

---

🏷 Etiketler
`C#` `MongoDB` `Sağlık Takip Sistemi` `Yapay Zekâ` `Bitirme Projesi`  
`Console App` `Katmanlı Mimari` `AI` `Healthcare` `Medical`

