using CalculatorAPI;
using Reqnroll;
using Reqnroll.BoDi;

namespace QATraining.Tests.Hooks;

[Binding]
public class Hooks()
{
    [BeforeTestRun(Order = 1)]
    public static void BeforeTestRun(IObjectContainer objectContainer)
    {
        const string url = "http://localhost:5232";
        var httpClient = new HttpClient();
        var calculator = new CalculatorAPIClient(url, httpClient);
        objectContainer.RegisterInstanceAs(calculator);
    }

    [AfterScenario]
    public void TearDown(ScenarioContext scenarioContext)
    {
        var result = scenarioContext.ScenarioExecutionStatus;
        Console.WriteLine("Result: " + result);
    }
}