# UsersApp - Todo Application

A modern and responsive todo management system built using ASP.NET Core and Entity Framework.

## 🚀 Features

### 🔐 Authentication
- **Registration**: Create a new user account
- **Login**: Sign in with existing account
- **Password Reset**: Change password via email
- **Logout**: Secure logout functionality

### ✅ Todo Management
- **Add Task**: Create new tasks
- **Change Status**: Mark tasks as completed or active
- **Delete**: Remove unnecessary tasks
- **Filter**: View all, active, or completed tasks
- **Real-time Updates**: Perform actions without page reload using AJAX

### 🎨 UI/UX
- **Dark/Light Theme**: Switch between themes
- **Responsive Design**: Optimized for both mobile and desktop devices
- **Modern Animations**: Smooth transitions and hover effects
- **Intuitive Interface**: User-friendly layout

## 🛠️ Technologies

- **Backend**: ASP.NET Core 8.0
- **Database**: SQL Server (Entity Framework Core)
- **Authentication**: ASP.NET Core Identity
- **Frontend**: HTML5, CSS3, JavaScript (Vanilla)
- **Styling**: Bootstrap 5 + Custom CSS
- **AJAX**: Fetch API

## 📋 Requirements

- .NET 8.0 SDK
- SQL Server (LocalDB or SQL Server Express)
- Visual Studio 2022 or VS Code

## 📁 Project Structure

```
UsersApp/
├── Controllers/
│   ├── AccountController.cs      # Authentication operations
│   ├── HomeController.cs         # Home Page
│   └── TodoController.cs         # Todo operations
├── Data/
│   └── AppDbContext.cs           # Database context
├── Models/
│   ├── Users.cs                  # User model
│   ├── ToDo.cs                   # Todo model
│   └── ErrorViewModel.cs         # Error model
├── ViewModels/
│   ├── LoginViewModel.cs         # Login form
│   ├── RegisterViewModel.cs      # Registration form
│   ├── ChangePasswordViewModel.cs # Password change
│   └── VerifyEmailViewModel.cs   # Email verification
├── Views/
│   ├── Account/                  # Authentication views
│   ├── Home/                     # Home views
│   ├── Todo/                     # Todo views  
│   └── Shared/                   # Shared layouts
└── Program.cs                    # Application configuration
```

## 🎯 Usage

### Register & Login
1. Launch the application
2. Click on the "Register" link
3. Enter your name, email, and password
4. After registration, you'll be redirected to the login page
5. Log in with your credentials

### Manage Todos
1. After logging in, navigate to the "ToDo" menu
2. Type your task in the input field and click "ADD"
3. Mark a task as complete by clicking the checkbox
4. Delete a task by clicking the "×" button
5. Use the "ALL", "ACTIVE", or "COMPLETED" tabs to filter tasks

### Theme Switching
Click the theme toggle button in the top-right corner to switch between Dark and Light themes.

## 🔒 Security

- **CSRF Protection**: Anti-forgery tokens used in all POST operations
- **Authorization**: Todo operations are accessible only to logged-in users
- **Data Validation**: Model validation and server-side checks
- **XSS Protection**: HTML encoding and clean JavaScript

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📝 License

This project is licensed under the MIT License.

## 📞 Contact

Feel free to reach out if you have any questions or suggestions.

---

⭐ **If you liked this project, don't forget to give it a star!**
