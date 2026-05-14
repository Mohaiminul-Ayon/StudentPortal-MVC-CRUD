Student Portal - ASP.NET Core 8 MVC CRUD Application
This project is a web application built using ASP.NET Core 8 MVC, designed to perform full CRUD (Create, Read, Update, Delete) operations on student data. It utilizes Entity Framework Core for database interactions with SQL Server and features a clean, responsive UI styled with Bootstrap 5.

🚀 Project Overview
The Student Portal serves as a practical implementation of the Model-View-Controller (MVC) architectural pattern. It allows users to manage student records (Name, Email, Phone, Subscription status) efficiently through a web-based interface.

🛠️ Key Features
Create: Add new students via a web form.
Read: View a comprehensive list of all students from the database.
Update: Edit existing student profiles.
Delete: Safely remove records from the database.
📋 Prerequisites
Visual Studio 2022 (with ASP.NET and web development workload)
.NET 8 SDK
SQL Server
⚙️ Setup Instructions
Clone the repository:
bash
git clone https://github.com/YOUR_GITHUB_USERNAME/YOUR_REPOSITORY_NAME.git

Database Configuration:
Update the ConnectionStrings section in your appsettings.json file to match your local SQL Server instance:

"ConnectionStrings": {
"StudentPortal": "Server=YOUR_SERVER_NAME;Database=StudentPortalDB;Trusted_Connection=True;TrustServerCertificate=True;"
}

Apply Migrations:
Open the Package Manager Console in Visual Studio and run:
powershell
Add-Migration InitialMigration
Update-Database

Launch Application:
Press F5 in Visual Studio to run the project.

🏗️ Technologies Used
Framework: ASP.NET Core 8 MVC
Database: SQL Server & Entity Framework Core
Frontend: Bootstrap 5
Language: C#
👨‍💻 Credits
This project was developed following the tutorial by Sameer Saini: ASP.NET Core MVC CRUD Operations using .NET 8
