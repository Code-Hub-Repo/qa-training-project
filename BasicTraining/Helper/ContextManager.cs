using CalculatorAPI;
using QATraining.Tests.Helper.Enums;
using Reqnroll;

namespace QATraining.Tests.Helper;

public  static class ContextManager
{
    private static T GetContextValue<T>(this ScenarioContext context, string key)
    {
        return !context.TryGetValue(key, out T value)
            ? throw new KeyNotFoundException($"Key {key} not found.")
            : value;
    }
    
    public static void SetFirstNumber(this ScenarioContext scenarioContext, int firstNumber) =>
        scenarioContext[nameof(ContextEnum.FirstNumber)] = firstNumber;
    
    public static void SetSecondNumber(this ScenarioContext scenarioContext, int secondNumber) =>
        scenarioContext[nameof(ContextEnum.SecondNumber)] = secondNumber;
    
    public static void SetResponse(this ScenarioContext scenarioContext, SwaggerResponse<CalculationResult> result) =>
        scenarioContext[nameof(ContextEnum.Response)] = result;

    public static int GetFirstNumber(this ScenarioContext scenarioContext) =>
        scenarioContext.GetContextValue<int>(nameof(ContextEnum.FirstNumber));

    public static int GetSecondNumber(this ScenarioContext scenarioContext) =>
        scenarioContext.GetContextValue<int>(nameof(ContextEnum.SecondNumber));

    public static SwaggerResponse<CalculationResult> GetResponse(this ScenarioContext scenarioContext) =>
        scenarioContext.GetContextValue<SwaggerResponse<CalculationResult>>(nameof(ContextEnum.Response));
}