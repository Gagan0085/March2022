Feature: TMFeature

As a TurnUp portal admin
I would like to create, edit and delete time and material records
so that I can manage employees time and materials successfully


Scenario: Create Time and Material record with valid details
	Given I logged into the TurnUp portal successfully
	When I navigate to Time and Material page
	When I create a new file
	Then the record should be created successfully
