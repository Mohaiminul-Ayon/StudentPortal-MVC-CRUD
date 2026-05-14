# 🎓 Student Portal | ASP.NET Core 8 MVC CRUD

A robust, full-stack web application designed to manage student records. This project demonstrates the implementation of the **Model-View-Controller (MVC)** architectural pattern using **.NET 8** and **Entity Framework Core**.

---

## 🚀 Project Overview
The Student Portal provides a streamlined interface for administrative tasks, allowing users to manage student data (Name, Email, Phone, and Subscription status) with real-time database synchronization.

### 🛠️ Key Features
*   **Create:** Intuitive web forms for adding new student profiles.
*   **Read:** Dynamic data table to view all registered students.
*   **Update:** Seamless editing of existing records.
*   **Delete:** Secure removal of student data from the SQL database.
*   **Responsive UI:** Fully compatible with mobile and desktop views via Bootstrap 5.

---

## 🏗️ Tech Stack
| Layer | Technology |
| :--- | :--- |
| **Framework** | ASP.NET Core 8 (MVC) |
| **Language** | C# |
| **Database** | SQL Server |
| **ORM** | Entity Framework Core |
| **Frontend** | Bootstrap 5, HTML5, CSS3 |

---

## 📋 Prerequisites
Before you begin, ensure you have the following installed:
*   [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) (version 17.8 or higher)
*   **ASP.NET and web development** workload
*   [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
*   **SQL Server** (LocalDB or Express)

---

## ⚙️ Getting Started

### 1. Clone the Repository
```bash
git clone [https://github.com/YOUR_GITHUB_USERNAME/YOUR_REPOSITORY_NAME.git](https://github.com/YOUR_GITHUB_USERNAME/YOUR_REPOSITORY_NAME.git)
cd YOUR_REPOSITORY_NAME
```
2. Database Configuration
Update the ConnectionStrings in appsettings.json to point to your local SQL Server instance:

```JSON
"ConnectionStrings": {
  "StudentPortal": "Server=YOUR_SERVER_NAME;Database=StudentPortalDB;Trusted_Connection=True;TrustServerCertificate=True;"
}
```
3. Apply Migrations
Use the Package Manager Console in Visual Studio to generate the database schema:

```PowerShell
Add-Migration InitialMigration
Update-Database
```
4. Run the Application

Press F5 or click the Start button in Visual Studio to launch the application.

📂 Project Structure
Models/: Data entities representing student records.

Views/: Razor templates for the user interface.

Controllers/: Request handling and business logic.

Data/: ApplicationDbContext for SQL Server interaction.

👨‍💻 Credits
Tutorial: Developed following the guide by Sameer Saini: ASP.NET Core MVC CRUD Operations using .NET 8.

📜 License
This project is open-source and available for educational purposes.
