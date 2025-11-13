StudentManagementAPI
📄 Overview

StudentManagementAPI is a fully functional ASP.NET Core Web API project built using .NET 8. It demonstrates a complete CRUD (Create, Read, Update, Delete) workflow for managing Students and Courses. The project uses Entity Framework Core with LocalDB for a simple, out-of-the-box database experience, and comes with Swagger integration for easy API testing.

This project is designed as a portfolio-ready demonstration of skills in:

C# and .NET Core

RESTful API design

Entity Framework Core (Code First approach)

LocalDB / SQL Server integration

Git version control and clean project structure

Swagger for API documentation and testing

🛠️ Features

Students Management

Add, edit, delete, and view students

Attributes: FullName, Email, DateOfBirth

Courses Management

Add, edit, delete, and view courses

Attributes: Title, Credits

Entity Framework Core (EF Core)

Code First migrations

Automatic database creation using LocalDB

Swagger / OpenAPI

Automatically generated documentation

Interactive UI to test endpoints

Out-of-the-box setup

Runs on LocalDB (no full SQL Server installation required)

Cross-platform compatible

📁 Project Structure
StudentManagementAPI/
├── Controllers/       # API controllers (StudentsController, CoursesController)
├── Data/              # ApplicationDbContext.cs for EF Core
├── Models/            # Student.cs, Course.cs
├── Properties/
├── appsettings.json   # Configuration file, includes connection string
├── Program.cs         # Main entry point
├── StudentManagementAPI.csproj
└── .gitignore

⚡ Prerequisites

.NET 8 SDK

Visual Studio 2022 / VS Code (with C# extensions)

LocalDB (comes automatically with Visual Studio)

🚀 Getting Started

Clone the repository
git clone https://github.com/<YourUsername>/StudentManagementAPI.git
cd StudentManagementAPI

Restore dependencies
dotnet restore

Apply EF Core migrations to create database
dotnet ef database update

Run the API
dotnet run

Open Swagger UI to test endpoints
http://localhost:5000/swagger

🧩 Example Usage
POST /api/Students
{
  "fullName": "John Doe",
  "email": "john@example.com",
  "dateOfBirth": "2000-05-15"
}

GET /api/Students

Returns a list of all students.

POST /api/Courses
{
  "title": "Mathematics",
  "credits": 5
}

GET /api/Courses

Returns a list of all courses.

⚙️ Technologies Used

C# / .NET 8

ASP.NET Core Web API

Entity Framework Core 8

LocalDB (SQL Server)

Swagger / OpenAPI

Git for version control

📝 Notes

Database is created automatically using Code-First EF Core migrations

LocalDB allows easy setup without installing full SQL Server

.gitignore is configured to exclude build artifacts, user-specific files, and LocalDB files

📌 Future Improvements

Add authentication & authorization (JWT or Identity)

Add pagination and filtering for Students/Courses endpoints

Connect a Vue.js frontend for a full-stack portfolio demo

Deploy to Azure or AWS

📂 License

This project is open source and free to use for portfolio purposes.
