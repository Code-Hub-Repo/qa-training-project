using CalculatorAPI;
using Reqnroll;
using Reqnroll.BoDi;

namespace QATraining.Tests.Hooks;

[Binding]
public class Hooks(IObjectContainer container)
{
    
    [BeforeScenario]
    public void SetUp()
    {
        const string url = "http://localhost:5232";
        var httpClient = new HttpClient();
        var calculator = new CalculatorAPIClient(url, httpClient);
        container.RegisterInstanceAs<CalculatorAPIClient>(calculator);
    }
}