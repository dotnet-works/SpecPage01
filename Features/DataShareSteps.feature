Feature: DataShareSteps

A short summary of the feature

@foxy
Scenario: 1.Test share stepdata same stepdef file
	Given open app url "https://admin.foxycart.com/signup/"
	When enter all data
	Then user navigates to newpage

@foxy
Scenario:2.Test share stepdata in multiple step files
	Given open app url "https://admin.foxycart.com/signup/"
	When enter all data
	And acces data

@foxy
Scenario:1.Create New User
   Given open app url "https://admin.foxycart.com/signup/"
   When enter "about you" data
   When enter "consider yourself" data
   When enter "about store" data
   When click submit button
   Then user should navigate to new page