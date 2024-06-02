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

@foxy @wip1
Scenario:2.Demo or condition1
   Given open site url "https://admin.foxycart.com/signup/"

@foxy @wip2
Scenario:3.Demo or condition2
   Given open site url "https://admin.foxycart.com/signup/"
   When enter new user "about you" data
                        | About-You |
                        | firstName |
                        | lastName  |
                        | email     |
                        | password  |
                        | comment1  |
                        | comment2  |
    Then email shoild be avialiable with new user
