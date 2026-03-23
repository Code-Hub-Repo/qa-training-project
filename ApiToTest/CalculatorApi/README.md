# Calculator API - Documentation

## Overview
A simple ASP.NET Core Web API with two endpoints for basic arithmetic operations (add and subtract).

## Prerequisites
- .NET 8.0 SDK
- IDE (Visual Studio, Rider, or VS Code)
- Postman or Swagger UI (for testing)

---

## Build

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

### Using IDE
- **Visual Studio**: Build → Build Solution (Ctrl+Shift+B)
- **Rider**: Build → Build Project (Ctrl+F9)
- **VS Code**: Open terminal and run `dotnet build`

---

## Run Locally

### Using CLI
```bash
dotnet run
```

The API will be available at:
- HTTP: `http://localhost:5000`
- HTTPS: `https://localhost:5001`

### Using IDE
- **Visual Studio**: Press F5 or click Run
- **Rider**: Click Run button or press Shift+F10

---

## Debug Locally

### Using Rider
1. Open the project in Rider
2. Set breakpoints by clicking on the left margin
3. Click the debug icon (bug) or press Shift+F9
4. Use the debugger panel to step through code, inspect variables

### Using Visual Studio
1. Set breakpoints
2. Press F5 to start debugging
3. Use the Diagnostic Tools and Locals window

### Using VS Code
1. Install C# extension
2. Go to Run → Start Debugging (F5)
3. Configure `launch.json` if not present

---

## Swagger UI

Swagger is enabled and accessible at the root URL:
- `http://localhost:5000/` (HTTP)
- `https://localhost:5001/` (HTTPS)
- **Swagger JSON**: `http://localhost:5000/swagger/v1/swagger.json`

### Endpoints

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

---

## Deploy

### Docker
```dockerfile
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY bin/Release/net8.0/publish/ /app
ENTRYPOINT ["dotnet", "CalculatorApi.dll"]
```

Build and run:
```bash
dotnet publish -c Release
docker build -t calculator-api .
docker run -p 8080:8080 calculator-api
```

### Azure App Service
1. Publish: `dotnet publish -c Release`
2. Deploy via Azure CLI or GitHub Actions
3. Configure HTTPS binding in Azure portal

### IIS
1. Install ASP.NET Core Hosting Bundle
2. Publish and copy files to IIS directory
3. Create application pool and site

---

## Configuration

Edit `appsettings.json` to modify:
- URLs (Kestrel settings)
- Logging levels
- Environment-specific settings
