# BlogV1 — Ekip / Portföy Web Projesi

Modern web standartlarına uygun olarak tasarlanmış, çoklu yazar desteği ve ASP.NET Core Identity ile kullanıcı yetkilendirmesi içeren kapsamlı bir **.NET 8 MVC Blog ve Portföy yönetim sistemidir.**

---

## 🚀 Proje Hakkında

Bu proje, hem zengin bir kullanıcı arayüzü sunmak hem de güvenli ve ölçeklenebilir bir arka plan mimarisi oluşturmak amacıyla **ASP.NET Core MVC (.NET 8)** ile geliştirilmiştir.

- **Kullanıcı Arayüzü:** İçerik ve portföy sergileme bölümü için [DevFolio](https://bootstrapmade.com/devfolio-bootstrap-portfolio-html-template/) teması entegre edilmiştir.
- **Yönetim Paneli:** Sağlam ve esnek yönetim süreçleri için [SB Admin 2](https://startbootstrap.com/theme/sb-admin-2) teması kullanılmıştır.

## ✨ Özellikler

| Özellik | Açıklama |
|---|---|
| 📝 Blog Yönetimi | Blog yazıları oluşturma, düzenleme ve silme |
| 🖼 Proje/Portföy | Proje ekleme, çoklu görsel yükleme ve detay sayfası |
| 👤 Kullanıcı Hesapları | Kayıt, giriş ve profil yönetimi (Identity) |
| 🔐 Admin Paneli | Rol tabanlı erişim kontrolü ile yönetim arayüzü |
| 📬 İletişim Formu | Ziyaretçilerin mesaj göndermesi ve admin panelinden takibi |
| 🧩 Hakkımda Sayfası | Dinamik olarak yönetilebilen hakkımda içeriği |
| 💡 Yetenek (Skill) Yönetimi | Beceri ve yetkinliklerin yönetilmesi |
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
   git clone https://github.com/kullanici-adiniz/blogv1.git
   cd blogv1
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
| `Blog` | Blog yazıları |
| `Contact` | İletişim bilgileri |
| `Details` | Detay sayfası verileri |
| `Message` | Ziyaretçi mesajları |
| `Projects` | Portföy projeleri |
| `ProjectImages` | Projelere ait görseller |
| `Skill` | Yetenek/beceri tanımları |
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
