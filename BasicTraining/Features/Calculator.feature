@severity:normal
Feature: Calculator
As a user
I want to use a calculator
So that I can perform basic arithmetic operations
    
    Background: 
        Given I have a calculator api running

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
        Then the result should be 4

    Scenario: Add a negative number
        Given I my first number is -7
        And I my second number is 2
        When I add the two numbers
        Then the result should be -5

    Scenario: Subtract with a large number
        Given I my first number is 2147483647
        And I my second number is 10
        When I subtract the two numbers
        Then the result should be 2147483637