# StudentManagementAPI

[![.NET](https://img.shields.io/badge/.NET-8.0-blue)](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
[![C#](https://img.shields.io/badge/C%23-8.0-green)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![License](https://img.shields.io/badge/License-MIT-yellow)](LICENSE)

---

## 📄 Overview

**StudentManagementAPI** is a fully functional **ASP.NET Core Web API** project built using **.NET 8**. It demonstrates a complete **CRUD (Create, Read, Update, Delete)** workflow for managing **Students** and **Courses**. The project uses **Entity Framework Core** with **LocalDB**, and comes with **Swagger integration** for easy API testing.  

This project is designed as a **portfolio-ready demonstration** of skills in:

- C# and .NET Core  
- RESTful API design  
- Entity Framework Core (Code First approach)  
- LocalDB / SQL Server integration  
- Git version control and clean project structure  
- Swagger for API documentation and testing  

---

## 🛠️ Features

1. **Students Management**  
   - Add, edit, delete, and view students  
   - Attributes: `FullName`, `Email`, `DateOfBirth`  

2. **Courses Management**  
   - Add, edit, delete, and view courses  
   - Attributes: `Title`, `Credits`  

3. **Entity Framework Core (EF Core)**  
   - Code First migrations  
   - Automatic database creation using LocalDB  

4. **Swagger / OpenAPI**  
   - Automatically generated documentation  
   - Interactive UI to test endpoints  

5. **Out-of-the-box setup**  
   - Runs on LocalDB (no full SQL Server installation required)  
   - Cross-platform compatible  

---

## 📁 Project Structure

- Controllers/       (API controllers: StudentsController, CoursesController)  
- Data/              (ApplicationDbContext.cs for EF Core)  
- Models/            (Student.cs, Course.cs)  
- Properties/  
- appsettings.json  
- Program.cs  
- StudentManagementAPI.csproj  
- .gitignore  

---

## ⚡ Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)  
- Visual Studio 2022 / VS Code (with C# extensions)  
- LocalDB (comes automatically with Visual Studio)  

---

## 🚀 Getting Started

### Clone the repository
```
git clone https://github.com/<YourUsername>/StudentManagementAPI.git
cd StudentManagementAPI
```

### Restore dependencies
```
dotnet restore
```

### Apply EF Core migrations to create the database
```
dotnet ef database update
```

> This uses LocalDB `(localdb)\MSSQLLocalDB`, which comes automatically with Visual Studio.  
> EF Core will automatically create the `StudentDB` database and the necessary tables: `Students` and `Courses`.

### Run the API
```
dotnet run
```

- By default, the API will run at: [http://localhost:5000](http://localhost:5000)  
- Swagger UI is available at: [http://localhost:5000/swagger](http://localhost:5000/swagger)

### Test the API using Swagger

- **GET /api/Students** → Returns all students  
- **POST /api/Students** → Add a new student  

Example JSON:

```
{
  "fullName": "John Doe",
  "email": "john@example.com",
  "dateOfBirth": "2000-05-15"
}
```

### Test the API using Swagger (Courses)

- **GET /api/Courses** → Returns all courses  
- **POST /api/Courses** → Add a new course  

Example JSON:

```
{
  "title": "Mathematics",
  "credits": 5
}
```

Optional: Inspect database
- Open SQL Server Object Explorer in Visual Studio
- Expand (localdb)\MSSQLLocalDB → Databases → StudentDB
- You should see Students and Courses tables created automatically

## 🗂 Database Schema
```
erDiagram
    STUDENTS {
        int Id PK
        string FullName
        string Email
        DateTime DateOfBirth
    }
    COURSES {
        int Id PK
        string Title
        int Credits
    }
```

## ⚙️ Technologies Used

- C# / .NET 8
- ASP.NET Core Web API
- Entity Framework Core 8
- LocalDB (SQL Server)
- Swagger / OpenAPI
- Git for version control


## 📝 Notes

- Database is created automatically using Code-First EF Core migrations
- LocalDB allows easy setup without installing full SQL Server
- `.gitignore` is configured to exclude build artifacts, user-specific files, and LocalDB files

---

## 📌 Future Improvements

- Add authentication & authorization (JWT or Identity)
- Add pagination and filtering for Students/Courses endpoints
- Connect a Vue.js frontend for a full-stack portfolio demo
- Deploy to Azure or AWS

---

## 📂 License

This project is open source and free to use for portfolio purposes.
