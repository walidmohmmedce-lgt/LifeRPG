# 🎮 LifeRPG API

A gamified backend system built with **ASP.NET Core** that models real-life productivity as an RPG.  
Users complete quests, earn XP, level up, and unlock achievements — all powered by real business logic and clean architecture.

This project demonstrates **backend engineering skills beyond basic CRUD**, including domain modeling, rule enforcement, and layered architecture.

---

## 🧠 Why this project matters

LifeRPG was designed to simulate a real-world backend system where:
- Data is not just stored, but **governed by rules**
- Actions have **consequences**
- The system enforces **consistency and business logic**

It reflects how production systems handle progression, validation, and persistence.

---

## ⚙️ Tech Stack

- ASP.NET Core Web API  
- Entity Framework Core  
- SQL Server  
- C#  
- Clean Architecture  
- Swagger (OpenAPI)  

---

## 🏗 Architecture

The project follows **Clean Architecture** principles:

- **LifeRPG.Domain** → Core entities and rules  
- **LifeRPG.Application** → Business logic and services  
- **LifeRPG.Infrastructure** → Database & EF Core  
- **LifeRPG.Api** → Controllers & endpoints  

This structure improves:
- Maintainability  
- Testability  
- Separation of concerns  

---

## ✨ Core Features

- User registration  
- XP and level progression  
- Quest system with completion tracking  
- Achievement unlocking system  
- Rule-based validation:
  - Users cannot complete the same quest twice  
  - Achievements unlock automatically when conditions are met  
- Persistent storage using SQL Server  
- Swagger UI for API exploration  

---

## 📌 Example Business Logic

- Completing a quest grants XP  
- Every 100 XP increases the user’s level  
- Achievements unlock automatically when level conditions are reached  
- Duplicate quest completion is prevented by the system  

---

## 📂 Core Entities

- User  
- Quest  
- QuestCompletion  
- Achievement  
- UserAchievement  

All entities are persisted using **EF Core** with relational modeling.

---

## ▶️ How to Run the Project

1. Clone the repository:
   ```bash
   git clone https://github.com/walidmohmmedce-lgt/LifeRPG.git

2. Open the solution in Visual Studio

3. Configure your SQL Server connection in:
   appsettings.json
4. Apply migrations:
   Update-Database
5. Run the project and open Swagger:
   https://localhost:xxxx/swagger

📄 Purpose of the Project

This project was built to:
Practice professional backend architecture
Apply business rules beyond CRUD
Demonstrate readiness for real-world backend development
Serve as a portfolio project for .NET backend roles

👤 Author

Walid Mohmmed
.NET Backend Developer
GitHub: https://github.com/walidmohmmedce-lgt

LinkedIn: https://www.linkedin.com/in/walid-mohmmed-8333583a3
