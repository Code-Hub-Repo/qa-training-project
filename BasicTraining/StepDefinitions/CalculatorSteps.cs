using System.Net;
using CalculatorAPI;
using FluentAssertions;
using QATraining.Tests.Helper;
using Reqnroll;

namespace QATraining.Tests.StepDefinitions;

[Binding]
public class CalculatorSteps(
    ScenarioContext scenarioContext,
    CalculatorAPIClient calculatorApiClient)
{
    
    [Given("I have a calculator api running")]
    public async Task GivenIHaveACalculatorApiRunning()
    {
        var response = await calculatorApiClient.HealthAsync();
        response.StatusCode.Should().Be((int)HttpStatusCode.OK);
    }

    [Given("I my first number is {int}")]
    public void GivenIMyFirstNumberIs(int number)
    {
        scenarioContext.SetFirstNumber(number);
    }

    [Given("I my second number is {int}")]
    public void GivenIMySecondNumberIs(int number)
    {
        scenarioContext.SetSecondNumber(number);
    }
    
    [When("I add the two numbers")]
    public async Task WhenIAddTheTwoNumbers()
    {
        var request = new CalculationRequest()
        {
            Number1 = scenarioContext.GetFirstNumber(),
            Number2 = scenarioContext.GetSecondNumber()
        };
        scenarioContext.SetOperation("+");
        var response = await calculatorApiClient.AddAsync(request);
        scenarioContext.SetResponse(response);
    }

    [When("I subtract the two numbers")]
    public async Task WhenISubtractTheTwoNumbers()
    {
        var request = new CalculationRequest()
        {
            Number1 = scenarioContext.GetFirstNumber(),
            Number2 = scenarioContext.GetSecondNumber()
        };
        scenarioContext.SetOperation("-");
        var response = await calculatorApiClient.SubtractAsync(request);
        scenarioContext.SetResponse(response);
    }

    [Then("the result should be {int}")]
    public void ThenTheResultShouldBe(int result)
    {
        var firstNumber = scenarioContext.GetFirstNumber();
        var secondNumber = scenarioContext.GetSecondNumber();
        var operation = scenarioContext.GetOperation();
        var response = scenarioContext.GetResponse();
        response.StatusCode.Should().Be((int)HttpStatusCode.OK);
        response.Result.Number1.Should().Be(firstNumber);
        response.Result.Number2.Should().Be(secondNumber);
        response.Result.Operation.Should().Be(operation);
        response.Result.Result.Should().Be(result);
    }
}
