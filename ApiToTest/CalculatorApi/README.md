# Calculator API - Documentation

## Overview
A simple ASP.NET Core Web API with two endpoints for basic arithmetic operations (add and subtract).

## Prerequisites
- .NET 8.0 SDK
- IDE (Visual Studio, Rider, or VS Code)
- Postman or Swagger UI (for testing)

---

## Build

### Using IDE
- **Visual Studio**: Build → Build Solution (Ctrl+Shift+B)
- **Rider**: Build → Build Project (Ctrl+F9)
- **VS Code**: Open terminal and run `dotnet build`

![img.png](img.png)

Click on play button to run the API, this will open the swagger UI in the browser. That means the API is running and you can test it from there.

### Using CLI
```bash
# Navigate to project directory
cd CalculatorApi

# Restore dependencies
dotnet restore

# Build the project
dotnet build

# Build for release
dotnet build -c Release
```

## Swagger UI

Swagger is enabled and accessible at the root URL:
- **Swagger UI**: `http://localhost:5232/index.html`
- **Swagger JSON**: `http://localhost:5232/swagger/v1/swagger.json`

---

By default, running `dotnet run` in the API project starts it on ports 5000/5001. To make it accessible to the test project (on 5232), launch the API on that port:

```bash
dotnet run --urls "http://localhost:5232"
```

Or, adjust your Properties/launchSettings.json accordingly.

---

#### POST /api/calculator/add
Add two numbers.

**Request Body:**
```json
{
  "number1": 10,
  "number2": 5
}
```

**Response:**
```json
{
  "number1": 10,
  "number2": 5,
  "operation": "+",
  "result": 15
}
```

#### POST /api/calculator/subtract
Subtract two numbers.

**Request Body:**
```json
{
  "number1": 10,
  "number2": 5
}
```

**Response:**
```json
{
  "number1": 10,
  "number2": 5,
  "operation": "-",
  "result": 5
}
```

---

## Test with cURL

```bash
# Add numbers
curl -X POST "https://localhost:5001/api/calculator/add" \
  -H "Content-Type: application/json" \
  -d '{"number1": 10, "number2": 5}'

# Subtract numbers
curl -X POST "https://localhost:5001/api/calculator/subtract" \
  -H "Content-Type: application/json" \
  -d '{"number1": 10, "number2": 5}'
```

## Configuration

Edit `appsettings.json` to modify:
- URLs (Kestrel settings)
- Logging levels
- Environment-specific settings
