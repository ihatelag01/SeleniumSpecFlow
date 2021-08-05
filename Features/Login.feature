Feature: Login
Background: 
	Given I am on the login page
Scenario Outline: Enter valid email and password
	When I input <email>, <password>
	And I Click on the login button
	Then I should be redirected to the home page
	Examples: 
	| email                             | password      | 
    | alexandru.vizitiu@student.usv.ro  | student330225 | 

Scenario Outline: Enter invalid email and password
	When I input <email>, <password>
	And I Click on the login button
	Then Invalid credentials message should be visible
	Examples: 
	| email          | password      | 
    | test@test.com  |           123 | 