using System.Net;
using Allure.Commons;
using CalculatorAPI;
using FluentAssertions;
using QATraining.Tests.Helper;
using Reqnroll;
using Reqnroll.BoDi;

namespace QATraining.Tests.StepDefinitions;

[Binding]
public class CalculatorSteps(ObjectContainer container, ScenarioContext scenarioContext) : BaseStepDefinitions(container, scenarioContext)
{
    private CalculatorAPIClient _calculator;

    [Given(@"I have a calculator")]
    public void GivenIHaveACalculator()
    {
        const string url = "http://localhost:5232";
        var httpClient = new HttpClient();
        _calculator = new CalculatorAPIClient(url, httpClient);
    }

    [Given("I my first number is {int}")]
    public void GivenIMyFirstNumberIs(int number)
    {
        ScenarioContext.SetFirstNumber(number);
    }

    [Given("I my second number is {int}")]
    public void GivenIMySecondNumberIs(int number)
    {
        ScenarioContext.SetSecondNumber(number);
    }

    [When("I add the two numbers")]
    public async Task WhenIAddTheTwoNumbers()
    {
        var request = new CalculationRequest()
        {
            Number1 = ScenarioContext.GetFirstNumber(),
            Number2 = ScenarioContext.GetSecondNumber()
        };
        ScenarioContext["Operation"] = "+";
        var response = await _calculator.AddAsync(request);
        ScenarioContext.SetResponse(response);
    }

    [When("I subtract the two numbers")]
    public void WhenISubtractTheTwoNumbers()
    {
        ScenarioContext.StepIsPending();
    }

    [Then("the result should be {int}")]
    public void ThenTheResultShouldBe(int result)
    {
        var firstNumber = ScenarioContext.GetFirstNumber();
        var secondNumber = ScenarioContext.GetSecondNumber();
        var operation = ScenarioContext["Operation"] as string;
        var response = ScenarioContext.GetResponse();
        response.StatusCode.Should().Be((int)HttpStatusCode.OK);
        response.Result.Number1.Should().Be(firstNumber);
        response.Result.Number2.Should().Be(secondNumber);
        response.Result.Operation.Should().Be(operation);
        response.Result.Result.Should().Be(result);
    }
}
