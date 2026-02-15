📌 Project Name

Short description of what the project does.

Example:
A simple ASP.NET Core application for managing books (CRUD operations) using Entity Framework Core and SQL Server.

🚀 Features

Create / Read / Update / Delete records

SQL Server Database support

Entity Framework Core Migrations

MVC / API structure (depending on your project)

🛠️ Technologies Used

.NET 8

ASP.NET Core MVC

Entity Framework Core

SQL Server

Bootstrap (optional)

📂 Project Setup
✅ Requirements

Make sure you have the following installed:

.NET SDK 8

SQL Server (LocalDB / Express / Full version)

Visual Studio 2022 (or VS Code)

⚙️ How to Run the Project

1️⃣ Clone the Repository
git clone https://github.com/Mohammed-Alsaied/LuftBornTask.git


Move into the project folder:

cd your-repo-name


2️⃣ Configure Database Connection

Open the file:

📌 appsettings.json

Update the connection string:

"ConnectionStrings": {
  "DefaultConnection": "Server=YourServerName;Database=YourDatabaseName;Trusted_Connection=True;TrustServerCertificate=True;"
}

3️⃣ Apply Database Migrations
Open the Pckage Manager Console, chose the LuftBorn.Ui project and run this command
"updata-database"

4️⃣ Run the Application
run the app from VS or run this command "dotnet run"
