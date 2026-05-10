# ContosoPizza

A simple ASP.NET Core Web API sample project for managing pizza items and generating sales reports.

## Overview

This project exposes a RESTful pizza API backed by an in-memory service. It includes basic CRUD operations for `Pizza` resources and a sales summary report generator.

## Requirements

- .NET 10 SDK

## Run the app

From the project root:

```bash
dotnet run
```

The API will start on the configured HTTPS port. By default, ASP.NET Core uses ports like `https://localhost:5001` and `http://localhost:5000`.

## Endpoints

### Pizza API

The main API controller is `PizzaController` and the routes are:

- `GET /Pizza` - Get all pizzas (Status: 200 OK)
- `GET /Pizza/{id}` - Get a pizza by ID (Status: 200 OK or 404 Not Found)
- `POST /Pizza` - Create a new pizza (Status: 201 Created)
- `PUT /Pizza/{id}` - Update an existing pizza (Status: 204 No Content, 400 Bad Request, or 404 Not Found)
- `DELETE /Pizza/{id}` - Delete a pizza by ID (Status: 204 No Content or 404 Not Found)

### Sales API

- `GET /Sales/summary` - Generate sales summary report from files in the Sales directory

## Pizza model

The pizza resource contains:

- `Id` (int)
- `Name` (string)
- `IsGlutenFree` (bool)

## Sales Summary

The sales summary reads all .txt files in the `Sales` directory, parses decimal values, and generates a report with total sales and per-file details.

Example output:

```
Sales Summary
----------------------------
 Total Sales: $4,501.50

 Details:
  sales1.txt: $1,500.50
  sales2.txt: $2,200.75
  sales3.txt: $800.25
```

## Testing

Use the `ContosoPizza.http` file in your editor to test the API endpoints. It includes examples for all CRUD operations with expected status codes.

## Notes

- The pizza data uses an in-memory store in `Services/PizzaService.cs`, so data is not persisted across restarts.
- OpenAPI is enabled in development mode via `Program.cs`.
- Sample sales files are included in the `Sales` directory for testing the summary feature.
