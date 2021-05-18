Feature: Scenario for restrictions feature

@Headless
Scenario: Cancel out of the Restrictions page
	Given I am on the login page
	And I click on the Confluence link
	When I click on my space
	And I am redirected to the Overview page
	And I navigate to the restrictions page
	When I click the cancel button
	Then I am redirected to the Overview page

@Headless
Scenario: Add restriction - anyone can view & edit
	Given I am on the login page
	And I click on the Confluence link
	When I click on my space
	And I am redirected to the Overview page
	And I navigate to the restrictions page
	When I choose the permission
	Then I am able to add the user

@Headless
Scenario: Add restriction - anyone can view & some can edit
	Given I am on the login page
	And I click on the Confluence link
	When I click on my space
	And I am redirected to the Overview page
	And I navigate to the restrictions page
	When I choose the permission for this scenario
	And I choose the user for this scenario
	Then I am able to add the user

@Headless
Scenario: Delete user - anyone can view & some can edit restriction
	Given I am on the login page
	And I click on the Confluence link
	When I click on my space
	And I am redirected to the Overview page
	And I navigate to the restrictions page
	When I click on the remove button
	Then the user is removed

@Headless
Scenario: Modify restriction after adding user - specific people can view or edit restriction
	Given I am on the login page
	And I click on the Confluence link
	When I click on my space
	And I am redirected to the Overview page
	And I navigate to the restrictions page
	When I choose the permission to a specific user
	And I choose the user
	And click on edit
	Then I am able to add the user

@Headless
Scenario: Remove user - specific people can view or edit restriction
	Given I am on the login page
	And I click on the Confluence link
	When I click on my space
	And I am redirected to the Overview page
	And I navigate to the restrictions page
	When I click on the remove button
	Then the user is removed

#@Headless
#Scenario: Run all the scenarios at once
#	Given I am on the login page
#	And I click on the Confluence link
#	When I click on my space
#	And I am redirected to the Overview page
#	And I navigate to the restrictions page
#	When I click the cancel button
#	And I am redirected to the Overview page
#	And I navigate to the restrictions page
#	When I choose the permission
#	Then I am able to add the user
#	And I am redirected to the Overview page
#	And I navigate to the restrictions page
#	When I choose the permission for this scenario
#	And I choose the user for this scenario
#	Then I am able to add the user
#	And I am redirected to the Overview page
#	And I navigate to the restrictions page
#	When I click on the remove button
#	Then the user is removed
#	And I am redirected to the Overview page
#	And I navigate to the restrictions page
#	When I choose the permission to a specific user
#	And I choose the user
#	And click on edit
#	Then I am able to add the user
#	And I am redirected to the Overview page
#	And I navigate to the restrictions page
#    When I click on the remove button
#	Then the user is removed