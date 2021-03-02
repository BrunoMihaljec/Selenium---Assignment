Feature: SaucedemoInventoryFeatur In order to test Inventory functionality on saucedemo
As a developer
I want to ensure functionality is working end to end

@mytag
	Scenario: Saucedemo inventory page test
		Given I logged in 
		And I navigated to saucedemo inventory page
		When I click Menu button
		Then Menu has been displayed