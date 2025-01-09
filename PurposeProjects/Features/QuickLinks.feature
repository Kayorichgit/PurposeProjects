Feature: QuickLinks

As a user on Kafkaf, I want to visit quick links, so I can
access some useful informations for myself.


Scenario: [Useful Links]
	Given I am using Kafkaf website "https://kafkaf.reteicons.com/"
	And I click on About us link
	And I am directed to About us page
	And I click on Contact us link
	And I am directed to Contact us page
	And I click FAQ link
	And I am directed to FAQ page
	When I click on All Product
	Then I must be directed to All Product page
