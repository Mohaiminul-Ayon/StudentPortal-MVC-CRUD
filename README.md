Student Portal - ASP.NET Core 8 MVC CRUD Application
This project is a web application built using ASP.NET Core 8 MVC, designed to perform full CRUD (Create, Read, Update, Delete) operations on student data. It utilizes Entity Framework Core for database interactions with SQL Server and features a clean, responsive UI styled with Bootstrap 5.

🚀 Project Overview
The Student Portal serves as a practical implementation of the Model-View-Controller (MVC) architectural pattern. It allows administrators to manage student records efficiently through a web-based interface.

🛠️ Key Features
Create: Add new students with details like name, email, phone, and subscription status.
Read: Display a comprehensive list of all students retrieved directly from the SQL Server database.
Update: Edit existing student profiles to keep information current.
Delete: Remove records from the database using entity-tracking management.
📋 Prerequisites
To run this project locally, ensure you have the following installed:

Visual Studio 2022 (with ASP.NET and web development workload)
.NET 8 SDK
SQL Server (or SQL Server Express)
⚙️ Setup Instructions
Clone the repository:
bash
git clone

Database Configuration:
Update the ConnectionStrings section in your appsettings.json file to match your local SQL Server instance:

"ConnectionStrings": {
"StudentPortal": "Server=YOUR_SERVER_NAME;Database=StudentPortalDB;Trusted_Connection=True;TrustServerCertificate=True;"
}

Apply Migrations:
Open the Package Manager Console in Visual Studio and run the following commands to build the database schema:
powershell
Add-Migration InitialMigration
Update-Database

Run the Application:
Press F5 or the "Run" button in Visual Studio to launch the application in your browser.

🏗️ Technologies Used
Framework: ASP.NET Core 8 MVC
Database: SQL Server & Entity Framework Core (Code-First)
Frontend: Bootstrap 5, Razor Views
Language: C#
👨‍💻 Credits
This project was developed following the tutorial by Sameer Saini on YouTube: ASP.NET Core MVC CRUD Operations using .NET 8
