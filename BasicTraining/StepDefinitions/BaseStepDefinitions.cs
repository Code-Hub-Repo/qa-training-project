using Reqnroll;
using Reqnroll.BoDi;

namespace QATraining.Tests.StepDefinitions;

public class BaseStepDefinitions(IObjectContainer container, ScenarioContext scenarioContext)
{
    protected readonly ScenarioContext ScenarioContext = scenarioContext;
}