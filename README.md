# Marka Ürün Yönetim Sistemi

Bu projede, markaların kendi ürünlerini sisteme ekleyerek ürün özelliklerini tanımlayabildiği, müşterilerin bu ürünleri görüntüleyebildiği ve kullanıcı rollerine göre yetkilendirilmiş işlemler yapabildiği bir e-ticaret yönetim sistemi geliştirilmiştir. Proje, .NET 6 ve Entity Framework Core teknolojileri ile geliştirilmiştir.

## 🚀 Proje Tanımı

- Aynı ürünün farklı özelliklerine göre (renk, boyut, vb.) indirim uygulanabilir.
- Müşteriler ürünleri listeleyebilir, detaylarını görebilir.
- Yönetici kullanıcılar ürün ekleyebilir ve düzenleyebilir.

## 🛠️ Teknolojiler ve Gereksinimler

- Katmanlı Mimari
- SOLID prensiplerine uygunluk
- Repository Pattern
- Entity Framework Core (.NET 6)
- Firebird
- Identity ile kullanıcı yönetimi

## 🧱 Veritabanı Kuralları

- Entity ve Entity Configuration sınıfları tanımlanmalıdır.
- Migration işlemleriyle veritabanı oluşturulmalıdır.
- Veriler fake data ile doldurulmalıdır.

## 👥 Kullanıcı Giriş Ekranı

- Identity kullanılarak kullanıcı girişi yapılmalıdır.
- Yanlış girişlerde hata mesajları gösterilmelidir.
- Giriş başarılı ise ürün listeleme sayfasına yönlendirme yapılmalıdır.
- Kullanıcının rolü, yönlendirildiği sayfada görünmelidir.

## 🔐 Kullanıcı Roller

- **Admin:** Tüm işlemleri yapabilir.
- **BrandOwner:** Sadece kendi markasına ait işlemleri yapabilir.
- **Customer:** Ürünleri görüntüleyebilir, satın alma ve yorum işlemleri yapabilir.





---

## 📂 Kurulum

1. Bu projeyi klonlayın:
