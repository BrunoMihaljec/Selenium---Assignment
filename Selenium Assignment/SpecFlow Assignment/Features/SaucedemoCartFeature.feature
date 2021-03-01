Feature: SaucedemoCartFeature In order to test login functionality on saucedemo
As a developer
I want to ensure functionality is working end to end	
@mytag
Scenario: Cart page test
	Given I logged in as standard user
	And I navigate to Cart page
	When I click Menu
	Then Menu is displayed