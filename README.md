LifeRPG API

A gamified backend system built with ASP.NET Core that simulates real-life productivity as an RPG game.
Users complete quests, earn XP, level up, and unlock achievements — all powered by real business logic and clean architecture.

This project goes beyond CRUD and demonstrates real backend engineering concepts such as progression systems, rule-based logic, persistence, and clean layering.

Features
Core System

User registration & login (with secure password hashing)

Users gain XP and levels

Quest system with rewards

Quest completion tracking

Duplicate quest completion protection

Achievement unlocking system

Persistent progression stored in SQL Server

Business Logic Examples

Completing a quest increases XP

Every 100 XP increases level

Achievements unlock automatically when user reaches required level

Users cannot complete the same quest twice

Architecture

The project follows Clean Architecture principles:

LifeRPG.Domain        → Core business entities
LifeRPG.Application   → Business logic & services
LifeRPG.Infrastructure→ Database & EF Core
LifeRPG.Api           → Controllers & API endpoints


Tech Stack

ASP.NET Core Web API

Entity Framework Core

SQL Server

C#

Clean Architecture

Swagger (OpenAPI)


Entities

The system includes:

User

Quest

QuestCompletion

Achievement

UserAchievement

All persisted in a relational database using EF Core.

Example Flow

Create user

Create quest

Complete quest

User gains XP

User levels up

Achievement unlocks automatically

Progress saved in database


How to Run Locally
1. Clone the repository
git clone https://github.com/walidmohmmedce-lgt/LifeRPG.git
cd LifeRPG

2. Configure database

Update appsettings.json in LifeRPG.Api:

"ConnectionStrings": {
  "DefaultConnection": "Server=.\\SQLEXPRESS;Database=LifeRpgDb;Trusted_Connection=True;TrustServerCertificate=True"
}

3. Run migrations
dotnet ef database update --project LifeRPG.Infrastructure --startup-project LifeRPG.Api

4. Run the project
dotnet run --project LifeRPG.Api

5. Open Swagger

Navigate to:

http://localhost:XXXX/swagger


Author

Walid Mohmmed
.NET Backend Developer
GitHub: https://github.com/walidmohmmedce-lgt