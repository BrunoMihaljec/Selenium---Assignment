Feature: SaucedemoCartFeature In order to test Cart functionality on saucedemo
As a developer
I want to ensure functionality is working end to end	
@mytag
Scenario: Cart page test
	Given I logged in as standard user
	And I added Sauce Labs Backpack to Cart
	And I navigate to Cart page
	When I click Menu
	Then Menu is displayed