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


# Exercise

## Objective

Practice writing and refactoring BDD scenarios using Gherkin syntax.

## Tasks

### 1. Implement the Existing Scenario

Implement all the necessary steps for the current scenario already provided in the project.

#### Requirements

* Create the step definitions required by the scenario.
* Ensure the scenario executes successfully.
* Validate that all assertions pass.

### Tips
If you need to share information between steps, consider using a context object or class to store and retrieve data across steps.
More info in https://docs.reqnroll.net/latest/automation/scenario-context.html

---

### 2. Create a Subtraction Scenario

Add a new scenario that validates subtraction behavior.

#### Requirements

* Create a scenario describing a subtraction operation.
* Implement any additional step definitions if necessary.
* Ensure the scenario executes successfully.

#### Example

```gherkin
Scenario: Subtract two numbers
  Given I have entered 10 into the calculator
  And I have entered 4 into the calculator
  When I subtract the two numbers
  Then the result should be 6
```

---

### 3. Refactor Using Scenario Outline

Refactor both the sum and subtraction scenarios to use `Scenario Outline`.

#### Requirements

* Replace duplicated scenarios with a parameterized version.
* Use an `Examples` table to provide test data.
* Keep the scenarios readable and maintainable.

#### Examples

Can be found in the documentation Reqnroll:
https://docs.reqnroll.net/latest/gherkin/gherkin-reference.html

---

## Expected Outcome

By the end of this exercise, you should be able to:

* Implement Gherkin step definitions.
* Create new BDD scenarios.
* Refactor duplicated scenarios using `Scenario Outline`.
* Improve test maintainability and readability.

### 4. Challenge 1 - Enhance the Scenario context
Enhance the scenario context to support more complex data sharing between steps.

#### Requirements
* Implement a helper class that centralizes read/write access to Reqnroll ScenarioContext values for test steps.
* Reduce the error due some typos when using string keys to store/retrieve values from the ScenarioContext.

### 5. Challenge 2 - Create a interactive report with Allure

#### Requirements
* Integrate Allure reporting into the test project.
* Configure Allure to generate interactive test reports after test execution.

For more information about Allure and how to integrate it with your tests, you can refer to the official documentation:
https://allurereport.org/docs/reqnroll/