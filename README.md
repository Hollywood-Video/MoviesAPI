# 🎬 MovieBuff

**MovieBuff** is a modern ASP.NET Core REST API that lets users explore, search, and manage movie data — inspired by platforms like IMDb and TMDb.  
It’s built with **Clean Architecture** and **Domain-Driven Design (DDD)** principles, focusing on scalability, maintainability, and clean separation of concerns.

---

## 🧩 Architecture Overview

MovieBuff follows a **Classic Clean Architecture** approach:

```
MovieBuff.sln
├── src/
│   ├── MovieBuff.Domain/                 # Entities, Value Objects, Domain Events
│   ├── MovieBuff.Application/            # Use Cases, Commands, Queries, Validation
│   ├── MovieBuff.Application.Abstractions/ # Public Contracts and Shared Interfaces
│   ├── MovieBuff.Infrastructure/         # EF Core, Repositories, Caching, Auth, etc.
│   └── MovieBuff.WebApi/                 # REST Controllers / Endpoints
└── tests/
    ├── MovieBuff.UnitTests/
    └── MovieBuff.IntegrationTests/
```

### Dependency Flow

```
WebApi → Application → Domain
WebApi → Application.Abstractions
Infrastructure → Application
Infrastructure → Domain
```

---

## ⚙️ Tech Stack

| Layer | Technologies |
|-------|---------------|
| **Web API** | ASP.NET Core 9, Minimal API / Controllers |
| **Application** | MediatR (CQRS), FluentValidation, Mapster |
| **Infrastructure** | EF Core, SQL Server/PostgreSQL, Redis Cache |
| **Testing** | xUnit, Testcontainers |
| **Observability** | Serilog, ProblemDetails, OpenTelemetry (optional) |

---

## 🚀 Features

- 🎞️ **Movie Catalog** — Browse, search, and filter movies by title, genre, or release year.  
- 🧑‍🎤 **Cast & Crew** — Retrieve structured information about actors, directors, and roles.  
- ⭐ **Ratings System** — Track and aggregate user ratings and reviews.  
- ⚡ **Caching Support** — Hybrid caching (Memory + Redis) for faster response times.  
- 🧱 **Clean Architecture** — Strict separation between layers for maintainability.  
- 🧩 **DDD Concepts** — Aggregates, Value Objects, Domain Events, Repositories.  
- ✅ **Validation & Error Handling** — FluentValidation and standardized ProblemDetails.  
- 🔒 **Authentication Ready** — JWT / OAuth2 abstractions for secure endpoints.  

---

## 🏗️ Getting Started

### 1️⃣ Clone the Repository

```bash
git clone https://github.com/your-username/MovieBuff.git
cd MovieBuff
```

### 2️⃣ Configure the Database

Update your connection string in `src/MovieBuff.WebApi/appsettings.Development.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=MovieBuff;User Id=sa;Password=Your_password123;"
  }
}
```

### 3️⃣ Run Database Migrations

```bash
dotnet ef database update --project src/MovieBuff.Infrastructure
```

### 4️⃣ Launch the API

```bash
cd src/MovieBuff.WebApi
dotnet run
```

The API will start on **https://localhost:5001** (or specified port).

---

## 🔍 API Endpoints (Examples)

| Method | Endpoint | Description |
|--------|-----------|-------------|
| `GET` | `/api/movies` | Get all movies |
| `GET` | `/api/movies/{id}` | Get movie details by ID |
| `POST` | `/api/movies` | Create a new movie |
| `PUT` | `/api/movies/{id}` | Update a movie |
| `DELETE` | `/api/movies/{id}` | Delete a movie |
| `GET` | `/api/actors` | Get all actors |

---

## 🧪 Running Tests

```bash
dotnet test
```

Integration tests use **Testcontainers** to spin up a temporary database.

---

## 🧱 Code Style & Build Configuration

Common build settings (nullable, analyzers, etc.) are shared using:

- `Directory.Build.props` — shared compiler and analyzer configuration  
- `Directory.Build.targets` — shared build logic and hooks  

Each project automatically inherits these settings for consistency.

---

## 🧭 Roadmap

- [ ] Add Watchlist & Reviews modules  
- [ ] Implement Authentication (JWT / OAuth2)  
- [ ] Add GraphQL endpoint (optional)  
- [ ] Integrate Swagger UI and versioning  
- [ ] Deploy to Azure App Service or Hetzner VPS  

---

## 🧰 Tools

| Tool | Purpose |
|------|----------|
| **EF Core** | ORM for persistence |
| **FluentValidation** | Request validation |
| **Mapster** | Object mapping |
| **Serilog** | Structured logging |
| **Redis** | Distributed caching |
| **ProblemDetails** | Consistent API error responses |

---

## 🧑‍💻 Contributing

1. Fork the repository  
2. Create a new feature branch (`git checkout -b feature/my-feature`)  
3. Commit your changes (`git commit -m "Add new feature"`)  
4. Push and open a PR 🎉

---

## 📄 License

This project is licensed under the [MIT License](LICENSE).

---

## ❤️ Acknowledgments

Inspired by:
- [Clean Architecture by Steve Smith (ardalis)](https://github.com/ardalis/CleanArchitecture)  
- [Jason Taylor’s Clean Architecture Template](https://github.com/jasontaylordev/CleanArchitecture)  
- [IMDB](https://www.imdb.com) and [TMDb](https://www.themoviedb.org)  

---

> _“A good architecture allows you to build new features without breaking old ones.”_  
> — Uncle Bob, *Clean Architecture*
