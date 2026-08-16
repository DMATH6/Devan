# Devan

Devan is a web-based job management application built with **ASP.NET Core and Blazor**.

The application provides an interface for creating, viewing, editing and managing job records stored in a **Microsoft SQL Server** database.

This project was built as a practical project to develop experience with the **.NET ecosystem, Blazor, Entity Framework Core and SQL Server**.

## Features

* Create new job records
* View existing jobs
* Edit job information
* Delete jobs
* Filter and manage job records
* Assign jobs to accounts/users
* Manage job status and priority
* Store and retrieve data using Microsoft SQL Server
* Database access through Entity Framework Core

## Technologies

* **C#**
* **.NET 8**
* **ASP.NET Core**
* **Blazor Interactive Server**
* **Entity Framework Core**
* **Microsoft SQL Server**
* **HTML / CSS**
* **Git / GitHub**

## Project Structure

The application is built using Blazor components with Entity Framework Core providing access to the SQL Server database.

Key parts of the project include:

* `Components/` — Blazor pages and UI components
* `Migrations/` — Entity Framework Core database migrations
* `wwwroot/` — Static files and styling
* `Account.cs` — Account entity
* `Job.cs` — Job entity
* `Main.cs` — Main job record entity
* `Program.cs` — Application configuration and service setup

## Database

Devan uses **Microsoft SQL Server** with **Entity Framework Core**.

The application uses a relational database to store job and account information, with relationships between the relevant entities.

The database connection string is intentionally **not included in this repository**.

For local development, configure the connection string using ASP.NET Core configuration or **User Secrets**.

## Getting Started

### Requirements

* .NET 8 SDK
* Microsoft SQL Server
* Visual Studio 2022 or another .NET-compatible development environment

### Clone the repository

```bash
git clone https://github.com/DMATH6/Devan.git
cd Devan
```

### Configure the database

Create a local SQL Server database and configure the `DefaultConnection` connection string using your preferred ASP.NET Core configuration method or User Secrets.

Do not commit database credentials or connection strings containing sensitive information.

### Apply database migrations

After configuring the database connection, apply the Entity Framework Core migrations:

```bash
dotnet ef database update
```

### Run the application

```bash
dotnet run
```

Alternatively, open `Devan.sln` in Visual Studio and run the project from there.

## Purpose

Devan was created as a hands-on .NET development project to gain practical experience building a database-driven web application.

The project focuses on:

* C# application development
* ASP.NET Core
* Blazor Interactive Server
* Entity Framework Core
* SQL Server database design
* CRUD operations
* Form validation
* Git and GitHub

## Status

This project is currently under development. New features and improvements may be added as development continues.
