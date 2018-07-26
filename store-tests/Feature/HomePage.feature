Feature: HomePage
	
Background: 
			Given I am on the / page

Scenario Outline: The header links navigate to the correct pages
			When I click the <link> header link
			Then I am redirected to the /<url> url
			Examples: 
			| link | url      |
			| user | register |		