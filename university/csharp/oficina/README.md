# Oficina

WPF desktop app for managing a car workshop — clients, work orders (folhas de obra), and a simple dashboard.

Stack: C# · WPF · .NET Framework 4.8 · Entity Framework 5 · SQL Server LocalDB

## Run

1. Open `Oficina.csproj` in Visual Studio (Windows).
2. Restore NuGet packages (`EntityFramework` 5.0.0 via `packages.config`).
3. Create the database: open `SQLQuery1.sql` in SSMS / Azure Data Studio and run it against `(localdb)\MSSQLLocalDB`.
4. Build and run (F5).

Connection string is in `App.config` (`OficinaEntities` → `OficinaDB` on LocalDB).

## Features

- Dashboard with counts (clients, open / in repair / completed orders) and latest entries
- Client CRUD with search
- Work order CRUD linked to clients (vehicle, status, value)

## Structure

```
Controllers/   # thin layer over Data
Data/          # Entity Framework access
Model/         # EDMX + entities
Views/         # WPF pages (Início, Clientes, Folhas de Obra)
SQLQuery1.sql  # schema + sample data
Dictionary1.xaml
```
