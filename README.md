# QuickBook - .NET Booking System

A modern, responsive booking web application built with ASP.NET Core MVC, Entity Framework Core, and Bootstrap. QuickBook allows users to book appointments online and provides admin tools for managing bookings and services.

![QuickBook Logo](https://img.shields.io/badge/QuickBook-Booking%20System-blue?style=for-the-badge&logo=calendar)

## 🚀 Features

### 👤 User Features
- **User Registration & Login**: Secure ASP.NET Identity authentication
- **Book Services**: Select service, date, and time for appointments
- **View Bookings**: See upcoming and past bookings with status indicators
- **Cancel Bookings**: Cancel pending or approved bookings
- **Responsive Design**: Works perfectly on desktop and mobile devices

### 🔧 Admin Features
- **Booking Management**: View all bookings, approve or reject requests
- **Service Management**: Add, edit, and delete available services
- **User Management**: View booking details with customer information
- **Dashboard**: Overview of all system activities

### 🎨 UI/UX Features
- **Modern Design**: Clean, professional interface with Bootstrap 5
- **Font Awesome Icons**: Beautiful icons throughout the application
- **Status Indicators**: Clear visual feedback (Pending, Approved, Cancelled)
- **Form Validation**: Client and server-side validation
- **Real-time Updates**: Instant status changes and confirmations

## 🛠️ Tech Stack

- **Backend**: ASP.NET Core 9.0 MVC
- **Authentication**: ASP.NET Core Identity
- **Database**: SQLite with Entity Framework Core
- **Frontend**: Razor Views, Bootstrap 5, Font Awesome 6
- **Styling**: Bootstrap CSS Framework with custom styling
- **ORM**: Entity Framework Core 9.0
- **Language**: C# 12

## 📋 Prerequisites

Before running this application, make sure you have the following installed:

### Required Software
- **.NET 9.0 SDK** - [Download here](https://dotnet.microsoft.com/download/dotnet/9.0)
- **Git** - [Download here](https://git-scm.com/downloads)
- **Code Editor** (recommended):
  - Visual Studio 2022 (Windows/Mac)
  - Visual Studio Code (Cross-platform)
  - JetBrains Rider

### Optional Tools
- **SQLite Browser** - To view the database (optional)
- **Postman** - For API testing (optional)

## 🚀 Getting Started

Follow these steps to run QuickBook on your computer:

### 1. Clone the Repository
```bash
git clone https://github.com/santoshnaya/quickbook-dotnet-booking-system.git
cd quickbook-dotnet-booking-system
```

### 2. Restore NuGet Packages
```bash
dotnet restore
```

### 3. Build the Project
```bash
dotnet build
```

### 4. Run the Application
```bash
dotnet run
```

### 5. Open in Browser
The application will start and display the URL in the console (typically `http://localhost:5167` or `https://localhost:7167`).

Open your web browser and navigate to the displayed URL.

## 🔑 Demo Credentials

The application comes with pre-seeded demo accounts for immediate testing:

### 👨‍💼 Admin Account
- **Email**: `admin@quickbook.com`
- **Password**: `admin123`
- **Access**: 
  - Full admin panel
  - Manage all bookings (approve/reject)
  - Manage services (CRUD operations)
  - View all user activities

### 👤 Demo User Account
- **Email**: `user@quickbook.com`
- **Password**: `user123`
- **Access**: 
  - Book appointments
  - View personal bookings
  - Cancel own bookings

### 🆕 Create New Account
You can also register a new account with any email and password (minimum 6 characters).

## 🎯 Usage Guide

### For Regular Users

1. **Register/Login**
   - Visit the home page
   - Click "Register" to create a new account
   - Or use demo credentials to login

2. **Book an Appointment**
   - Click "Book Now" in the navigation
   - Select a service from the dropdown
   - Choose your preferred date and time
   - Add optional notes
   - Submit the booking

3. **Manage Your Bookings**
   - Go to "My Bookings" to view all your appointments
   - See booking status (Pending/Approved/Cancelled)
   - Cancel bookings if needed

### For Administrators

1. **Login as Admin**
   - Use admin credentials: `admin@quickbook.com` / `admin123`

2. **Manage Bookings**
   - Go to "Admin" → "Bookings"
   - View all user bookings
   - Approve or reject pending bookings
   - Monitor booking activities

3. **Manage Services**
   - Go to "Admin" → "Services"
   - Add new services with name, description, duration, and price
   - Edit existing services
   - Delete unused services (only if no bookings exist)

## 🐛 Troubleshooting

### Common Issues

1. **Port Already in Use**
   ```bash
   # Use a different port
   dotnet run --urls=http://localhost:5168
   ```

2. **Database Issues**
   ```bash
   # Delete database and restart (development only)
   rm quickbook.db
   dotnet run
   ```

3. **Package Restore Issues**
   ```bash
   # Clear NuGet cache
   dotnet nuget locals all --clear
   dotnet restore
   ```

4. **Build Errors**
   ```bash
   # Clean and rebuild
   dotnet clean
   dotnet build
   ```

## 📝 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 🤝 Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## 📞 Support

For support, questions, or feedback:

- **GitHub Issues**: [Create an issue](https://github.com/santoshnaya/quickbook-dotnet-booking-system/issues)
- **Documentation**: This README file

---

**Happy Booking! 📅✨**

Made with ❤️ using ASP.NET Core