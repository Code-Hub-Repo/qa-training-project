@severity:normal
Feature: Calculator
As a user
I want to use a calculator
So that I can perform basic arithmetic operations
    
    Background: 
        Given I have a calculator

    @smoke
    Scenario: Add two numbers
        Given I my first number is 5
        And I my second number is 3
        When I add the two numbers
        Then the result should be 8

    @smoke
    Scenario: Subtract two numbers
        Given I my first number is 10
        And I my second number is 6
        When I subtract the two numbers
        Then the result should be 6