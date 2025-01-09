Feature: ExploreMore

As a user visiting the KafKaf homepage,
 I want to see an "Explore More" button in the footer, 
 So that I can easily navigate to related sections through the buttons listed below it


Scenario: [To navigate to other sections through eplore more in the footer]
	Given that I am on Kafkaf webpage "https://kafkaf.reteicons.com/"
	And I click on visit herbal store on the footer
	And I am directed to herbal life store webpage
	And I click on visit juiceplus+ store
	And I am directed to juiceplus+ webpage
	When I click on become a partner 
	Then I should be directed to start your business page
