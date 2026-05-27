using System.Net;
using CalculatorAPI;
using FluentAssertions;
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
        ScenarioContext.StepIsPending();
        // Implement here the step to set the first number in the scenario context
    }
    
    // Implement the rest of the steps for setting the second number, performing the addition, and verifying the result
}
