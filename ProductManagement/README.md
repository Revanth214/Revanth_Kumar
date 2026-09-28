# Stockora – Product Management System

**Every Product. Every Stock. One Dashboard.**

Stockora is a full-stack product management application designed to manage product information, monitor inventory levels, and simplify stock management through a modern, interactive dashboard.

The application combines an ASP.NET Core Web API backend with a React frontend and SQL Server database, following a layered architecture for maintainability and separation of responsibilities.

## Features

* **Product Management:** Create, view, update, and delete products.
* **Inventory Tracking:** Monitor stock quantities and identify low-stock products.
* **Dashboard:** View total products, total stock, low-stock count, and inventory value.
* **Search and Filtering:** Search products and filter them by category.
* **Responsive UI:** Modern dashboard with a floating Add Product form and interactive product table.

## Technology Stack

| Layer             | Technologies                        |
| ----------------- | ----------------------------------- |
| Frontend          | React, JavaScript, CSS              |
| Backend           | ASP.NET Core Web API, C#            |
| ORM               | Entity Framework Core               |
| Database          | Microsoft SQL Server                |
| API Testing       | Swagger / OpenAPI                   |
| Development Tools | Visual Studio, VS Code, Git, GitHub |

## Application Architecture

Stockora follows a layered architecture to separate responsibilities and improve maintainability.

```text
React Frontend
      |
      | HTTP Requests (REST API)
      v
ASP.NET Core Web API
      |
      v
Controller Layer
      |
      v
Service Layer
      |
      v
Repository Layer
      |
      v
Entity Framework Core
      |
      v
SQL Server Database
```

### Architecture Responsibilities

* **Controller Layer:** Handles HTTP requests and API responses.
* **Service Layer:** Contains business logic and coordinates application operations.
* **Repository Layer:** Handles data access operations.
* **Entity Framework Core:** Maps C# entities to database tables and executes database operations.
* **SQL Server:** Stores product and inventory information.

## Getting Started

### Prerequisites

Ensure the following are installed:

* .NET 8 SDK
* Microsoft SQL Server
* Node.js and npm
* Visual Studio or Visual Studio Code

### 1. Clone the Repository

```bash
git clone YOUR_GITHUB_REPOSITORY_URL
cd Stockora
```

Replace `YOUR_GITHUB_REPOSITORY_URL` with your repository's HTTPS URL.

### 2. Configure the Database

Create or configure the `ProductManagementDB` database in SQL Server.

Update the connection string in the backend's configuration with your local SQL Server instance.

Do not commit credentials or sensitive connection strings to GitHub.

### 3. Run the Backend

Open the ASP.NET Core Web API project and restore the dependencies.

```bash
dotnet restore
dotnet build
dotnet run
```

Use the API URL configured in your local launch settings.

The Products API endpoint is:

```text
/api/products
```

Swagger can be used to explore and test the API endpoints.

### 4. Run the React Frontend

Open a terminal in the React client directory.

```bash
npm install
npm run dev
```

Open the local development URL displayed by Vite in your terminal.

Ensure the backend is running and the configured CORS origin matches the frontend's local development URL.

## Project Status

**Current status:** Core product management functionality implemented.

The application supports product CRUD operations, inventory monitoring, category filtering, and dashboard summaries.

## Future Enhancements

* Authentication and authorization
* Product pagination and sorting
* Automated testing
* Deployment to a cloud hosting platform

## Author

**Revanth Kumar**

B.Tech – Artificial Intelligence and Data Science

[GitHub Profile](https://github.com/Revanth214)

## Dashboard Preview

![Stockora Dashboard](screenshots/stockora-dashboard.png)

---

*Stockora is a full-stack learning and development project built to apply practical concepts in ASP.NET Core, Entity Framework Core, SQL Server, and React.*
