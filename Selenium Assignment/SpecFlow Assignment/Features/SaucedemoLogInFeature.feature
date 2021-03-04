Feature: SaucedemoLogInFeature In order to test Login functionality on saucedemo
As a developer
I want to ensure functionality is working end to end
@login
Scenario: Saucedemo failed LogIn
	Given I have navigated to saucedemo website	
	And I entered '<Username>' as username
	And I entered '<Password>' as password
	When I submit LOGIN button
	Then the login should fail with '<Message>'
Examples: 
| Username      | Password     | Message                                                                   |
|               |              | Epic sadface: Username is required                                        |
|               | Mihaljec     | Epic sadface: Username is required                                        |
| Bruno         |              | Epic sadface: Password is required                                        |
| Bruno         | Mihaljec     | Epic sadface: Username and password do not match any user in this service |
| Bruno         | secret_sauce | Epic sadface: Username and password do not match any user in this service |
| standard_user | Mihaljec     | Epic sadface: Username and password do not match any user in this service |

Scenario: Saucedemo LogIn
	Given I have navigated to saucedemo website
	And I entered correct username: '<CorrectUsername>'
	And I entered correct password: '<CorrectPassword>'
	When I submit LOGIN button
	Then I should be navigated to inventory page
	Examples: 
	| CorrectUsername         | CorrectPassword |
	| standard_user           | secret_sauce    |

	


