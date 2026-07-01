# Kişisel Portföy Web Sitesi

Modern web standartlarına uygun olarak tasarlanmış, kişisel portföy sergileme, proje vitrinleme ve dinamik anasayfa/hero alanı yönetimi sunan kapsamlı bir **.NET 8 MVC Portföy Yönetim Sistemidir.**

---

## 🚀 Proje Hakkında

Bu proje, kişisel yetenekleri, projeleri ve deneyimleri profesyonel bir şekilde sergilemek amacıyla **ASP.NET Core MVC (.NET 8)** ile geliştirilmiş bir **kişisel portföy web sitesidir.** Ziyaretçilere etkileyici bir sunum sağlarken, yönetim paneli aracılığıyla içeriklerin kolayca güncellenmesine olanak tanır.

- **Kullanıcı Arayüzü:** Portföy ve proje sergileme bölümü için [DevFolio](https://bootstrapmade.com/devfolio-bootstrap-portfolio-html-template/) teması entegre edilmiştir.
- **Yönetim Paneli:** Sağlam ve esnek yönetim süreçleri için [SB Admin 2](https://startbootstrap.com/theme/sb-admin-2) teması kullanılmıştır.

## 🎯 Hedef Kitle & Kullanım Alanları

Bu proje, özellikle aşağıdaki grupların dijital varlıklarını ve profesyonel kimliklerini sergilemeleri için tasarlanmıştır:

- **Yazılımcılar ve Tasarımcılar:** Geliştirdikleri yazılımları, tasarım portföylerini ve teknik yeteneklerini sergilemek isteyenler.
- **Freelance Çalışanlar:** Hizmetlerini tanıtmak, referans projelerini sunmak ve entegre iletişim formu ile yeni iş teklifleri almak veya iş bağlantıları kurmak isteyenler.
- **İş Arayanlar ve Yeni Mezunlar:** Statik bir PDF özgeçmiş yerine, dinamik ve kolayca güncellenebilir bir dijital web özgeçmişi (Web CV) oluşturmak isteyenler.
- **Eğitim ve Referans Arayanlar:** .NET 8, EF Core Code-First ve Identity tabanlı üyelik sistemlerinin entegrasyonunu incelemek isteyen geliştiriciler.

## ✨ Özellikler

| Özellik | Açıklama |
|---|---|
| 🖼 Proje Vitrini | Projelerinizi çoklu görsel desteğiyle sergileme ve detay sayfaları |
| 🧩 Hakkımda Sayfası | Dinamik olarak yönetilebilen kişisel tanıtım içeriği |
| 💡 Yetenek (Skill) Yönetimi | Beceri ve yetkinliklerinizi görsel olarak sunma |
| 🏠 Anasayfa (Hero) Yönetimi | Anasayfadaki karşılama başlığı, hareketli unvan metinleri ve arka plan görselinin yönetimi |
| 📬 İletişim Formu | Ziyaretçilerin sizinle doğrudan iletişime geçmesi |
| 👤 Kullanıcı Hesapları | Kayıt, giriş ve profil yönetimi (Identity) |
| 🔐 Admin Paneli | Rol tabanlı erişim kontrolü ile yönetim arayüzü |
| 🔗 SEO Dostu URL'ler | SlugHelper ile otomatik URL oluşturma |
| 📦 ViewComponents | Tekrar kullanılabilir arayüz bileşenleri |

## 🛠 Kullanılan Teknolojiler

| Katman | Teknoloji |
|---|---|
| **Backend** | ASP.NET Core MVC (.NET 8.0) |
| **Veritabanı** | MS SQL Server (SQL Express 16) |
| **ORM** | Entity Framework Core 8.0.0 (Code-First) |
| **Kimlik Doğrulama** | ASP.NET Core Identity (Cookie Authentication) |
| **Admin Paneli UI** | SB Admin 2 (Bootstrap 4) |
| **Kullanıcı Arayüzü** | DevFolio (Bootstrap 5) |
| **Frontend** | HTML5, CSS3, jQuery |

## 📋 Ön Gereksinimler

Projeyi çalıştırmadan önce aşağıdaki araçların yüklü olduğundan emin olun:

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) veya üzeri
- [SQL Server Express](https://www.microsoft.com/sql-server/sql-server-downloads) (2022 / LocalDB)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) (önerilen) veya VS Code + C# Dev Kit
- [Git](https://git-scm.com/)

## 📂 Proje Yapısı

```
.
├── BLOKV1.sln                # Visual Studio Solution dosyası
├── README.md                 # Proje dokümantasyonu
├── script.sql                # Tam veritabanı oluşturma scripti (alternatif kurulum)
├── .gitignore                # Git izleme dışı bırakma kuralları
│
├── BLOKV1/                   # Ana ASP.NET Core MVC Projesi
│   ├── Controllers/          # MVC Controller'lar (routing & iş mantığı)
│   │   ├── AboutController.cs
│   │   ├── AccountController.cs
│   │   ├── AdminController.cs
│   │   ├── BlogsController.cs
│   │   ├── ContactController.cs
│   │   ├── ContactMessageController.cs
│   │   ├── DetailsController.cs
│   │   ├── HomeController.cs
│   │   ├── HomePageController.cs
│   │   ├── ProfileController.cs
│   │   └── ProjectsController.cs
│   ├── Models/               # Entity ve ViewModel tanımları
│   │   ├── About.cs
│   │   ├── Blog.cs
│   │   ├── Contact.cs
│   │   ├── Details.cs
│   │   ├── Entity.cs
│   │   ├── Message.cs
│   │   ├── Projects.cs
│   │   ├── ProjectImages.cs
│   │   ├── Skill.cs
│   │   └── ViewModels/
│   ├── Context/              # EF Core veritabanı bağlamı
│   │   └── BlogDbContext.cs
│   ├── Identity/             # Özelleştirilmiş ASP.NET Core Identity
│   │   ├── BlogIdentityDbContext.cs
│   │   ├── BlogIdentityUser.cs
│   │   └── BlogIdentityRole.cs
│   ├── Helper/               # Yardımcı sınıflar
│   │   └── SlugHelper.cs
│   ├── ViewComponents/       # Tekrar kullanılabilir UI bileşenleri
│   │   ├── _ContactMeComponentPartial.cs
│   │   └── _SkillsComponentPartial.cs
│   ├── Views/                # Razor View dosyaları
│   │   ├── About/
│   │   ├── Account/
│   │   ├── Admin/
│   │   ├── Blogs/
│   │   ├── Contact/
│   │   ├── ContactMessage/
│   │   ├── Details/
│   │   ├── HomePage/
│   │   ├── Profile/
│   │   ├── Projects/
│   │   └── Shared/
│   ├── Migrations/           # EF Core migration dosyaları
│   ├── wwwroot/              # Statik dosyalar (CSS, JS, görseller)
│   ├── Program.cs            # Uygulama giriş noktası
│   └── appsettings.json      # Uygulama yapılandırması
│
└── web_template/             # Entegre edilen hazır frontend temaları
    ├── devfolio-1.0.0/       # DevFolio portföy teması
    └── startbootstrap-sb-admin-2-gh-pages/  # SB Admin 2 yönetim teması
```

## ⚙️ Kurulum ve Çalıştırma

### Yöntem 1: Code-First (Migration ile)

1. **Repoyu klonlayın:**
   ```bash
   git clone https://github.com/guneydogukan/Blog-Portfolio.git
   cd Blog-Portfolio
   ```

2. **Bağımlılıkları yükleyin:**
   ```bash
   cd BLOKV1
   dotnet restore
   ```

3. **Veritabanı bağlantı cümlesini güncelleyin:**

   `appsettings.json` dosyasındaki `DefaultConnection` değerini kendi SQL Server instance'ınıza göre düzenleyin:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Data Source=SUNUCU_ADINIZ\\SQLEXPRESS; database=BlogV1; Integrated Security=True; TrustServerCertificate=True;"
     }
   }
   ```

4. **Migration'ları uygulayın:**
   ```bash
   dotnet ef database update
   ```

5. **Projeyi başlatın:**
   ```bash
   dotnet run
   ```

### Yöntem 2: SQL Script ile (Hazır Veritabanı)

Migration yerine, proje kök dizininde bulunan `script.sql` dosyasını doğrudan SQL Server Management Studio (SSMS) üzerinden çalıştırarak veritabanını tüm tablo yapısıyla birlikte oluşturabilirsiniz.

```bash
# SSMS'de "New Query" açıp script.sql içeriğini çalıştırın
# veya sqlcmd ile:
sqlcmd -S SUNUCU_ADINIZ\SQLEXPRESS -i script.sql
```

> **Not:** Bu yöntemde `appsettings.json` içindeki bağlantı cümlesini yine güncellemeniz gerekmektedir.

## 🗄 Veritabanı Modeli

Projede kullanılan temel varlıklar (Entity):

| Model | Açıklama |
|---|---|
| `About` | Hakkımda sayfası içeriği |
| `Projects` | Portföy projeleri |
| `ProjectImages` | Projelere ait görseller |
| `Skill` | Yetenek/beceri tanımları |
| `Blog` | Anasayfa (Hero) karşılama bilgileri (İsim, Unvan/Açıklama, Arka Plan Görseli) |
| `Contact` | İletişim bilgileri |
| `Details` | Detay sayfası verileri |
| `Message` | Ziyaretçi mesajları |
| `Entity` | Ortak taban model (Base Entity) |

## 🔒 Güvenlik Notları

> [!WARNING]
> `appsettings.json` dosyasındaki veritabanı bağlantı cümlesi örnek amaçlı bırakılmıştır. **Canlı ortamda kesinlikle kullanılmamalıdır.**

- **Canlı ortam için:** `Environment Variables`, `dotnet user-secrets` veya Azure Key Vault / AWS Secrets Manager gibi araçlar tercih edilmelidir.
- **Identity yapılandırması:** Şifreleme ve yetki kısıtlamaları yapılandırılmıştır; admin paneline yalnızca **Admin** rolüne sahip hesaplar erişebilir.
- **Cookie Authentication:** Oturum yönetimi cookie tabanlı olarak çalışmaktadır.

## 👥 Katkıda Bulunma

Eğer bu projenin gelişimine katkıda bulunmak isterseniz:

1. Repoyu `fork`'layın
2. Yeni bir dal oluşturun (`git checkout -b feature/YeniEklenti`)
3. Değişikliklerinizi commit'leyin (`git commit -am 'Yeni özellik: Harika eklenti'`)
4. Dalınızı push'layın (`git push origin feature/YeniEklenti`)
5. Bir **Pull Request** başlatın

## 📄 Lisans

Bu proje geliştirme aşamasındadır ve [MIT Lisansı](LICENSE) altında lisanslanmıştır.
