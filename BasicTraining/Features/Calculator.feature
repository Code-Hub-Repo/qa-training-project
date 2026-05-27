@severity:normal
Feature: Calculator
As a user
I want to use a calculator
So that I can perform basic arithmetic operations
    
    #The Background will run before each scenario in the feature, it is used to set up a common context for all scenarios
    #In this case, we are just making sure that the calculator API is running before we execute any of the scenarios
    
    Background: 
        Given I have a calculator api running

    @smoke
    Scenario: Add two numbers
        Given I my first number is 5
        And I my second number is 3
        When I add the two numbers
        Then the result should be 8