# ContosoPizza

A simple ASP.NET Core Web API sample project for managing pizza items.

## Overview

This project exposes a RESTful pizza API backed by an in-memory service. It includes basic CRUD operations for `Pizza` resources.

## Requirements

- .NET 10 SDK

## Run the app

From the project root:

```bash
dotnet run
```

The API will start on the configured HTTPS port. By default, ASP.NET Core uses ports like `https://localhost:5001` and `http://localhost:5000`.

## Endpoints

The main API controller is `PizzaController` and the routes are:

- `GET /Pizza` - Get all pizzas
- `GET /Pizza/{id}` - Get a pizza by ID
- `POST /Pizza` - Create a new pizza
- `PUT /Pizza/{id}` - Update an existing pizza
- `DELETE /Pizza/{id}` - Delete a pizza by ID

## Pizza model

The pizza resource contains:

- `Id` (int)
- `Name` (string)
- `IsGlutenFree` (bool)

## Notes

- The project uses an in-memory store in `Services/PizzaService.cs`, so data is not persisted across restarts.
- OpenAPI is enabled in development mode via `Program.cs`.
