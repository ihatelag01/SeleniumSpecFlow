Feature: Add
Background: 
	Given I open the application
Scenario Outline: Should be able to enter values
	And I click add button
	When I enter <name>, <email>, <phone>
	Examples: 
	| name |     email    |    phone        |
	| 111  | 111@111.1111 |   1111111111    |  
	| 222  | 222@222.2222 |   2222222222    |   

Scenario: I should be able to enter name
	And I click add button
	When I enter the details
	| Name | E_mail      | Phone      |
    | 111  | 111@111.111 | 1111111111 |
    Then the values should be displayed
    | Name | E_mail      | Phone      |
    | 111  | 111@111.111 | 1111111111 |