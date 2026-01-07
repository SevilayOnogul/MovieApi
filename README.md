# 🎬 ASP.NET Core 8 Web API & MVC – Movie & Series Admin Panel

Bu proje, **ASP.NET Core 8.0** kullanılarak geliştirilen, **çok katmanlı mimariye (Clean Architecture yaklaşımı)** sahip bir web uygulamasıdır.  
Backend tarafında **RESTful Web API**, frontend tarafında ise **ASP.NET Core MVC (WebUI)** kullanılmıştır.

> ⚠️ **Not:** Proje aktif geliştirme aşamasındadır. Yeni özellikler eklenmeye devam edilmektedir.

---

## 🧱 Mimari Yapı

Projede sürdürülebilir ve okunabilir bir yapı hedeflenmiştir:

- **API Katmanı**  
  → Film, dizi, kategori vb. işlemler için RESTful servisler

- **Application / Business Katmanı**  
  → CQRS pattern kullanılarak iş kuralları ve handler yapıları

- **Data Access Katmanı**  
  → Entity Framework Core ile veritabanı işlemleri

- **WebUI (MVC)**  
  → Razor View tabanlı kullanıcı arayüzü

- **Areas (Admin Panel)**  
  → Yönetim ekranlarının ayrıştırıldığı admin modülü

---

## 🛠 Kullanılan Teknolojiler

- C#
- .NET 8.0
- ASP.NET Core Web API
- ASP.NET Core MVC
- Entity Framework Core
- MS SQL Server
- Razor Views
- CQRS Design Pattern
- Dependency Injection
- Area Yapısı (Admin Panel)
- Git & GitHub

---

## 📌 Şu Ana Kadar Yapılanlar

### 🔹 Genel
- Katmanlı mimari yapısı oluşturuldu
- API & MVC (WebUI) entegrasyonu sağlandı
- Dependency Injection yapısı düzenlendi
- Service Registration Extension eklendi

### 🔹 Admin Panel
- Admin Area oluşturuldu
- Admin Layout tasarımı tamamlandı
- Koyu tema ve sinematik admin arayüzü oluşturuldu

### 🔹 Film Modülü
- Film API endpoint’leri yazıldı
- Admin panelinde filmlerin listelenmesi
- Kategori bazlı badge sistemi
- Yayında / Taslak durum yönetimi
- Modern ve sinematik film listeleme ekranı

### 🔹 Dizi Modülü
- Series (Dizi) API yapısı oluşturuldu
- Admin panelinde dizilerin listelenmesi
- Film listesi ile uyumlu tasarımsal düzenlemeler

### 🔹 Diğer
- Razor View – Controller – API bağlantıları sağlandı
- GitHub üzerinden düzenli commit işlemleri yapıldı

---

## 🧪 Devam Eden / Planlanan Çalışmalar

- CRUD işlemlerinin tamamlanması
- Film & dizi ekleme / güncelleme sayfaları
- AI destekli içerik ekleme işlemleri
- Yetkilendirme ve güvenlik yapıları
- Admin panel UX iyileştirmeleri
- Proje içi optimizasyonlar

---

## 📂 Projeyi Çalıştırma

1. Repository’yi klonlayın  
2. Visual Studio ile açın  
3. Gerekli NuGet paketlerini restore edin  
4. Veritabanı bağlantı ayarlarını yapın  
5. Migration işlemlerini uygulayın  
6. Projeyi çalıştırın  

---

## ✍️ Geliştirici Notu

Bu proje, **ASP.NET Core Web API, MVC ve modern backend mimarileri** üzerine pratik kazanmak amacıyla geliştirilmiştir.  
Zamanla yeni özellikler eklenerek geliştirilmeye devam edilecektir.
