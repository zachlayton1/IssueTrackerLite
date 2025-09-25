# IssueTrackerLite

A tiny, realistic **issue tracker** that demonstrates core .NET skills in a simple, beginner‑friendly way.

**Why this repo exists:** to prove the fundamentals in a typical .NET/C# role—clean MVC app, Entity Framework Core, validations, tests, Docker, Git, and CI/CD—without heavy setup.

---

## ✨ Features

- **ASP.NET Core MVC** (server‑rendered Razor views)
- **C# + EF Core (SQLite)** for data access, with migrations
- **Domain model & validation** (`Issue` with rule “DueDate ≥ CreatedAt”)
- **CRUD** screens (Index, Details, Create, Edit, Delete)
- **Unit tests** with **xUnit**
- **Dockerfile** to run anywhere
- **GitHub Actions CI/CD** (builds, tests, and publishes a Docker image)
- Targets **.NET 8 (LTS)**

---

## 🧰 Stack

- .NET 8, ASP.NET Core MVC
- Entity Framework Core (SQLite)
- xUnit
- Docker
- GitHub Actions

---

## 🚀 Quick Start

### Run locally (no Docker)

```powershell
dotnet restore
dotnet ef database update --project src/IssueTrackerLite
dotnet run --project src/IssueTrackerLite
```
