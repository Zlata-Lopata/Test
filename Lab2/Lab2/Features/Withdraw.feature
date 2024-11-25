Feature: Withdraw money from the account
  In order to manage my funds
  As a customer
  I want to withdraw a specific amount of money from my account.

Scenario: Successful withdrawal of funds
  Then I am logged in as Hermione Granger
  Then I am on the banking page
  When I withdraw "100" dollars
  Then I should see a message
