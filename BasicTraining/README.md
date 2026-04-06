# QA Training - Running Tests

This project contains automated tests for a simple Calculator API.

## Prerequisites

- .NET 8 SDK installed
- JetBrains Rider installed

## How to run tests in Rider (2 ways)

### 1) Run tests using Rider IDE UI

1. Open `QATraining.Tests.sln` in Rider.
2. Wait for Rider to restore dependencies and index the solution.
3. Open the **Unit Tests** window.
4. Run tests in one of these ways:
   - Run all tests in the solution, or
   - Run tests from a specific feature/class (for example from `Features/Calculator.feature`).
5. Review results in the test runner panel.

### 2) Run tests using `dotnet test`

From the `BasicTraining` folder, run:

```powershell
dotnet test
```

You can also run from the solution file:

```powershell
cd {path/BasicTraining}
dotnet test
```

## Exercise

From the API test scenarios for a calculator service that has **two endpoints**:

- Add values
- Subtract values

### Exercise requirements

1. Add new Gherkin scenarios in `Features/Calculator.feature` for both endpoints.
2. Cover at least:
   - Happy path for add
   - Happy path for subtract
   - One edge case (for example: zero, negative values, or larger numbers)
3. Implement or update step definitions in `StepDefinitions/CalculatorSteps.cs` as needed.
4. Use `Services/CalculatorAPIClient.cs` to deploy the api. (How to deploy you can find in the read of the project).
5. Run tests.

