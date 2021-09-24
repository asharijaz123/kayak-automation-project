Feature: FlightSearch
	Verify the Search functionality of Kayak Application

@mytag
Scenario: One way trip for Flights 
	Given I navigate to the Kayak Appliation
	When I Click on Flights Module
	And I Select the Type of Trip
	| tripType |
	|  One-way |
	And I Select the Number of Passengers
	| totalPassenger | passengerType |
	| 3              | Adults        |
	And I Select the Type of Class
	| classType			|
	| Premium Economy   |
	And I Enter the From Location for Flight
	| fromLocation |  
	| Lahore       |     
	And I Enter the To Location for Flight
	| toLocation |
	| Karachi    |
	And I Click on the Searh Button
	Then I Verify the Search

@mutli-city
Scenario: Multi City trip for Flights 
	Given I navigate to the Kayak Appliation
	When I Click on Flights Module
	And I Select the Type of Trip
	| tripType    |
	|  Multi-city |
	And I Select the Number of Passengers
	| totalPassenger | passengerType |
	| 3              | Adults        |   
	And I Enter the To Location for Multi City for Flight
	| toLocation |
	| Karachi    |
	And I Enter the From Location for Multi City Flight
	| fromLocation |
	| Karachi      |
	And I Click on the Searh Button
	Then I Verify the Search

