# UsersApp - Todo Application

Modern və responsive todo idarəetmə sistemi ASP.NET Core və Entity Framework istifadə edərək hazırlanmışdır.

## 🚀 Xüsusiyyətlər

### 🔐 Autentifikasiya
- **Qeydiyyat**: Yeni istifadəçi hesabı yaratma
- **Giriş**: Mövcud hesabla daxil olma
- **Parol bərpası**: Email vasitəsilə parol dəyişdirmə
- **Çıxış**: Təhlükəsiz hesabdan çıxış

### ✅ Todo İdarəetməsi
- **Task əlavə etmə**: Yeni tapşırıqlar yaratma
- **Status dəyişdirmə**: Tapşırıqları tamamlanmış/tamamlanmamış kimi işarələmə
- **Silmə**: Lazımsız tapşırıqları silmə
- **Filtrlləmə**: Bütün, aktiv və ya tamamlanmış tapşırıqları görüntüləmə
- **Real-time yeniləmə**: AJAX istifadə edərək səhifə yenilənməsi olmadan əməliyyatlar

### 🎨 UI/UX
- **Dark/Light tema**: Tema dəyişdirmə imkanı
- **Responsive design**: Mobil və desktop cihazlarda optimal görünüm
- **Modern animasiyalar**: Smooth keçidlər və hover effektləri
- **İntuitive interfeys**: İstifadəçi dostu dizayn

## 🛠️ Texnologiyalar

- **Backend**: ASP.NET Core 8.0
- **Database**: SQL Server (Entity Framework Core)
- **Authentication**: ASP.NET Core Identity
- **Frontend**: HTML5, CSS3, JavaScript (Vanilla)
- **Styling**: Bootstrap 5 + Custom CSS
- **AJAX**: Fetch API

## 📋 Tələblər

- .NET 8.0 SDK
- SQL Server (LocalDB və ya SQL Server Express)
- Visual Studio 2022 və ya VS Code

## ⚙️ Quraşdırma

### 1. Repository-ni klonlayın
```bash
git clone <repository-url>
cd UsersApp
```

### 2. Dependency-ləri yükləyin
```bash
dotnet restore
```

### 3. Database connection string-ini yeniləyin
`appsettings.json` faylında öz SQL Server məlumatlarınızı daxil edin:
```json
{
  "ConnectionStrings": {
    "Default": "Server=YOUR_SERVER;Database=ToDoProjectDB;Trusted_Connection=True;TrustServerCertificate=True"
  }
}
```

### 4. Database migration-larını tətbiq edin
```bash
dotnet ef database update
```

### 5. Aplikasiyanı işə salın
```bash
dotnet run
```

Aplikasiya `https://localhost:7014` ünvanında işə düşəcək.

## 📁 Proyekt Strukturu

```
UsersApp/
├── Controllers/
│   ├── AccountController.cs      # Autentifikasiya əməliyyatları
│   ├── HomeController.cs         # Ana səhifə
│   └── TodoController.cs         # Todo əməliyyatları
├── Data/
│   └── AppDbContext.cs           # Database context
├── Models/
│   ├── Users.cs                  # İstifadəçi modeli
│   ├── ToDo.cs                   # Todo modeli
│   └── ErrorViewModel.cs         # Xəta modeli
├── ViewModels/
│   ├── LoginViewModel.cs         # Giriş formu
│   ├── RegisterViewModel.cs      # Qeydiyyat formu
│   ├── ChangePasswordViewModel.cs # Parol dəyişdirmə
│   └── VerifyEmailViewModel.cs   # Email təsdiqi
├── Views/
│   ├── Account/                  # Autentifikasiya səhifələri
│   ├── Home/                     # Ana səhifələr
│   ├── Todo/                     # Todo səhifələri  
│   └── Shared/                   # Paylaşılan layout-lar
└── Program.cs                    # Aplikasiya konfiqurasiyası
```

## 🔧 Əsas Komponentlər

### Identity Konfigurasiyası
```csharp
builder.Services.AddIdentity<Users, IdentityRole>(options =>
{
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 8;
    options.User.RequireUniqueEmail = true;
})
```

### Database Əlaqəsi
Entity Framework Core istifadə edərək SQL Server ilə əlaqə qurulur:
```csharp
builder.Services.AddDbContext<AppDbContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
```

## 🎯 İstifadə

### Qeydiyyat və Giriş
1. Aplikasiyanı açın
2. "Register" linkini klikləyin
3. Ad, email və parol daxil edin
4. Qeydiyyatdan sonra "Login" səhifəsinə yönləndiriləcəksiniz
5. Email və parolunuzla daxil olun

### Todo İdarəetməsi
1. Giriş etdikdən sonra "ToDo" menyusuna keçin
2. Yeni tapşırıq əlavə etmək üçün input sahəsinə yazın və "ADD" düyməsini basın
3. Tapşırığı tamamlamaq üçün checkbox-u klikləyin
4. Silmek üçün "×" düyməsini basın
5. Filtrlləmek üçün "ALL", "ACTIVE" və ya "COMPLETED" tablarını istifadə edin

### Tema Dəyişdirmə
Sağ yuxarı küncdəki tema düyməsini klikləyərək Dark və Light tema arasında keçid edə bilərsiniz.

## 🔒 Təhlükəsizlik

- **CSRF Qorunması**: Bütün POST əməliyyatlarında anti-forgery token-lar istifadə olunur
- **Authorization**: Todo əməliyyatları yalnız daxil olmuş istifadəçilər üçün əlçatandır
- **Data Validation**: Model validation və server-side yoxlamalar
- **XSS Qorunması**: HTML encoding və təmiz JavaScript

## 🤝 Töhfə vermək

1. Repository-ni fork edin
2. Feature branch yaradın (`git checkout -b feature/AmazingFeature`)
3. Dəyişikliklərini commit edin (`git commit -m 'Add some AmazingFeature'`)
4. Branch-ı push edin (`git push origin feature/AmazingFeature`)
5. Pull Request açın

## 📝 Lisenziya

Bu proyekt MIT lisenziyası altında paylaşılmışdır.

## 📞 Əlaqə

Suallarınız və ya təklifləriniz üçün mənimlə əlaqə saxlaya bilərsiniz.

---

⭐ **Bu proyekti bəyəndinizsə, ulduz verməyi unutmayın!**
