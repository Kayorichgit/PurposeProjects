Feature: BarsSnacks&Soups

As a user on Kafkaf website, I want to view categories,
so I can click Bars, Snacks & Soups categories and see its products.


Scenario: Viewing Bars, Snacks & Soups products.
	Given I am on Kafkaf products website "https://kafkaf.reteicons.com/"
	And I hover on categories to see drop downs
	And I click on Bars, Snacks and Soups item
	And I am directed to Bars, Snacks & Soups page
	When I click any page number at the bottom of the page
	Then Then I should be redirected to another page to see more products
